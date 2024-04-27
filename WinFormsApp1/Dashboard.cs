using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Drawing2D;

namespace WinFormsApp1
{

    public partial class Dashboard : Form
    {
        private Principal principal;
        public Dashboard(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private void pictureBox_aviso_dashboard_Click_1(object sender, EventArgs e)
        {
            //faz úma mensagem de ajuda
            MessageBox.Show("Esta é a página inicial, apenas mostra o essencial. Para mais detalhes use os botões ao lado para ver as outras janelas.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            foreach (Control objeto in Controls)
            {//vai arredondar as bordas de todos os panels do form 
                if (objeto is Panel pln)
                {
                    Principal.Funcs.ArredondarBordas(pln, 50);
                }
            }
            //vai escrever os valores que sao precisos da base de dados
            label_num_clientes.Text = Convert.ToString(Principal.Funcs.NumeroClientes());
            label_num_produtos.Text = Convert.ToString(Principal.Funcs.NumeroProdutos());
            label_num_encomendas.Text = Convert.ToString(Principal.Funcs.NumeroEncomendas());


            //falta fazer um grafico



        }

        private void panel_Click(object sender, EventArgs e)
        {
            //dependendo do panel vai mandar o sender para a função para mudar de janela
            principal.button_Click(sender, EventArgs.Empty);
        }
    }
}
