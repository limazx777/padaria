namespace sistema_pdv
{
    partial class TelaProdutos
    {
        private System.ComponentModel.IContainer components = null;

        // Estrutura
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelEsquerdo; // Área de Cadastro
        private System.Windows.Forms.Panel panelDireito;  // Área de Lista (Grid)

        // Campos de Cadastro
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.NumericUpDown numEstoque;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;

        // Foto
        private System.Windows.Forms.PictureBox pbFotoProduto;
        private System.Windows.Forms.Button btnCarregarFoto;

        // Botões de Ação
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;

        // Grid (Tabela)
        private System.Windows.Forms.DataGridView gridProdutos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelDireito = new System.Windows.Forms.Panel();

            // Campos
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.numEstoque = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();

            // Foto e Botões
            this.pbFotoProduto = new System.Windows.Forms.PictureBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gridProdutos = new System.Windows.Forms.DataGridView();

            this.panelTopo.SuspendLayout();
            this.panelEsquerdo.SuspendLayout();
            this.panelDireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();

            // --- TOPO ---
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(52, 152, 219); // Azul do botão Produtos
            this.panelTopo.Controls.Add(this.btnFechar);
            this.panelTopo.Controls.Add(this.lblTitulo);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Height = 60;

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Text = "📦 CADASTRO DE PRODUTOS";

            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Size = new System.Drawing.Size(60, 60);
            this.btnFechar.Text = "X";
            // O evento Click será ligado no código .cs

            // --- PAINEL ESQUERDO (CADASTRO) ---
            this.panelEsquerdo.BackColor = System.Drawing.Color.White;
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Width = 400;
            this.panelEsquerdo.Padding = new System.Windows.Forms.Padding(20);

            // Adicionando controles ao painel esquerdo
            this.panelEsquerdo.Controls.Add(this.btnLimpar);
            this.panelEsquerdo.Controls.Add(this.btnSalvar);
            this.panelEsquerdo.Controls.Add(this.btnCarregarFoto);
            this.panelEsquerdo.Controls.Add(this.pbFotoProduto);
            this.panelEsquerdo.Controls.Add(this.numEstoque);
            this.panelEsquerdo.Controls.Add(this.lblEstoque);
            this.panelEsquerdo.Controls.Add(this.txtPreco);
            this.panelEsquerdo.Controls.Add(this.lblPreco);
            this.panelEsquerdo.Controls.Add(this.cmbCategoria);
            this.panelEsquerdo.Controls.Add(this.lblCategoria);
            this.panelEsquerdo.Controls.Add(this.txtNome);
            this.panelEsquerdo.Controls.Add(this.lblNome);

            // Labels e Inputs
            this.lblNome.Text = "Nome do Produto";
            this.lblNome.Location = new System.Drawing.Point(20, 30);
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.txtNome.Location = new System.Drawing.Point(20, 55);
            this.txtNome.Size = new System.Drawing.Size(350, 30);
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Location = new System.Drawing.Point(20, 100);
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.cmbCategoria.Location = new System.Drawing.Point(20, 125);
            this.cmbCategoria.Size = new System.Drawing.Size(350, 30);
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] { "Geral", "Bebidas", "Alimentos", "Limpeza", "Outros" });

            this.lblPreco.Text = "Preço de Venda (R$)";
            this.lblPreco.Location = new System.Drawing.Point(20, 170);
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.txtPreco.Location = new System.Drawing.Point(20, 195);
            this.txtPreco.Size = new System.Drawing.Size(160, 30);
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPreco.Text = "0,00";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.lblEstoque.Text = "Estoque Inicial";
            this.lblEstoque.Location = new System.Drawing.Point(210, 170);
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.numEstoque.Location = new System.Drawing.Point(210, 195);
            this.numEstoque.Size = new System.Drawing.Size(160, 30);
            this.numEstoque.Font = new System.Drawing.Font("Segoe UI", 12F);

            // Foto
            this.pbFotoProduto.Location = new System.Drawing.Point(20, 250);
            this.pbFotoProduto.Size = new System.Drawing.Size(150, 150);
            this.pbFotoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoProduto.BackColor = System.Drawing.Color.WhiteSmoke;

            this.btnCarregarFoto.Text = "Selecionar Foto";
            this.btnCarregarFoto.Location = new System.Drawing.Point(190, 300);
            this.btnCarregarFoto.Size = new System.Drawing.Size(180, 40);
            this.btnCarregarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarFoto.BackColor = System.Drawing.Color.LightGray;

            // Botões Salvar/Limpar
            this.btnSalvar.Text = "SALVAR PRODUTO";
            this.btnSalvar.Location = new System.Drawing.Point(20, 450);
            this.btnSalvar.Size = new System.Drawing.Size(350, 50);
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // Verde
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;

            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.Location = new System.Drawing.Point(20, 510);
            this.btnLimpar.Size = new System.Drawing.Size(350, 30);
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.Gray;

            // --- PAINEL DIREITO (GRID) ---
            this.panelDireito.Controls.Add(this.gridProdutos);
            this.panelDireito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDireito.Padding = new System.Windows.Forms.Padding(20);

            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutos.ColumnHeadersHeight = 40;

            // Estilo do Grid
            cellStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            cellStyle.ForeColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridProdutos.ColumnHeadersDefaultCellStyle = cellStyle;
            this.gridProdutos.EnableHeadersVisualStyles = false;

            // Formulário Principal
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelDireito);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.panelEsquerdo.ResumeLayout(false);
            this.panelEsquerdo.PerformLayout();
            this.panelDireito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}