using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        private readonly Principal principal;

        public Dashboard(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void pictureBox_aviso_dashboard_Click_1(object sender, EventArgs e)
        {
            //mensagem a dizer oq e 
            MessageBox.Show("Esta é a página inicial, apenas mostra o essencial. Para mais detalhes use os botões ao lado para ver as outras janelas.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //vai arredondar os panels e preencher
            ArredondarBordasPanels();
            AtualizarValoresDashboard();
        }

        private void ArredondarBordasPanels()
        {
            //função que vai arrendondar os panels
            foreach (Control objeto in Controls)
            {
                if (objeto is Panel pln)
                {
                    Principal.Funcs.ArredondarBordas(pln, 50);
                }
            }
        }

        private void AtualizarValoresDashboard()
        {
            //vai escrever os valores dos panels
            label_num_clientes.Text = Convert.ToString(Principal.Funcs.NumeroClientes());
            label_num_produtos.Text = Convert.ToString(Principal.Funcs.NumeroProdutos());
            label_num_encomendas.Text = Convert.ToString(Principal.Funcs.NumeroEncomendas());
        }

        private void panel_Click(object sender, EventArgs e)
        {
            //função que vai mudar a cor do que esta selecionado
            principal.button_Click(sender, EventArgs.Empty);
        }
    }
}
