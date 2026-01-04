using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sistema_pdv
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            this.Load += DashboardForm_Load;
            this.FormClosing += DashboardForm_FormClosing;
            // Atualiza estado sempre que a janela volta a ficar ativa (útil após diálogos)
            this.Activated += (s, e) => AtualizarEstadoBotoes();

            // Registra handlers adicionais para abrir telas que faltavam
            this.btnCategorias.Click += (s, e) => btnCategorias_Click(s, e);
            this.btnRelatorios.Click += (s, e) => btnRelatorios_Click(s, e);
            this.btnUsuarios.Click += (s, e) => btnUsuarios_Click(s, e);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            AtualizarEstadoBotoes();
        }

        private void AtualizarEstadoBotoes()
        {
            bool aberto = TelaCaixa.CaixaAberto;

            // Habilita/desabilita funcionalidades operacionais conforme o estado do caixa
            btnVendas.Enabled = aberto;
            btnProdutos.Enabled = aberto;
            btnClientes.Enabled = aberto;
            btnCategorias.Enabled = aberto;
            btnRelatorios.Enabled = aberto;
            btnUsuarios.Enabled = aberto;

            // Botão de caixa sempre disponível para abrir/consultar
            btnCaixa.Enabled = true;

            // Botão de sair sempre disponível
            btnSair.Enabled = true;

            // Ajuste visual do botão de caixa para indicar status
            if (aberto)
            {
                btnCaixa.Text = "Caixa (Aberto)";
                btnCaixa.BackColor = Color.FromArgb(46, 204, 113);
            }
            else
            {
                btnCaixa.Text = "Abrir Caixa";
                btnCaixa.BackColor = SystemColors.Control;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Solicita fechamento da janela principal — o FormClosing verificará o estado do caixa
            this.Close();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Impede encerrar o aplicativo enquanto o caixa estiver aberto
            if (TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("O caixa está aberto. Feche o caixa antes de encerrar o aplicativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            if (!TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("Abra o caixa para acessar vendas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TelaVendas vendas = new TelaVendas();
            vendas.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            if (!TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("Abra o caixa para acessar produtos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TelaProdutos produtos = new TelaProdutos();
            produtos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            using (TelaCaixa tela = new TelaCaixa())
            {
                tela.StartPosition = FormStartPosition.CenterParent;
                tela.ShowDialog(this);
            }

            AtualizarEstadoBotoes();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (!TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("Abra o caixa para acessar clientes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Implementação de clientes aqui
        }

        // NOVOS HANDLERS
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            if (!TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("Abra o caixa para acessar categorias.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var f = new TelaCategorias())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (!TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("Abra o caixa para acessar relatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var f = new TelaRelatorios())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (!TelaCaixa.CaixaAberto)
            {
                MessageBox.Show("Abra o caixa para acessar usuários.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var f = new TelaUsuarios())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.ShowDialog(this);
            }
        }

        private void flowLayoutDireita_SizeChanged(object sender, EventArgs e)
        {
            int available = flowLayoutDireita.ClientSize.Width - flowLayoutDireita.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth;
            if (available <= 0) return;

            foreach (Control ctl in flowLayoutDireita.Controls)
            {
                if (ctl is Button)
                {
                    int target = Math.Max(ctl.MinimumSize.Width, available - ctl.Margin.Horizontal);
                    ctl.Width = target;
                }
            }
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // placeholder
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Abre o Dashboard (exemplo mínimo); adapte para validação real
            var dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();

            // Solicita abertura do caixa imediatamente após login se ainda não estiver aberto.
            if (!TelaCaixa.CaixaAberto)
            {
                using (TelaCaixa tela = new TelaCaixa())
                {
                    tela.StartPosition = FormStartPosition.CenterParent;
                    tela.ShowDialog(dashboard);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}