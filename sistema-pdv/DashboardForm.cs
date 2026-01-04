using System;
using System.Windows.Forms;

namespace sistema_pdv
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            TelaVendas vendas = new TelaVendas();
            vendas.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos produtos = new TelaProdutos();
            produtos.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            // Em vez de mostrar mensagem, agora abre a tela real
            TelaCaixa tela = new TelaCaixa();
            tela.ShowDialog(); // Abre como pop-up (não deixa clicar atrás)
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutDireita_SizeChanged(object sender, EventArgs e)
        {
            // largura disponível dentro do painel (desconta padding e barra de rolagem vertical se existir)
            int available = flowLayoutDireita.ClientSize.Width - flowLayoutDireita.Padding.Horizontal - SystemInformation.VerticalScrollBarWidth;
            if (available <= 0) return;

            foreach (Control ctl in flowLayoutDireita.Controls)
            {
                if (ctl is Button)
                {
                    // largura mínima respeitada pelo MinimumSize, caso contrário usa disponível
                    int target = Math.Max(ctl.MinimumSize.Width, available - ctl.Margin.Horizontal);
                    ctl.Width = target;
                }
            }
        }
    }
}