using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sistema_pdv
{
    public class TelaCategorias : Form
    {
        private DataGridView dgv;
        private TextBox txtNome;
        private Button btnAdd;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnFechar;

        private List<string> categorias = new List<string>();

        public TelaCategorias()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void InitializeComponent()
        {
            this.Text = "Categorias";
            this.ClientSize = new Size(600, 420);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            dgv = new DataGridView { Dock = DockStyle.Top, Height = 260, ReadOnly = true, AllowUserToAddRows = false, SelectionMode = DataGridViewSelectionMode.FullRowSelect };
            dgv.Columns.Add("Nome", "Categoria");

            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10) };

            txtNome = new TextBox { Width = 360, Left = 10, Top = 10 };
            btnAdd = new Button { Text = "Adicionar", Left = 380, Top = 8, Width = 90 };
            btnEditar = new Button { Text = "Editar", Left = 380, Top = 48, Width = 90 };
            btnRemover = new Button { Text = "Remover", Left = 480, Top = 8, Width = 90 };
            btnFechar = new Button { Text = "Fechar", Left = 480, Top = 48, Width = 90 };

            btnAdd.Click += BtnAdd_Click;
            btnEditar.Click += BtnEditar_Click;
            btnRemover.Click += BtnRemover_Click;
            btnFechar.Click += (s, e) => this.Close();

            panel.Controls.Add(txtNome);
            panel.Controls.Add(btnAdd);
            panel.Controls.Add(btnEditar);
            panel.Controls.Add(btnRemover);
            panel.Controls.Add(btnFechar);
            panel.Top = dgv.Bottom + 10;

            this.Controls.Add(panel);
            this.Controls.Add(dgv);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Digite o nome da categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (categorias.Contains(nome, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Categoria já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            categorias.Add(nome);
            AtualizarGrid();
            txtNome.Clear();
            txtNome.Focus();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma categoria para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idx = dgv.SelectedRows[0].Index;
            var atual = categorias[idx];

            string novo = Microsoft.VisualBasic.Interaction.InputBox("Editar categoria:", "Editar", atual);
            if (string.IsNullOrWhiteSpace(novo)) return;

            categorias[idx] = novo.Trim();
            AtualizarGrid();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma categoria para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var idx = dgv.SelectedRows[0].Index;
            var nome = categorias[idx];

            var dr = MessageBox.Show($"Remover categoria '{nome}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;

            categorias.RemoveAt(idx);
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            dgv.Rows.Clear();
            foreach (var c in categorias.OrderBy(x => x))
            {
                dgv.Rows.Add(c);
            }
        }
    }
}