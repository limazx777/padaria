namespace sistema_pdv
{
    partial class TelaCaixa
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Label lblStatusCaixa;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTopo = new System.Windows.Forms.Panel();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblStatusCaixa = new System.Windows.Forms.Label();
            this.panelTopo.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTopo.Controls.Add(this.btnFecharTela);
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(600, 50);
            this.panelTopo.TabIndex = 0;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFecharTela.FlatAppearance.BorderSize = 0;
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnFecharTela.ForeColor = System.Drawing.Color.White;
            this.btnFecharTela.Location = new System.Drawing.Point(550, 0);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(50, 50);
            this.btnFecharTela.TabIndex = 1;
            this.btnFecharTela.Text = "X";
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONTROLE DE CAIXA";
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConteudo.Controls.Add(this.panelCard);
            this.panelConteudo.Controls.Add(this.lblStatusCaixa);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 50);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(600, 450);
            this.panelConteudo.TabIndex = 1;
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.lblInfo);
            this.panelCard.Controls.Add(this.btnAcao);
            this.panelCard.Controls.Add(this.txtValor);
            this.panelCard.Controls.Add(this.lblValor);
            this.panelCard.Location = new System.Drawing.Point(100, 80);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(400, 300);
            this.panelCard.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(34, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(330, 40);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Informe o Suprimento Inicial (Fundo de Troco) para iniciar as vendas.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcao
            // 
            this.btnAcao.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAcao.ForeColor = System.Drawing.Color.White;
            this.btnAcao.Location = new System.Drawing.Point(34, 180);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(330, 60);
            this.btnAcao.TabIndex = 2;
            this.btnAcao.Text = "ABRIR CAIXA";
            this.btnAcao.UseVisualStyleBackColor = false;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtValor.Location = new System.Drawing.Point(34, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(330, 43);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValor.Location = new System.Drawing.Point(30, 80);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(153, 21);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Informe o valor (R$):";
            // 
            // lblStatusCaixa
            // 
            this.lblStatusCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatusCaixa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblStatusCaixa.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatusCaixa.Location = new System.Drawing.Point(0, 0);
            this.lblStatusCaixa.Name = "lblStatusCaixa";
            this.lblStatusCaixa.Size = new System.Drawing.Size(600, 60);
            this.lblStatusCaixa.TabIndex = 0;
            this.lblStatusCaixa.Text = "Verificando Status...";
            this.lblStatusCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaCaixa
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.panelConteudo.ResumeLayout(false);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}