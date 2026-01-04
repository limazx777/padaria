using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace sistema_pdv // <--- VERIFIQUE ESSE NOME
{
    public partial class TelaVendas : Form
    {
        private decimal totalCompra = 0;
        private decimal totalPago = 0; // novo: total já pago na venda (aceita pagamentos parciais)
        private int contadorItens = 0;
        private bool vendaIniciada = false;

        // NOVO: lista para armazenar os itens da venda (usada para gerar o cupom fiscal)
        private List<SaleItem> itensVenda = new List<SaleItem>();

        public TelaVendas()
        {
            InitializeComponent();
            ConfigurarSistema();
        }

        private void ConfigurarSistema()
        {
            // IMAGEM
            try { pbLogo.ImageLocation = @"C:\logo_ia_studio.png"; } catch { }

            // TECLADO (CRUCIAL PARA F1, F2, ESC)
            this.KeyPreview = true;
            this.KeyDown += TelaVendas_KeyDown;

            // BOTÕES MOUSE (Conexão explícita)
            btnDinheiro.Click += (s, e) => PagarDinheiro();
            btnPix.Click += (s, e) => PagarPix();
            btnCartao.Click += (s, e) => PagarCartao(); // <--- CHAMA A JANELA DE CARTÃO
            btnSair.Click += (s, e) => TentarSair();
            btnCancelarVenda.Click += (s, e) => CancelarComGerente();

            // BUSCA
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            this.Load += (s, e) => txtBuscar.Select();

            // RESPONSIVIDADE
            flowListaProdutos.SizeChanged += (s, e) => {
                foreach (Control c in flowListaProdutos.Controls) c.Width = flowListaProdutos.ClientSize.Width - 10;
            };
        }

        // --- TECLAS (ESC, F1, F2, F3) ---
        private void TelaVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) { PagarDinheiro(); e.Handled = true; return; }
            if (e.KeyCode == Keys.F2) { PagarCartao(); e.Handled = true; return; }
            if (e.KeyCode == Keys.F3) { PagarPix(); e.Handled = true; return; }

            // LÓGICA DO ESC
            if (e.KeyCode == Keys.Escape)
            {
                if (vendaIniciada)
                {
                    // SE TEM VENDA: NÃO FAZ NADA (BLOQUEIA SAÍDA)
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    // SE NÃO TEM VENDA: SAI DA TELA
                    this.Close();
                }
            }
        }

        // --- SISTEMA DE PAGAMENTO ---
        private void PagarDinheiro()
        {
            if (!ValidarVenda()) return;

            decimal restante = totalCompra - totalPago;
            var recebido = PromptValorRecebido(restante);
            if (recebido == null) return; // usuário cancelou

            totalPago += recebido.Value;

            if (totalPago >= totalCompra)
            {
                decimal troco = totalPago - totalCompra;
                // Gera cupom fiscal antes de resetar a venda
                GerarCupomFiscal("Dinheiro", totalPago, troco);
                MessageBox.Show($"Pagamento em DINHEIRO recebido: R$ {totalPago:F2}\nTroco: R$ {troco:F2}", "Sucesso");
                ResetarVenda();
            }
            else
            {
                // pagamento parcial aceito; atualiza valores na UI e mantém venda aberta
                lblValorPago.Text = $"R$ {totalPago:F2}";
                lblValorPagar.Text = $"R$ {(totalCompra - totalPago):F2}";
                MessageBox.Show($"Pagamento parcial recebido: R$ {recebido.Value:F2}\nRestante: R$ {(totalCompra - totalPago):F2}", "Pagamento Parcial");
            }
        }

        private void PagarPix()
        {
            if (!ValidarVenda()) return;

            decimal restante = totalCompra - totalPago;
            var recebido = PromptValorRecebido(restante);
            if (recebido == null) return;

            totalPago += recebido.Value;

            if (totalPago >= totalCompra)
            {
                // Gera cupom fiscal antes de resetar a venda
                GerarCupomFiscal("PIX", totalPago, totalPago - totalCompra);
                MessageBox.Show($"Pagamento via PIX recebido: R$ {totalPago:F2}", "Sucesso");
                ResetarVenda();
            }
            else
            {
                lblValorPago.Text = $"R$ {totalPago:F2}";
                lblValorPagar.Text = $"R$ {(totalCompra - totalPago):F2}";
                MessageBox.Show($"Pagamento parcial via PIX recebido: R$ {recebido.Value:F2}\nRestante: R$ {(totalCompra - totalPago):F2}", "Pagamento Parcial");
            }
        }

        private void PagarCartao()
        {
            if (!ValidarVenda()) return;

            // ABRE A JANELA DE OPÇÃO (Débito/Crédito)
            using (var opcao = new FormOpcaoCartao())
            {
                if (opcao.ShowDialog() == DialogResult.OK)
                {
                    decimal restante = totalCompra - totalPago;
                    var recebido = PromptValorRecebido(restante);
                    if (recebido == null) return;

                    totalPago += recebido.Value;

                    if (totalPago >= totalCompra)
                    {
                        // Gera cupom fiscal antes de resetar a venda (inclui tipo de cartão)
                        GerarCupomFiscal($"Cartão ({opcao.TipoSelecionado})", totalPago, totalPago - totalCompra);
                        MessageBox.Show($"Pagamento {opcao.TipoSelecionado} recebido: R$ {totalPago:F2}", "Sucesso");
                        ResetarVenda();
                    }
                    else
                    {
                        lblValorPago.Text = $"R$ {totalPago:F2}";
                        lblValorPagar.Text = $"R$ {(totalCompra - totalPago):F2}";
                        MessageBox.Show($"Pagamento parcial ({opcao.TipoSelecionado}) recebido: R$ {recebido.Value:F2}\nRestante: R$ {(totalCompra - totalPago):F2}", "Pagamento Parcial");
                    }
                }
            }
        }

        private bool ValidarVenda()
        {
            if (!vendaIniciada || totalCompra == 0)
            {
                MessageBox.Show("Não há itens para pagar.", "Atenção");
                return false;
            }
            return true;
        }

        // --- CANCELAMENTO (GERENTE) ---
        private void CancelarComGerente()
        {
            using (var login = new FormLoginGerente())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    ResetarVenda();
                    MessageBox.Show("Venda cancelada pelo Gerente.", "Cancelamento");
                }
            }
        }

        // --- SAÍDA ---
        private void TentarSair()
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (vendaIniciada)
            {
                e.Cancel = true;
                MessageBox.Show("VENDA EM ANDAMENTO!\nUse o botão 'CANCELAR VENDA' (Vermelho) para sair.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            base.OnFormClosing(e);
        }

        // --- PRODUTOS ---
        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                e.SuppressKeyPress = true;
                AdicionarProduto(txtBuscar.Text.Trim());
                txtBuscar.Clear();
            }
        }

        private void AdicionarProduto(string codigo)
        {
            string nome = "PRODUTO " + codigo;
            decimal preco = 10.00m;
            int qtd = 1;

            if (codigo == "1") { nome = "Coca Cola 2L"; preco = 8.50m; }
            if (codigo == "2") { nome = "Salgadinho"; preco = 5.00m; }

            decimal total = preco * qtd;
            contadorItens++;
            totalCompra += total;

            // ADICIONA O ITEM NA LISTA PARA CUPOM FISCAL
            itensVenda.Add(new SaleItem
            {
                Quantity = qtd,
                Code = codigo,
                Description = nome,
                UnitPrice = preco,
                Total = total
            });

            CriarItemVisual(contadorItens, "789", nome, qtd, preco, total);

            lblValorTotal.Text = $"R$ {totalCompra:F2}";
            // mostrar restante considerando já pagos (se houver)
            lblValorPagar.Text = $"R$ {(totalCompra - totalPago):F2}";

            if (!vendaIniciada)
            {
                vendaIniciada = true;
                lblTituloCaixa.Text = "CAIXA 1 - OCUPADO";
                lblTituloCaixa.ForeColor = Color.Yellow;
                btnCancelarVenda.Visible = true;
            }
        }

        private void CriarItemVisual(int id, string cod, string nome, int qtd, decimal unit, decimal total)
        {
            Panel p = new Panel();
            p.Width = flowListaProdutos.ClientSize.Width - 10;
            p.Height = 90;
            p.BackColor = Color.FromArgb(245, 245, 245);
            p.Margin = new Padding(0, 0, 0, 5);
            p.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.FromArgb(0, 100, 160), 2, ButtonBorderStyle.Solid, Color.FromArgb(0, 100, 160), 2, ButtonBorderStyle.Solid, Color.FromArgb(0, 100, 160), 2, ButtonBorderStyle.Solid, Color.FromArgb(0, 100, 160), 2, ButtonBorderStyle.Solid);

            Label lId = new Label { Text = $"#{id:D2}", BackColor = Color.FromArgb(0, 50, 80), ForeColor = Color.White, Font = new Font("Arial", 14, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Size = new Size(60, 40), Location = new Point(15, 25) };
            Label lNome = new Label { Text = nome, Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(90, 30), AutoSize = true };
            Label lTotal = new Label { Text = $"R$ {total:F2}", Font = new Font("Segoe UI", 18, FontStyle.Bold), ForeColor = Color.FromArgb(64, 64, 64), Location = new Point(p.Width - 160, 30), AutoSize = true, Anchor = AnchorStyles.Top | AnchorStyles.Right };

            p.Controls.Add(lId); p.Controls.Add(lNome); p.Controls.Add(lTotal);
            flowListaProdutos.Controls.Add(p);
            flowListaProdutos.ScrollControlIntoView(p);
        }

        private void ResetarVenda()
        {
            vendaIniciada = false;
            totalCompra = 0;
            totalPago = 0;
            contadorItens = 0;
            flowListaProdutos.Controls.Clear();
            lblValorTotal.Text = "R$ 0,00";
            lblValorPago.Text = "R$ 0,00";
            lblValorPagar.Text = "R$ 0,00";
            lblTituloCaixa.Text = "CAIXA 1 - LIVRE";
            lblTituloCaixa.ForeColor = Color.White;
            btnCancelarVenda.Visible = false;

            // limpa lista de itens
            itensVenda.Clear();

            txtBuscar.Focus();
        }

        // Adicione este método auxiliar à classe TelaVendas (mantém a UI mínima para pedir o valor recebido)
        // Agora inicia com 0 e mostra restante dinâmico; retorna o valor inserido (pode ser parcial)
        private decimal? PromptValorRecebido(decimal totalRemaining)
        {
            using (var f = new Form())
            {
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.StartPosition = FormStartPosition.CenterParent;
                f.MinimizeBox = false;
                f.MaximizeBox = false;
                f.ShowInTaskbar = false;
                f.Text = "Valor recebido";
                f.ClientSize = new System.Drawing.Size(420, 200);

                var tbl = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    Padding = new Padding(10),
                    ColumnCount = 1,
                    RowCount = 4
                };
                tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // total label
                tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 44)); // input
                tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // restante/troco
                tbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 56)); // buttons

                var lblTotal = new Label
                {
                    Text = $"Total restante: R$ {totalRemaining:F2}",
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular)
                };

                var nud = new NumericUpDown
                {
                    DecimalPlaces = 2,
                    ThousandsSeparator = true,
                    Minimum = 0m,
                    Maximum = totalRemaining * 10m + 1000m, // margem para permitir troco
                    Value = 0m, // começa zerado
                    Increment = 1m,
                    Dock = DockStyle.Fill,
                    Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold),
                    TextAlign = HorizontalAlignment.Right
                };

                var lblRestante = new Label
                {
                    Text = $"Restante: R$ {totalRemaining:F2}",
                    Dock = DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular)
                };

                var pnlButtons = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.RightToLeft,
                    Padding = new Padding(0),
                    AutoSize = false
                };

                var btnOk = new Button
                {
                    Text = "Receber",
                    DialogResult = DialogResult.OK,
                    Width = 120,
                    Height = 36,
                    BackColor = System.Drawing.Color.FromArgb(46, 204, 113),
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
                };
                btnOk.FlatAppearance.BorderSize = 0;

                var btnCancel = new Button
                {
                    Text = "Cancelar",
                    DialogResult = DialogResult.Cancel,
                    Width = 100,
                    Height = 36,
                    FlatStyle = FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI", 9F),
                    Anchor = AnchorStyles.Right
                };

                // Atualiza restante / troco quando valor muda
                nud.ValueChanged += (s, e) =>
                {
                    decimal v = nud.Value;
                    decimal novo = totalRemaining - v;
                    if (novo < 0)
                        lblRestante.Text = $"Troco: R$ {Math.Abs(novo):F2}";
                    else
                        lblRestante.Text = $"Restante: R$ {novo:F2}";
                };

                // Validação no OK
                btnOk.Click += (s, e) =>
                {
                    // nã o permite fechar se valor inválido (negativo não é possível no nud)
                    if (nud.Value < 0)
                    {
                        MessageBox.Show("Insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    f.DialogResult = DialogResult.OK;
                    f.Close();
                };

                pnlButtons.Controls.Add(btnOk);
                pnlButtons.Controls.Add(btnCancel);

                tbl.Controls.Add(lblTotal, 0, 0);
                tbl.Controls.Add(nud, 0, 1);
                tbl.Controls.Add(lblRestante, 0, 2);
                tbl.Controls.Add(pnlButtons, 0, 3);

                f.Controls.Add(tbl);

                // Define botões padrão para Enter/Esc
                f.AcceptButton = btnOk;
                f.CancelButton = btnCancel;

                var dr = f.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    // NumericUpDown.Value é decimal já formatado
                    return nud.Value;
                }

                return null;
            }
        }

        // NOVO: estrutura interna para representar itens
        private class SaleItem
        {
            public int Quantity { get; set; }
            public string Code { get; set; }
            public string Description { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Total { get; set; }
        }

        // NOVO: gera o texto do cupom fiscal e exibe / salva
        private void GerarCupomFiscal(string formaPagamento, decimal valorPago, decimal troco)
        {
            var sb = new StringBuilder();
            var now = DateTime.Now;

            // Cabeçalho simplificado: REMOVIDO MOD.65 / SÉRIE / N° / INSCR.EST / CHAVE / QR (conforme solicitado)
            sb.AppendLine("NOTA FISCAL DE CONSUMIDOR ELETRÔNICA - NFC-e");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine("PADARIA PÃO QUENTE LTDA"); // ajuste para seus dados reais
            sb.AppendLine("NOME FANTASIA: PADARIA PÃO QUENTE");
            sb.AppendLine("CNPJ: 12.345.678/0001-90");
            sb.AppendLine("RUA CENTRAL, Nº 100 - CENTRO");
            sb.AppendLine("LAGO DA PEDRA - MA - CEP: 65715-000");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendFormat("{0:dd/MM/yyyy HH:mm:ss}\r\n", now);
            sb.AppendLine("CONSUMIDOR: NÃO INFORMADO");
            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine("ITEM  DESCRIÇÃO                     QTD  VL UNIT   VL ITEM");
            sb.AppendLine("--------------------------------------------------");

            int idx = 1;
            foreach (var it in itensVenda)
            {
                // linha formatada com comprimento aproximado; ajustar se necessário
                sb.AppendFormat("{0:000} {1,-25} {2,3} x {3,6:N2} {4,10:N2}\r\n",
                    idx, Truncate(it.Description, 25), it.Quantity, it.UnitPrice, it.Total);
                idx++;
            }

            sb.AppendLine("--------------------------------------------------");
            sb.AppendFormat("{0,-30} {1,10:N2}\r\n", "TOTAL", totalCompra);
            sb.AppendLine();
            sb.AppendFormat("{0,-30} {1,10:N2}\r\n", $"PAGAMENTO: {formaPagamento}", valorPago);
            sb.AppendFormat("{0,-30} {1,10:N2}\r\n", "TROCO", troco);
            sb.AppendLine();
            // Tributos aproximados (exemplo): calc. simples 15% ou enviar real se tiver
            decimal tributosAprox = Math.Round(totalCompra * 0.15m, 2);
            sb.AppendFormat("{0,-30} R$ {1,10:N2}\r\n", "TRIBUTOS APROX.", tributosAprox);

            sb.AppendLine("--------------------------------------------------");
            sb.AppendLine();
            sb.AppendLine("OBRIGADO PELA PREFERÊNCIA! VOLTE SEMPRE :)");

            // Exibe dentro do sistema usando o novo FormNotaFiscal (sem abrir .txt externo)
            var textoCupom = sb.ToString();
            using (var f = new FormNotaFiscal(textoCupom))
            {
                f.ShowDialog(this);
            }
        }

        private string Truncate(string s, int max)
        {
            if (string.IsNullOrEmpty(s)) return s;
            return s.Length <= max ? s : s.Substring(0, max);
        }

        // NOVO: mostra o cupom em uma janela e permite salvar em .txt
        private void AbrirPreviewCupom(string texto)
        {
            using (var f = new Form())
            {
                f.Text = "Cupom Fiscal";
                f.StartPosition = FormStartPosition.CenterParent;
                f.ClientSize = new Size(640, 520);
                f.FormBorderStyle = FormBorderStyle.FixedDialog;

                var txt = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Dock = DockStyle.Fill,
                    ScrollBars = ScrollBars.Both,
                    Font = new Font("Consolas", 10),
                    Text = texto
                };

                var pnl = new Panel { Dock = DockStyle.Bottom, Height = 48 };
                var btnSalvar = new Button
                {
                    Text = "Salvar (TXT)",
                    Width = 120,
                    Height = 32,
                    Left = f.ClientSize.Width - 140,
                    Anchor = AnchorStyles.Right | AnchorStyles.Bottom
                };
                btnSalvar.Click += (s, e) =>
                {
                    try
                    {
                        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"cupom_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
                        File.WriteAllText(fileName, texto, Encoding.UTF8);
                        Process.Start("notepad.exe", fileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar cupom: " + ex.Message, "Erro");
                    }
                };

                pnl.Controls.Add(btnSalvar);
                f.Controls.Add(txt);
                f.Controls.Add(pnl);

                f.ShowDialog(this);
            }
        }
    }
}