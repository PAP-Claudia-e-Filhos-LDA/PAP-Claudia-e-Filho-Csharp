using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Clientes : Form
    {
        private Principal? principal;
        public static class Funcs
        {
            //classe para as funções

            //variavel para a conexão
            private static SQLiteConnection? conexao;

            public static SQLiteConnection Conectar()
            { //liga a base de dados
                //depois mudar para caminho absuluto
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
            public static DataTable ObterClientes()
            {//vai buscar os dados dos clientes á base de dados e mete na DatagridView
                SQLiteConnection conexao = Conectar();
                DataTable dtClientes = new DataTable();
                try
                {
                    string query = "SELECT id_clientes,username,nome_cliente,contacto,email FROM Clientes;";
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(dtClientes);
                    }
                }
                finally
                {
                    Desconectar();
                }

                return dtClientes;

            }
            public static DataTable ObterMelhoresClientes()
            {//vai buscar os dados dos clientes da base de dados ordenando por mais encomendas
                SQLiteConnection conexao = Conectar();
                DataTable dtClientes = new DataTable();
                try
                {
                    string query = "SELECT C.id_clientes, C.nome_cliente, COUNT(E.id_Encomendas) AS total_encomendas FROM Clientes C LEFT JOIN Encomendas E ON C.id_clientes = E.id_clientes GROUP BY C.id_clientes, C.username, C.nome_cliente ORDER BY total_encomendas DESC;\"";
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(dtClientes);
                    }
                }
                finally
                {
                    Desconectar();
                }

                return dtClientes;

            }
        }
        public Clientes()
        {
            InitializeComponent();
            this.principal = principal;
            //faz com a primeira fila esteja selecionada nas duas dataGridViews
            dataGridView_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_melhores_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Arredondar os 3 panels com raios diferentes
            ArredondarBordas(panel_clientes, 50);
            ArredondarBordas(panel1, 15);
            ArredondarBordas(panel_grafico, 20);
        }
        private void ArredondarBordas(Panel panel, int raio)
        {//função de arredondar as bordas 
            GraphicsPath path = new GraphicsPath();
            path.AddArc(panel.ClientRectangle.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.ClientRectangle.Width - raio, panel.ClientRectangle.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.ClientRectangle.Height - raio, raio, raio, 90, 90);
            path.AddArc(0, 0, raio, raio, 180, 90);
            panel.Region = new Region(path);
        }

        private void pictureBox_aviso_clientes_Click(object sender, EventArgs e)
        {//mensagem de ajuda
            MessageBox.Show("Esta é a página dos Clientes, aqui podes ver os dados dos clientes, e uma lista de quem são os melhores compradores.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //escreve o numero de clientes 
            label_num_clientes.Text = Convert.ToString(Funcs.NumeroClientes());

            //vai obter os dados da primeira dataGridView
            DataTable dtClientes = Funcs.ObterClientes();

            //Vai preencher, tornar apenas de leitura e aumentar a altura das cells
            dataGridView_clientes.DataSource = dtClientes;
            dataGridView_clientes.ReadOnly = true;
            dataGridView_clientes.RowTemplate.Height = 40;

            //vai trocar os cabeçalhos (que eram os campos da base de dados)
            dataGridView_clientes.Columns["id_clientes"].HeaderText = "ID";
            dataGridView_clientes.Columns["username"].HeaderText = "Úsername";
            dataGridView_clientes.Columns["nome_cliente"].HeaderText = "Nome";
            dataGridView_clientes.Columns["contacto"].HeaderText = "Contacto";
            dataGridView_clientes.Columns["email"].HeaderText = "Email";

            //vai fazer o mesmo mas com outra dataGridView
            dtClientes = Funcs.ObterMelhoresClientes();
            dataGridView_melhores_clientes.DataSource = dtClientes;
            dataGridView_melhores_clientes.ReadOnly = true;
            dataGridView_melhores_clientes.RowTemplate.Height = 40;

            dataGridView_melhores_clientes.Columns["id_clientes"].HeaderText = "ID";
            dataGridView_melhores_clientes.Columns["nome_cliente"].HeaderText = "Nome";
            dataGridView_melhores_clientes.Columns["total_encomendas"].HeaderText = "Total Encomendas";
        }

        private void pictureBox_icon_Click(object sender, EventArgs e)
        {//mensagem de ajuda
            MessageBox.Show("Esta é a lista dos nossos melhores compradores, podes ver o nome de cada cliente e a quantidade de encomendas que cada um fez.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
