using System;
using System.Drawing;
using System.Windows.Forms;

namespace sistema_pdv
{
    public partial class TelaCaixa : Form
    {
        private static bool caixaAberto = false;

        public TelaCaixa()
        {
            InitializeComponent();

            // AQUI ESTÁ A CORREÇÃO:
            // O comando de fechar a tela agora está no lugar certo (na lógica, não no designer)
            btnFecharTela.Click += (s, e) => this.Close();

            AtualizarVisual();
        }

        private void AtualizarVisual()
        {
            if (caixaAberto == false)
            {
                // MODO: ABRIR CAIXA
                lblStatusCaixa.Text = "STATUS: CAIXA FECHADO";
                lblStatusCaixa.ForeColor = Color.Red;

                lblInfo.Text = "Informe o Suprimento Inicial (Fundo de Troco):";
                btnAcao.Text = "ABRIR CAIXA AGORA";
                btnAcao.BackColor = Color.FromArgb(46, 204, 113); // Verde
                txtValor.Enabled = true; // Pode digitar
                txtValor.Text = "0,00";
            }
            else
            {
                // MODO: FECHAR CAIXA
                lblStatusCaixa.Text = "STATUS: CAIXA ABERTO";
                lblStatusCaixa.ForeColor = Color.Green;

                lblInfo.Text = "Confira o dinheiro e informe o Saldo Final:";
                btnAcao.Text = "FECHAR CAIXA (Z)";
                btnAcao.BackColor = Color.FromArgb(231, 76, 60); // Vermelho
                txtValor.Enabled = true;
                txtValor.Text = "0,00";
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text)) return;

            if (caixaAberto == false)
            {
                // CÓDIGO DE ABERTURA
                MessageBox.Show($"Caixa ABERTO com sucesso!\nSaldo Inicial: R$ {txtValor.Text}", "Sucesso");
                caixaAberto = true;
                this.Close();
            }
            else
            {
                // CÓDIGO DE FECHAMENTO
                var confirmacao = MessageBox.Show("Tem certeza que deseja fechar o caixa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacao == DialogResult.Yes)
                {
                    MessageBox.Show($"Caixa FECHADO!\nValor Final em Caixa: R$ {txtValor.Text}", "Fechamento");
                    caixaAberto = false;
                    this.Close();
                }
            }
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {

        }

        // Adicione esta propriedade à sua classe TelaCaixa
        public static bool CaixaAberto
        {
            get { return caixaAberto; }
        }
    }
}