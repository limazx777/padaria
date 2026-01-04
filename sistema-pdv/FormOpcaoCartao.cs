using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistema_pdv // <--- VERIFIQUE ESSE NOME
{
    public partial class FormOpcaoCartao : Form
    {
        public string TipoSelecionado { get; private set; } = "";

        public FormOpcaoCartao()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(400, 200);
            this.BackColor = Color.White;
            // Borda Azul Quadrada
            this.Paint += (s, e) => ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(0, 90, 150), 4, ButtonBorderStyle.Solid, Color.FromArgb(0, 90, 150), 4, ButtonBorderStyle.Solid, Color.FromArgb(0, 90, 150), 4, ButtonBorderStyle.Solid, Color.FromArgb(0, 90, 150), 4, ButtonBorderStyle.Solid);

            Label lbl = new Label { Text = "QUAL A FUNÇÃO?", Font = new Font("Segoe UI", 16, FontStyle.Bold), ForeColor = Color.DimGray, Dock = DockStyle.Top, Height = 60, TextAlign = ContentAlignment.MiddleCenter };

            Button btnCred = new Button { Text = "CRÉDITO", BackColor = Color.FromArgb(0, 90, 150), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(30, 80), Size = new Size(160, 70) };
            btnCred.Click += (s, e) => { TipoSelecionado = "CRÉDITO"; this.DialogResult = DialogResult.OK; this.Close(); };

            Button btnDeb = new Button { Text = "DÉBITO", BackColor = Color.Teal, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(210, 80), Size = new Size(160, 70) };
            btnDeb.Click += (s, e) => { TipoSelecionado = "DÉBITO"; this.DialogResult = DialogResult.OK; this.Close(); };

            this.Controls.Add(btnDeb); this.Controls.Add(btnCred); this.Controls.Add(lbl);
        }
    }
}