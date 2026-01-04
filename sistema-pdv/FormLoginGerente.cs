using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistema_pdv // <--- VERIFIQUE ESSE NOME
{
    public partial class FormLoginGerente : Form
    {
        private TextBox txtSenha;
        public FormLoginGerente()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(400, 250);
            this.BackColor = Color.White;
            // Borda Vermelha Quadrada
            this.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, 3, ButtonBorderStyle.Solid, Color.Red, 3, ButtonBorderStyle.Solid, Color.Red, 3, ButtonBorderStyle.Solid, Color.Red, 3, ButtonBorderStyle.Solid);

            Label lbl = new Label { Text = "SENHA GERENTE", Font = new Font("Segoe UI", 14, FontStyle.Bold), ForeColor = Color.Red, Dock = DockStyle.Top, Height = 60, TextAlign = ContentAlignment.MiddleCenter };

            txtSenha = new TextBox { Font = new Font("Segoe UI", 16), PasswordChar = '•', Location = new Point(50, 80), Size = new Size(300, 40), TextAlign = HorizontalAlignment.Center };
            txtSenha.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) Validar(); };

            Button btnConf = new Button { Text = "CONFIRMAR", BackColor = Color.Red, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(50, 150), Size = new Size(140, 50) };
            btnConf.Click += (s, e) => Validar();

            Button btnCanc = new Button { Text = "VOLTAR", BackColor = Color.Gray, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(210, 150), Size = new Size(140, 50) };
            btnCanc.Click += (s, e) => this.Close();

            this.Controls.Add(btnCanc); this.Controls.Add(btnConf); this.Controls.Add(txtSenha); this.Controls.Add(lbl);
        }

        private void Validar()
        {
            if (txtSenha.Text == "admin123") { this.DialogResult = DialogResult.OK; this.Close(); }
            else { MessageBox.Show("Senha Incorreta!"); txtSenha.Clear(); txtSenha.Focus(); }
        }
    }
}