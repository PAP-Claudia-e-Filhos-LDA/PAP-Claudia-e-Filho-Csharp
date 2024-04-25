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
        public static class Funcs
        {
            //classe para as funções

            //variavel para a conexão
            private static SQLiteConnection? conexao;

            public static SQLiteConnection Conectar()
            { //liga a base de dados
                //depois mudar para caminho absuluto
                //"D:\Tranferencias\Trabalho V0.02\Trabalho\bd\Rissois.db"
                string caminho = "Data Source=\"D:\\Tranferencias\\Trabalho V0.02\\Trabalho\\bd\\Rissois.db\";Version=3;";
                conexao = new SQLiteConnection(caminho);
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                return conexao;
            }
            public static void Desconectar()
            {//desliga a base de dados
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

            public static long NumeroClientes()
            {//calcula no numero de clientes
                SQLiteConnection conexao = Conectar();
                long num = 0;
                try
                {
                    string query = "SELECT COUNT(*) FROM Clientes;";
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                num = reader.GetInt64(0);
                            }
                        }
                    }
                }
                finally
                {
                    Desconectar();
                }
                return num;
            }
            public static long NumeroProdutos()
            {//calcula no numero de Produtos
                SQLiteConnection conexao = Conectar();
                long num = 0;
                try
                {
                    string query = "SELECT COUNT(*) FROM Produtos;";
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                num = reader.GetInt64(0);
                            }
                        }
                    }
                }
                finally
                {
                    Desconectar();
                }
                return num;
            }
            public static long NumeroEncomendas()
            {//calcula no numero de Encomendas
                SQLiteConnection conexao = Conectar();
                long num = 0;
                try
                {
                    string query = "SELECT COUNT(*) FROM Encomendas;";
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                num = reader.GetInt64(0);
                            }
                        }
                    }
                }
                finally
                {
                    Desconectar();
                }
                return num;
            }
        }

        public Dashboard(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void ArredondarBordas(Panel panel, int raio)
        {//função que faz com que o panel tenha pontas curvas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(panel.ClientRectangle.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.ClientRectangle.Width - raio, panel.ClientRectangle.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.ClientRectangle.Height - raio, raio, raio, 90, 90);
            path.AddArc(0, 0, raio, raio, 180, 90);
            panel.Region = new Region(path);
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
                    ArredondarBordas(pln, 50);
                }
            }
            //vai escrever os valores que sao precisos da base de dados
            label_num_clientes.Text = Convert.ToString(Funcs.NumeroClientes());
            label_num_produtos.Text = Convert.ToString(Funcs.NumeroProdutos());
            label_num_encomendas.Text = Convert.ToString(Funcs.NumeroEncomendas());
            //falta fazer um grafico








        }

        private void panel_Click(object sender, EventArgs e)
        {
            //dependendo do panel vai mandar o sender para a função para mudar de janela
            principal.button_Click(sender, EventArgs.Empty);
        }
    }
}
