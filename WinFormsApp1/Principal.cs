using System.Data.SQLite;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Drawing.Drawing2D;
namespace WinFormsApp1
{
    public partial class Principal : Form
    {
        //classe com as Funções
        public static class Funcs
        {
            //classe para as funções

            //variavel para a conexão
            private static SQLiteConnection? conexao;

            public static SQLiteConnection Conectar()
            { //liga a base de dados
                //depois mudar para caminho absuluto
                string caminho = "Data Source=\"..\\..\\..\\..\\bd\\Rissois.db\";Version=3;";
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
            public static DataTable ObterProdutos()
            {//vai buscar os dados dos produtos á base de dados e mete na DatagridView
                SQLiteConnection conexao = Conectar();
                DataTable dtProdutos = new DataTable();
                try
                {
                string query = "SELECT id_produto, nome_produto, printf('%.2f €', preco) as preco, [desc], caminho_imagem, CASE WHEN ativo = 1 THEN 'Sim' ELSE 'Não' END AS ativo_status FROM Produtos;";
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(dtProdutos);
                    }
                }
                finally
                {
                    Desconectar();
                }

                return dtProdutos;

            }
            public static void ArredondarBordas(Panel panel, int raio)
            {//função de arredondar as bordas 
                GraphicsPath path = new GraphicsPath();
                path.AddArc(panel.ClientRectangle.Width - raio, 0, raio, raio, 270, 90);
                path.AddArc(panel.ClientRectangle.Width - raio, panel.ClientRectangle.Height - raio, raio, raio, 0, 90);
                path.AddArc(0, panel.ClientRectangle.Height - raio, raio, raio, 90, 90);
                path.AddArc(0, 0, raio, raio, 180, 90);
                panel.Region = new Region(path);
            }
            public static DataTable NomeCLientes()
            {//vai buscar os nomes dos clientes á base de dados e mete na DatagridView
                SQLiteConnection conexao = Conectar();
                DataTable dtClientes = new DataTable();
                try
                {
                    string query = "Select nome_cliente from Clientes";
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
            public static DataTable NomeProdutos()
            {//vai buscar os nomes dos clientes á base de dados e mete na DatagridView
                SQLiteConnection conexao = Conectar();
                DataTable dtProdutos = new DataTable();
                try
                {
                    string query = "Select nome_produto from Produtos";
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(dtProdutos);
                    }
                }
                finally
                {
                    Desconectar();
                }

                return dtProdutos;

            }
        }


        //coisa para fazer curvas redondas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int wHeightEllipse);
        public Principal()
        {
            InitializeComponent();
            //quando o programa liga vai fazer o form redondo
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vai carregar no botao dashboard para ficar selecionado e com a janela do dashboard ativa
            button_Click(button_dashboard,e);
            MostrarFormulario(new Dashboard(this));
        }

        private void SetNavigation(object sender)
        {
            //função para mudar as cores e parecer que esta selecionado
            foreach (Control objeto in panel_sidebar.Controls)
            { //isto vai tirar as cores de todos botoes
                if (objeto is Button btns)
                {
                    btns.BackColor = Color.FromArgb(23, 25, 31);
                }
            }
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {//aqui vai por com as cores de quando esta selecionado
                PnlNav.Height = clickedButton.Height;
                PnlNav.Top = clickedButton.Top;
                PnlNav.Left = clickedButton.Left;
                clickedButton.BackColor = Color.FromArgb(76, 79, 81);
            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            //quando eu carrego em um botao , panel de outro form vai fazer esta função 
            SetNavigation(sender);
            Button? btn = sender as Button;
            Panel? pln = sender as Panel;
            PictureBox? img = sender as PictureBox;
            if (btn != null) { 
                switch (btn.Name)
                {
                    case "button_dashboard":
                        MostrarFormulario(new Dashboard(this));
                        break;
                    case "button_clientes":
                        MostrarFormulario(new Clientes());
                        break;
                    case "button_produtos":
                        MostrarFormulario(new Produtos());
                        break;
                    case "button_encomendas":
                        MostrarFormulario(new Encomendas(this));
                        break;
                    default:
                        MessageBox.Show("Botão sem função");
                        break;
                }
            }

            if (pln != null)
            {
                switch (pln.Name)
                {
                    case "panel_clientes":
                        SetNavigation(button_clientes);
                        MostrarFormulario(new Clientes());
                        break;
                    case "panel_produtos":
                        SetNavigation(button_produtos);
                        MostrarFormulario(new Produtos());
                        break;
                    case "panel_encomendas":
                        SetNavigation(button_encomendas);
                        MostrarFormulario(new Encomendas(this));
                        break;
                }

            }
            if (img != null)
            {
                switch (img.Name)
                {
                    case "pictureBox_icon_limpar":
                        SetNavigation(button_produtos);
                        MostrarFormulario(new Produtos());
                        break;
                    case "pictureBox_limpar_encomendas":
                        SetNavigation(button_encomendas);
                        MostrarFormulario(new Encomendas(this));
                        break;
                }
            }
        }

        private void MostrarFormulario(Form formulario)
        {
            //meto o form que vou trabalhar dentro do form principal
            panel_principal.Controls.Clear();

            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            formulario.Size = panel_principal.Size;

            panel_principal.Controls.Add(formulario);

            formulario.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            //botao de sair
            Application.Exit();
        }
    }
}
