namespace sistema_pdv // <--- VERIFIQUE ESSE NOME
{
    partial class TelaVendas
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.Panel panelTopo;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblTituloCaixa;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Panel panelEsquerdo;
        public System.Windows.Forms.FlowLayoutPanel flowListaProdutos;
        public System.Windows.Forms.Panel panelBuscaContainer;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Label lblPlaceholder;
        public System.Windows.Forms.Panel panelHeaderGrid;
        public System.Windows.Forms.Label lblH_Prod;
        public System.Windows.Forms.Label lblH_Qtd;
        public System.Windows.Forms.Label lblH_Unit;
        public System.Windows.Forms.Label lblH_Total;
        public System.Windows.Forms.Panel panelDireito;
        public System.Windows.Forms.Label lblHeaderTotalCompra;
        public System.Windows.Forms.Panel panelQuadroTotais;
        public System.Windows.Forms.Panel panelBoxTotal;
        public System.Windows.Forms.Label lblTitTotalCompra;
        public System.Windows.Forms.Label lblValorTotal;
        public System.Windows.Forms.Panel panelBoxPago;
        public System.Windows.Forms.Label lblTitValorPago;
        public System.Windows.Forms.Label lblValorPago;
        public System.Windows.Forms.Panel panelBoxPagar;
        public System.Windows.Forms.Label lblTitAPagar;
        public System.Windows.Forms.Label lblValorPagar;
        public System.Windows.Forms.TableLayoutPanel tableBotoes;
        public System.Windows.Forms.Button btnDinheiro;
        public System.Windows.Forms.Button btnCartao;
        public System.Windows.Forms.Button btnPix;
        public System.Windows.Forms.Button btnCancelarVenda;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTopo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTituloCaixa = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.flowListaProdutos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBuscaContainer = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.panelHeaderGrid = new System.Windows.Forms.Panel();
            this.lblH_Prod = new System.Windows.Forms.Label();
            this.lblH_Qtd = new System.Windows.Forms.Label();
            this.lblH_Unit = new System.Windows.Forms.Label();
            this.lblH_Total = new System.Windows.Forms.Label();
            this.panelDireito = new System.Windows.Forms.Panel();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.tableBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.btnCartao = new System.Windows.Forms.Button();
            this.btnPix = new System.Windows.Forms.Button();
            this.panelQuadroTotais = new System.Windows.Forms.Panel();
            this.panelBoxPagar = new System.Windows.Forms.Panel();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblTitAPagar = new System.Windows.Forms.Label();
            this.panelBoxPago = new System.Windows.Forms.Panel();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblTitValorPago = new System.Windows.Forms.Label();
            this.panelBoxTotal = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblTitTotalCompra = new System.Windows.Forms.Label();
            this.lblHeaderTotalCompra = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelEsquerdo.SuspendLayout();
            this.panelBuscaContainer.SuspendLayout();
            this.panelHeaderGrid.SuspendLayout();
            this.panelDireito.SuspendLayout();
            this.tableBotoes.SuspendLayout();
            this.panelQuadroTotais.SuspendLayout();
            this.panelBoxPagar.SuspendLayout();
            this.panelBoxPago.SuspendLayout();
            this.panelBoxTotal.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // TOPO
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(0, 70, 110);
            this.panelTopo.Controls.Add(this.btnSair);
            this.panelTopo.Controls.Add(this.lblTituloCaixa);
            this.panelTopo.Controls.Add(this.pbLogo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Height = 110;

            this.pbLogo.Location = new System.Drawing.Point(30, 15);
            this.pbLogo.Size = new System.Drawing.Size(250, 80);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;

            this.lblTituloCaixa.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTituloCaixa.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTituloCaixa.ForeColor = System.Drawing.Color.White;
            this.lblTituloCaixa.Text = "CAIXA 1 - LIVRE";
            this.lblTituloCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTituloCaixa.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.lblTituloCaixa.AutoSize = false;
            this.lblTituloCaixa.Width = 1000;

            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Text = "X";
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(this.ClientSize.Width - 80, 0);
            this.btnSair.Size = new System.Drawing.Size(80, 80);

            // DIREITA
            this.panelDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireito.Width = 600;
            this.panelDireito.Padding = new System.Windows.Forms.Padding(20);
            this.panelDireito.Controls.Add(this.btnCancelarVenda);
            this.panelDireito.Controls.Add(this.tableBotoes);
            this.panelDireito.Controls.Add(this.panelQuadroTotais);
            this.panelDireito.Controls.Add(this.lblHeaderTotalCompra);

            this.lblHeaderTotalCompra.Text = "TOTAL DA COMPRA";
            this.lblHeaderTotalCompra.BackColor = System.Drawing.Color.FromArgb(10, 30, 45);
            this.lblHeaderTotalCompra.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTotalCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderTotalCompra.Height = 60;
            this.lblHeaderTotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeaderTotalCompra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);

            // QUADRO TOTAIS
            this.panelQuadroTotais.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelQuadroTotais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuadroTotais.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuadroTotais.Height = 650;
            this.panelQuadroTotais.Padding = new System.Windows.Forms.Padding(15);
            this.panelQuadroTotais.Controls.Add(this.panelBoxPagar);
            this.panelQuadroTotais.Controls.Add(this.lblTitAPagar);
            this.panelQuadroTotais.Controls.Add(this.panelBoxPago);
            this.panelQuadroTotais.Controls.Add(this.lblTitValorPago);
            this.panelQuadroTotais.Controls.Add(this.panelBoxTotal);
            this.panelQuadroTotais.Controls.Add(this.lblTitTotalCompra);

            // Boxes Totais
            this.lblTitTotalCompra.Dock = System.Windows.Forms.DockStyle.Top; this.lblTitTotalCompra.Text = "TOTAL DA COMPRA R$"; this.lblTitTotalCompra.Height = 60; this.lblTitTotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTitTotalCompra.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.panelBoxTotal.Dock = System.Windows.Forms.DockStyle.Top; this.panelBoxTotal.Height = 120; this.panelBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.panelBoxTotal.Controls.Add(this.lblValorTotal); this.panelBoxTotal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.lblValorTotal.Dock = System.Windows.Forms.DockStyle.Fill; this.lblValorTotal.Text = "R$ 0,00"; this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Bold);

            this.lblTitValorPago.Dock = System.Windows.Forms.DockStyle.Top; this.lblTitValorPago.Text = "VALOR PAGO R$"; this.lblTitValorPago.Height = 70; this.lblTitValorPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTitValorPago.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.panelBoxPago.Dock = System.Windows.Forms.DockStyle.Top; this.panelBoxPago.Height = 120; this.panelBoxPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.panelBoxPago.Controls.Add(this.lblValorPago);
            this.lblValorPago.Dock = System.Windows.Forms.DockStyle.Fill; this.lblValorPago.Text = "R$ 0,00"; this.lblValorPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblValorPago.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Bold);

            this.lblTitAPagar.Dock = System.Windows.Forms.DockStyle.Top; this.lblTitAPagar.Text = "VALOR A PAGAR R$"; this.lblTitAPagar.Height = 70; this.lblTitAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblTitAPagar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.panelBoxPagar.Dock = System.Windows.Forms.DockStyle.Top; this.panelBoxPagar.Height = 120; this.panelBoxPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.panelBoxPagar.Controls.Add(this.lblValorPagar);
            this.lblValorPagar.Dock = System.Windows.Forms.DockStyle.Fill; this.lblValorPagar.Text = "R$ 0,00"; this.lblValorPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; this.lblValorPagar.Font = new System.Drawing.Font("Segoe UI", 55F, System.Drawing.FontStyle.Bold);

            // BOTÕES
            this.tableBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableBotoes.Height = 140;
            this.tableBotoes.ColumnCount = 3;
            this.tableBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableBotoes.Controls.Add(this.btnDinheiro, 0, 0);
            this.tableBotoes.Controls.Add(this.btnCartao, 1, 0);
            this.tableBotoes.Controls.Add(this.btnPix, 2, 0);

            this.btnDinheiro.Dock = System.Windows.Forms.DockStyle.Fill; this.btnDinheiro.BackColor = System.Drawing.Color.FromArgb(0, 90, 150); this.btnDinheiro.ForeColor = System.Drawing.Color.White; this.btnDinheiro.Text = "DINHEIRO (F1)"; this.btnDinheiro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.btnDinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartao.Dock = System.Windows.Forms.DockStyle.Fill; this.btnCartao.BackColor = System.Drawing.Color.FromArgb(0, 90, 150); this.btnCartao.ForeColor = System.Drawing.Color.White; this.btnCartao.Text = "CARTÃO (F2)"; this.btnCartao.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.btnCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPix.Dock = System.Windows.Forms.DockStyle.Fill; this.btnPix.BackColor = System.Drawing.Color.FromArgb(0, 90, 150); this.btnPix.ForeColor = System.Drawing.Color.White; this.btnPix.Text = "PIX (F3)"; this.btnPix.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.btnPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // BOTÃO CANCELAR
            this.btnCancelarVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelarVenda.Height = 70;
            this.btnCancelarVenda.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnCancelarVenda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenda.Text = "CANCELAR VENDA (SENHA)";
            this.btnCancelarVenda.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Visible = false;

            // ESQUERDA
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEsquerdo.Padding = new System.Windows.Forms.Padding(20);
            this.panelEsquerdo.Controls.Add(this.flowListaProdutos);
            this.panelEsquerdo.Controls.Add(this.panelBuscaContainer);
            this.panelEsquerdo.Controls.Add(this.lblPlaceholder);
            this.panelEsquerdo.Controls.Add(this.panelHeaderGrid);

            this.panelHeaderGrid.Dock = System.Windows.Forms.DockStyle.Top; this.panelHeaderGrid.Height = 60; this.panelHeaderGrid.BackColor = System.Drawing.Color.Black;
            this.panelHeaderGrid.Controls.Add(this.lblH_Total); this.panelHeaderGrid.Controls.Add(this.lblH_Unit); this.panelHeaderGrid.Controls.Add(this.lblH_Qtd); this.panelHeaderGrid.Controls.Add(this.lblH_Prod);

            this.lblH_Prod.AutoSize = true; this.lblH_Prod.ForeColor = System.Drawing.Color.White; this.lblH_Prod.Text = "PRODUTO"; this.lblH_Prod.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblH_Prod.Location = new System.Drawing.Point(20, 15);
            this.lblH_Qtd.AutoSize = true; this.lblH_Qtd.ForeColor = System.Drawing.Color.White; this.lblH_Qtd.Text = "QTD"; this.lblH_Qtd.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblH_Qtd.Location = new System.Drawing.Point(600, 15);
            this.lblH_Unit.AutoSize = true; this.lblH_Unit.ForeColor = System.Drawing.Color.White; this.lblH_Unit.Text = "UNIT"; this.lblH_Unit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblH_Unit.Location = new System.Drawing.Point(850, 15);
            this.lblH_Total.AutoSize = true; this.lblH_Total.ForeColor = System.Drawing.Color.White; this.lblH_Total.Text = "TOTAL"; this.lblH_Total.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold); this.lblH_Total.Location = new System.Drawing.Point(1100, 15);

            this.lblPlaceholder.Dock = System.Windows.Forms.DockStyle.Top; this.lblPlaceholder.Height = 45; this.lblPlaceholder.Text = "Código ou Nome do Produto (Enter)"; this.lblPlaceholder.ForeColor = System.Drawing.Color.DimGray; this.lblPlaceholder.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panelBuscaContainer.Dock = System.Windows.Forms.DockStyle.Top; this.panelBuscaContainer.Height = 90; this.panelBuscaContainer.BackColor = System.Drawing.Color.FromArgb(230, 230, 230); this.panelBuscaContainer.Controls.Add(this.txtBuscar); this.panelBuscaContainer.Padding = new System.Windows.Forms.Padding(15);
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill; this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None; this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(230, 230, 230); this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 36F);

            this.flowListaProdutos.Dock = System.Windows.Forms.DockStyle.Fill; this.flowListaProdutos.AutoScroll = true;

            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelDireito);
            this.Controls.Add(this.panelTopo);

            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelEsquerdo.ResumeLayout(false);
            this.panelBuscaContainer.ResumeLayout(false);
            this.panelBuscaContainer.PerformLayout();
            this.panelHeaderGrid.ResumeLayout(false);
            this.panelHeaderGrid.PerformLayout();
            this.panelDireito.ResumeLayout(false);
            this.tableBotoes.ResumeLayout(false);
            this.panelQuadroTotais.ResumeLayout(false);
            this.panelBoxPagar.ResumeLayout(false);
            this.panelBoxPago.ResumeLayout(false);
            this.panelBoxTotal.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}