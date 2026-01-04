namespace sistema_pdv
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        // Estrutura Principal
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPrincipal;

        // Coluna do Meio (Dividida em 2)
        private System.Windows.Forms.TableLayoutPanel tableLayoutMeio;

        // Coluna da Direita (Lista) - agora é TableLayoutPanel para layout responsivo vertical
        private System.Windows.Forms.TableLayoutPanel flowLayoutDireita;

        // Botões
        private System.Windows.Forms.Button btnVendas;      // Gigante Esquerda
        private System.Windows.Forms.Button btnProdutos;    // Meio (agora ocupa todo)
        private System.Windows.Forms.Button btnCaixa;       // Lista Direita
        private System.Windows.Forms.Button btnCategorias;  // Lista Direita
        private System.Windows.Forms.Button btnRelatorios;  // Lista Direita
        private System.Windows.Forms.Button btnUsuarios;    // Lista Direita
        private System.Windows.Forms.Button btnSair;        // Lista Direita

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnVendas = new System.Windows.Forms.Button();
            this.tableLayoutMeio = new System.Windows.Forms.TableLayoutPanel();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.flowLayoutDireita = new System.Windows.Forms.TableLayoutPanel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelTopo.SuspendLayout();
            this.tableLayoutPrincipal.SuspendLayout();
            this.tableLayoutMeio.SuspendLayout();
            this.flowLayoutDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(1024, 50);
            this.panelTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(177, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PDV CONNECT 2.0";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // tableLayoutPrincipal
            // 
            this.tableLayoutPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPrincipal.ColumnCount = 3;
            // proporções ajustadas (esquerda grande, centro médio, direita estreita)
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPrincipal.Controls.Add(this.btnVendas, 0, 0);
            this.tableLayoutPrincipal.Controls.Add(this.tableLayoutMeio, 1, 0);
            this.tableLayoutPrincipal.Controls.Add(this.flowLayoutDireita, 2, 0);
            this.tableLayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPrincipal.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPrincipal.Name = "tableLayoutPrincipal";
            this.tableLayoutPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPrincipal.RowCount = 1;
            this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPrincipal.Size = new System.Drawing.Size(1024, 718);
            this.tableLayoutPrincipal.TabIndex = 1;
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnVendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.TabIndex = 0;
            this.btnVendas.Text = "🛒\r\n\r\nBALCÃO / VENDAS";
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // tableLayoutMeio
            // 
            this.tableLayoutMeio.ColumnCount = 1;
            this.tableLayoutMeio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMeio.Controls.Add(this.btnProdutos, 0, 0);
            this.tableLayoutMeio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMeio.Location = new System.Drawing.Point(569, 13);
            this.tableLayoutMeio.Name = "tableLayoutMeio";
            this.tableLayoutMeio.RowCount = 1;
            this.tableLayoutMeio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMeio.Size = new System.Drawing.Size(295, 692);
            this.tableLayoutMeio.TabIndex = 1;
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "📦\r\n\r\nPRODUTOS";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // flowLayoutDireita (agora TableLayoutPanel)
            // 
            this.flowLayoutDireita.ColumnCount = 1;
            this.flowLayoutDireita.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowLayoutDireita.Controls.Add(this.btnCaixa, 0, 0);
            this.flowLayoutDireita.Controls.Add(this.btnCategorias, 0, 1);
            this.flowLayoutDireita.Controls.Add(this.btnRelatorios, 0, 2);
            this.flowLayoutDireita.Controls.Add(this.btnUsuarios, 0, 3);
            this.flowLayoutDireita.Controls.Add(this.btnSair, 0, 4);
            this.flowLayoutDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutDireita.Location = new System.Drawing.Point(870, 13);
            this.flowLayoutDireita.Name = "flowLayoutDireita";
            this.flowLayoutDireita.RowCount = 5;
            // cada botão ocupa percentualmente a altura disponível (responsivo)
            this.flowLayoutDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flowLayoutDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flowLayoutDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flowLayoutDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flowLayoutDireita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flowLayoutDireita.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutDireita.Size = new System.Drawing.Size(141, 692);
            this.flowLayoutDireita.TabIndex = 2;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(210)))));
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Margin = new System.Windows.Forms.Padding(6);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.TabIndex = 0;
            this.btnCaixa.Text = "💰 CAIXA / MOVIMENTO";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(6);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.TabIndex = 1;
            this.btnCategorias.Text = "🏷️ CATEGORIAS";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = false;
            // Adiciona handler diretamente no Designer para garantir ligação
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(6);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.TabIndex = 2;
            this.btnRelatorios.Text = "📈 RELATÓRIOS";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            // Adiciona handler diretamente no Designer para garantir ligação
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "🔒 USUÁRIOS";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // Adiciona handler diretamente no Designer para garantir ligação
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Margin = new System.Windows.Forms.Padding(6);
            this.btnSair.Name = "btnSair";
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "🚪 SAIR DO SISTEMA";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.tableLayoutPrincipal);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.tableLayoutPrincipal.ResumeLayout(false);
            this.tableLayoutMeio.ResumeLayout(false);
            this.flowLayoutDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}