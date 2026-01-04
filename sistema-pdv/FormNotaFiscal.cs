using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistema_pdv
{
    // Form interno para exibir a Nota Fiscal (NFC-e) dentro do sistema
    public class FormNotaFiscal : Form
    {
        public FormNotaFiscal(string textoCupom)
        {
            this.Text = "Nota Fiscal";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(420, 640);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            var pnl = new Panel { Dock = DockStyle.Fill, Padding = new Padding(8) };

            var txt = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 10F),
                BackColor = Color.White,
                Text = textoCupom
            };

            var pnlButtons = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 44,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(6)
            };

            var btnFechar = new Button
            {
                Text = "Fechar",
                Width = 100,
                Height = 28,
                DialogResult = DialogResult.OK
            };
            btnFechar.Click += (s, e) => this.Close();

            // Opcional: botão Imprimir (simples) — chama diálogo de impressão do Windows
            var btnImprimir = new Button
            {
                Text = "Imprimir",
                Width = 100,
                Height = 28
            };
            btnImprimir.Click += (s, e) =>
            {
                using (var pd = new PrintDialog())
                {
                    var rb = new System.Drawing.Printing.PrintDocument();
                    rb.PrintPage += (sender, ev) =>
                    {
                        ev.Graphics.DrawString(txt.Text, new Font("Consolas", 10F), Brushes.Black, new RectangleF(10, 10, ev.PageBounds.Width - 20, ev.PageBounds.Height - 20));
                    };
                    pd.Document = rb;
                    if (pd.ShowDialog(this) == DialogResult.OK)
                    {
                        try { rb.Print(); }
                        catch (Exception ex) { MessageBox.Show("Erro ao imprimir: " + ex.Message); }
                    }
                }
            };

            pnlButtons.Controls.Add(btnFechar);
            pnlButtons.Controls.Add(btnImprimir);

            pnl.Controls.Add(txt);
            this.Controls.Add(pnl);
            this.Controls.Add(pnlButtons);
        }
    }
}