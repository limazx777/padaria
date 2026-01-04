using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistema_pdv
{
    public partial class TelaProdutos : Form
    {
        public TelaProdutos()
        {
            InitializeComponent();
            ConfigurarEventos();
            ConfigurarGrid();
        }

        private void ConfigurarEventos()
        {
            btnFechar.Click += (s, e) => this.Close();
            btnCarregarFoto.Click += BtnCarregarFoto_Click;
            btnSalvar.Click += BtnSalvar_Click;
            btnLimpar.Click += (s, e) => LimparCampos();
        }

        private void ConfigurarGrid()
        {
            // Criando as colunas da tabela manualmente (simulando BD)
            gridProdutos.Columns.Add("Nome", "Produto");
            gridProdutos.Columns.Add("Categoria", "Categoria");
            gridProdutos.Columns.Add("Preco", "Preço");
            gridProdutos.Columns.Add("Estoque", "Qtd");
        }

        private void BtnCarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens|*.jpg;*.png;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbFotoProduto.ImageLocation = dialog.FileName;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Validação Simples
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, digite o nome do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Adicionar na Tabela (Futuramente aqui vai o INSERT no Banco de Dados)
            gridProdutos.Rows.Add(
                txtNome.Text,
                cmbCategoria.Text,
                "R$ " + txtPreco.Text,
                numEstoque.Value
            );

            MessageBox.Show("Produto salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPreco.Text = "0,00";
            numEstoque.Value = 0;
            cmbCategoria.SelectedIndex = -1;
            pbFotoProduto.Image = null;
            txtNome.Focus();
        }
    }
}