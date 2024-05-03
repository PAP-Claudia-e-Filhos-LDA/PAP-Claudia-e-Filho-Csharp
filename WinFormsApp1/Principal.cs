using System.Data.SQLite;
using System.Data;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
namespace WinFormsApp1
{
    // otimizado
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
                    conexao.Open();
                return conexao;
            }
            public static void Desconectar()
            {//desliga a base de dados
                if (conexao != null && conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
            public static long ContarRegistos(string tabela)
            {//calcula no numero de registos de uma tabela expecifica
                SQLiteConnection conexao = Conectar();
                long num = 0;
                try
                {
                    string query = "SELECT COUNT(*) FROM "+tabela+";";
                    using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
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
            public static DataTable BuscarDados(string tabela)
            {//vai buscar os dados todas á base de dados 
                string query = "";
                DataTable DadosTabela = new DataTable();
                switch (tabela)
                {
                    case "Clientes":
                        query = "SELECT id_clientes,username,nome_cliente,contacto,email FROM Clientes;";
                        break;
                    case "Melhores Clientes":
                        query = "SELECT C.id_clientes, C.nome_cliente, COUNT(E.id_Encomendas) AS total_encomendas FROM Clientes C LEFT JOIN Encomendas E ON C.id_clientes = E.id_clientes GROUP BY C.id_clientes, C.username, C.nome_cliente ORDER BY total_encomendas DESC;\"";
                        break;
                    case "Produtos":
                        query = "SELECT id_produto, nome_produto, printf('%.2f €', preco) as preco, [desc], caminho_imagem, CASE WHEN ativo = 1 THEN 'Sim' ELSE 'Não' END AS ativo_status FROM Produtos;";
                        break;
                }
                try
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(DadosTabela);
                    }
                }
                finally
                {
                    Desconectar();
                }
                return DadosTabela;
            }
            public static DataTable BuscarNomes(string tabela)
            {//vai buscar os nomes á base de dados e mete na DatagridView
                string campo = char.ToLowerInvariant(tabela[0]) + tabela.Substring(1, tabela.Length - 2);
                DataTable DadosTabela = new DataTable();
                try
                {
                    string query = "Select nome_"+campo+" from "+tabela;
                    using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                    {
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(DadosTabela);
                    }
                }
                finally
                {
                    Desconectar();
                }
                return DadosTabela;
            }
            public static long BuscarID(string nome,string tabela)
            {
                //vai buscar o id pelo nome do mesmo
                string campo = char.ToLowerInvariant(tabela[0]) + tabela.Substring(1, tabela.Length - 2);
                string idclientes = campo;

                if (campo == "cliente")
                    idclientes = campo+"s";

                long id = 0;
                try
                {
                    string query = "SELECT id_"+ idclientes + " from "+tabela+" where nome_"+campo+" = '" + nome + "'";
                    using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id = reader.GetInt64(0);
                            }
                        }
                    }
                }
                finally
                {
                    Desconectar();
                }
                return id;
            }
            public static void PreencherDataGridView(DataGridView dataGridView, DataTable dataTable, string[] headers)
            {//vai preencher uma Datagrid expecifica , com uma certa informação e vai renomear os cabeçalhos para 
                dataGridView.DataSource = dataTable;
                for (int i = 0; i < headers.Length; i++)
                {
                    dataGridView.Columns[i].HeaderText = headers[i];
                }
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
            public static void MostrarEncomendas(Panel panel_encomendas)
            {
                //vai mostrar todas as encomendas
                panel_encomendas.Controls.Clear();

                //vai apenas buscar os dados da encomenda sem os produtos
                using (SQLiteCommand command = new SQLiteCommand("SELECT Encomendas.id_Encomendas AS 'ID Encomenda', Clientes.nome_cliente AS 'Nome do Cliente', Encomendas.data_encomenda AS 'Data', CASE WHEN Encomendas.metedo_pagamento = 0 THEN 'Pagamento em Mãos' ELSE 'MBway' END AS 'Método de Pagamento', CASE WHEN Encomendas.metedo_entrega = 0 THEN 'Pickup' ELSE 'Entrega ao domicílio' END AS 'Método de Entrega', Encomendas.mensagem FROM Encomendas JOIN Clientes ON Encomendas.id_clientes = Clientes.id_clientes ORDER BY Encomendas.id_Encomendas ;", Conectar()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //vai contar o numero da encomedna
                        int linhaEncomenda = 0;

                        while (reader.Read())
                        { //vai começar a tratar dos dados 

                            //esta a por tudo em vartiaveis
                            int idEncomenda = Convert.ToInt32(reader["ID Encomenda"]);
                            string? nomeCliente = reader["Nome do Cliente"].ToString();
                            string? dataString = reader["Data"].ToString(); 
                            dataString = dataString.Substring(0, dataString.Length - 8);
                            string? metodoPagamento = reader["Método de Pagamento"].ToString();
                            string? metodoEntrega = reader["Método de Entrega"].ToString();
                            string? mensagem = reader["mensagem"].ToString();

                            //vai juntar tudo numa string
                            string encomendaInfo = "Encomenda: " + idEncomenda + "\nCliente: " + nomeCliente + "\nData: " + dataString + "\nMétodo de Pagamento: " + metodoPagamento + "\nMétodo de Entrega: " + metodoEntrega + "\nMensagem: " + (string.IsNullOrEmpty(mensagem) ? "[Nada]" : mensagem) + "\nProdutos:\n";

                            //vai juntar os preços de todo e vai calcular o preço da encomenda
                            double totalEncomenda = 0;

                            //pelo id da encomenda que esta atras vai ver todos os produtos e as suas caracteristicas 
                            using (SQLiteCommand productsCommand = new SQLiteCommand("SELECT Produtos.nome_produto, Linha_de_Encomenda.quantidade, CASE WHEN Produtos.nome_produto LIKE '%Rissol%' OR Produtos.nome_produto LIKE '%Rissois%' OR Produtos.nome_produto LIKE '%Croquete%' OR Produtos.nome_produto LIKE '%Trouxa%' THEN Linha_de_Encomenda.congelados ELSE '' END AS congelados, Produtos.preco FROM Linha_de_Encomenda JOIN Produtos ON Linha_de_Encomenda.Produtos_id_produto = Produtos.id_produto WHERE Linha_de_Encomenda.Encomendas_id_Encomendas = @IdEncomenda;", Conectar()))
                            {
                                productsCommand.Parameters.AddWithValue("@IdEncomenda", idEncomenda);
                                using (SQLiteDataReader productsReader = productsCommand.ExecuteReader())
                                {
                                    while (productsReader.Read())
                                    {
                                        string? produto = productsReader["nome_produto"].ToString();
                                        int quantidade = Convert.ToInt32(productsReader["quantidade"]);
                                        string? congelados = productsReader["congelados"].ToString();
                                        double preco = Convert.ToDouble(productsReader["preco"]);

                                        totalEncomenda += quantidade * preco;

                                        string tipoCongelamento = congelados == "0" ? "Congelado" : "Fritos";
                                        string congeladosStr = string.IsNullOrEmpty(congelados) ? "" : (", " + tipoCongelamento);
                                        string unidadeMedida = produto.Contains("Rissol") || produto.Contains("Rissois") || produto.Contains("Croquete") || produto.Contains("Trouxa") ? "duzias" : "unidades";

                                        encomendaInfo += "- " + produto + " (" + quantidade + " " + unidadeMedida + congeladosStr + ", Preço: " + preco.ToString("F2") + "€)\n";

                                    }
                                }
                            }
                            //vai escrever o total e escrevr na formatação certa
                            encomendaInfo += "Total da Encomenda: " + totalEncomenda.ToString("F2") + "€\n\n";

                            //vai criar uma label e escrever o texto da encomenda
                            Label encomendaLabel = new Label();
                            encomendaLabel.Text = encomendaInfo;
                            encomendaLabel.Font = new Font("", 10);
                            encomendaLabel.ForeColor = Color.White;
                            encomendaLabel.BackColor = ColorTranslator.FromHtml("#17191F");
                            encomendaLabel.TextAlign = ContentAlignment.MiddleLeft;
                            encomendaLabel.AutoSize = true;
                            encomendaLabel.Dock = DockStyle.Top;
                            panel_encomendas.Controls.Add(encomendaLabel);
                            linhaEncomenda++;
                        }
                    }
                }
                Desconectar();
            }
            public static List<string> AnosServico()
            { //vai mostrar os anos de serviço
                List<string> anos = new List<string>();

                string query = "SELECT DISTINCT strftime('%Y', data_encomenda) FROM Encomendas";
                using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            anos.Add(reader.GetString(0)); 
                        }
                    }
                }
                return anos;
            }
            public static List<string> MesesTotal(bool fazer, string ano)
            { //vou fazer isto duas vezes , 1) para saber o numero do mes , 2)para saber o lucro desse mes
                List<string> dados = new List<string>();

                string query = "SELECT strftime('%m', data_encomenda) AS mes, SUM(preco_produto * quantidade) AS total_lucro FROM Encomendas JOIN Linha_de_Encomenda ON Encomendas.id_Encomendas = Linha_de_Encomenda.Encomendas_id_Encomendas JOIN Produtos ON Linha_de_Encomenda.Produtos_id_produto = Produtos.id_produto WHERE strftime('%Y', data_encomenda) = @ano GROUP BY mes ORDER BY mes;";
                using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                {
                    command.Parameters.AddWithValue("@ano", ano);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if(fazer)
                                dados.Add(reader.GetString(0));
                            else
                                dados.Add(reader.GetDecimal(1).ToString());
                        }
                    }
                }
                return dados;
            }
            public static DataTable Lucros(string ano, string mes,string fazer) 
            {//dependendo do ano do mes e do que vou fazer vai fazer querys diferntes
                string query = "";
                DataTable DadosTabela = new DataTable();
                try
                {
                    //vai fazer oq eu escrevi no fazer
                    switch (fazer)
                    {
                        case "Melhores Clientes,Ano":
                                query = @" SELECT c.nome_cliente, COUNT(e.id_Encomendas) AS total_encomendas FROM Clientes c JOIN Encomendas e ON c.id_clientes = e.id_clientes WHERE strftime('%Y', e.data_encomenda) = @ano GROUP BY c.id_clientes ORDER BY total_encomendas DESC; ";
                            break;
                        case "Produtos mais Comprados,Ano":
                                 query = "SELECT p.nome_produto, SUM(le.quantidade) AS total_quantidade FROM Produtos p JOIN Linha_de_Encomenda le ON p.id_produto = le.Produtos_id_produto JOIN Encomendas e ON le.Encomendas_id_Encomendas = e.id_Encomendas WHERE strftime('%Y', e.data_encomenda) = @ano GROUP BY p.id_produto ORDER BY total_quantidade DESC;";
                            break;
                        case "Total Faturado,Ano":
                                 query = "SELECT SUM(le.quantidade * le.preco_produto) || ' €' AS lucro_total FROM Linha_de_Encomenda le JOIN Encomendas e ON le.Encomendas_id_Encomendas = e.id_Encomendas WHERE strftime('%Y', e.data_encomenda) = @ano;";
                            break;
                        case "Melhores Clientes,Mes":
                            query = @" SELECT c.nome_cliente, COUNT(e.id_Encomendas) AS total_encomendas FROM Clientes c JOIN Encomendas e ON c.id_clientes = e.id_clientes WHERE strftime('%Y', e.data_encomenda) = @ano AND strftime('%m', e.data_encomenda) = @mes GROUP BY c.id_clientes ORDER BY total_encomendas DESC;";
                            break;
                        case "Produtos mais Comprados,Mes":
                            query = "SELECT p.nome_produto, SUM(le.quantidade) AS total_quantidade FROM Produtos p JOIN Linha_de_Encomenda le ON p.id_produto = le.Produtos_id_produto JOIN Encomendas e ON le.Encomendas_id_Encomendas = e.id_Encomendas WHERE strftime('%Y', e.data_encomenda) = @ano AND strftime('%m', e.data_encomenda) = @mes GROUP BY p.id_produto ORDER BY total_quantidade DESC;\r\n";
                            break;
                        case "Total Faturado,Mes":
                            query = "SELECT SUM(le.quantidade * le.preco_produto) || ' €' AS lucro_total FROM Linha_de_Encomenda le JOIN Encomendas e ON le.Encomendas_id_Encomendas = e.id_Encomendas WHERE strftime('%Y', e.data_encomenda) = @ano AND strftime('%m', e.data_encomenda) = @mes;\r\n";
                            break;
                    }
                    using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                    {
                        command.Parameters.AddWithValue("@ano", ano);
                        command.Parameters.AddWithValue("@mes", mes);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        adapter.Fill(DadosTabela);
                    }
                }
                finally
                {
                    Desconectar();
                }
                return DadosTabela;
            }
            public static List<string> DadosMensagens(bool ano,bool mes , bool cliente, bool assunto)
            {
                //dependendo dos dados que estiverem false vai fazer certas querys
                string query = "";
                List<string> dados = new List<string>();

                if (ano)
                    query = "SELECT DISTINCT strftime('%Y', data_mensagem) FROM Mensagens_Clientes";
                if (mes)
                    query = @" SELECT DISTINCT strftime('%m', data_mensagem) AS meses_diferentes FROM Mensagens_Clientes; ";
                if (cliente)
                    query = @" SELECT DISTINCT(c.nome_cliente) FROM Clientes c INNER JOIN Mensagens_Clientes mc ON c.id_clientes = mc.id_cliente;";
                if (assunto)
                    query = @"SELECT DISTINCT A.nome_assunto FROM Mensagens_Clientes AS MC JOIN Assuntos AS A ON MC.id_assunto = A.id_assunto JOIN Clientes AS C ON MC.id_cliente = C.id_clientes";

                    using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dados.Add(reader.GetString(0));
                            }
                        }
                    }
                return dados;
            }
            public static void MostrarMensagens(Panel panel_mensagens, string ano, string mes, string cliente, string assunto)
            {
                //vai mostrar as mensagens dependendo dos dados que existem
                string query = @"SELECT MC.id_mensagem, C.nome_cliente, MC.mensagem, C.imagem_perfil, A.nome_assunto FROM Mensagens_Clientes AS MC JOIN Clientes AS C ON MC.id_cliente = C.id_clientes LEFT JOIN Assuntos AS A ON MC.id_assunto = A.id_assunto";

                //se os paramentros da função tiverem null vai mostrar as mensagens de maneira diferente
                //vai adicionando coisa á query
                List<string> conditions = new List<string>();
                if (ano != null)
                    conditions.Add("strftime('%Y', MC.data_mensagem) = @ano");
                if (mes != null)
                    conditions.Add("strftime('%m', MC.data_mensagem) = @mes");
                if (cliente != null)
                    conditions.Add("C.nome_cliente = @cliente");
                if (assunto != null)
                    conditions.Add("A.nome_assunto = @assunto");
                
                //aqui escrevr tudo oq guardou na query
                if (conditions.Count > 0)
                    query += " WHERE " + string.Join(" AND ", conditions);

                //apaga todas as mensagens anteriores
                panel_mensagens.Controls.Clear();

                //mensagem default (pois nao faria eu escrever uma opinião de um cliente sendo que sou eu que estou a fazer)
                string mensagemInfo = "Não existem mensagens com essas configurações.";

                //vai executar a query
                using (var command = new SQLiteCommand(query, Conectar()))
                {
                    if (conditions.Count > 0)
                    {
                        //se todos os valores tiverem vazios nao vai trocar nada / se nao tiverem vai trocar (e nao tem problema trocar valores mesmo que eles nao existem na query)
                        command.Parameters.AddWithValue("@ano", ano);
                        command.Parameters.AddWithValue("@mes", mes);
                        command.Parameters.AddWithValue("@cliente", cliente);
                        command.Parameters.AddWithValue("@assunto", assunto);
                    }

                    //vai executar
                    using (var reader = command.ExecuteReader())
                    {
                        //se tiver linha faz isto
                        if (reader.HasRows)
                        {
                            //vai escrever as mensagens todas numa unica string
                            mensagemInfo = "";
                            while (reader.Read())
                            {
                                //vai buscar as varieveis
                                int id_mensagem = reader.GetInt32(0);
                                string nome_cliente = reader.GetString(1);
                                string mensagem = reader.GetString(2);
                                string imagem_perfil = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                string nome_assunto = reader.IsDBNull(4) ? "" : reader.GetString(4);

                                //vai adicionar tudo á string
                                mensagemInfo += "Mensagem Nº: " + id_mensagem + "\nCliente: " + nome_cliente + "\nMensagem: " + mensagem + "\nAssunto: " + nome_assunto + "\n\n\n";

                                //vai fazer a imagem de perfil
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.ImageLocation = imagem_perfil; 
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
                                pictureBox.Size = new Size(75, 75); 
                                pictureBox.Location = new Point(10, panel_mensagens.Controls.Count * 120); 
                                panel_mensagens.Controls.Add(pictureBox);
                            }
                        }
                    }
                }

                //vai criar uma label e por o texto tudo nela 
                Label label_mensagem = new Label();
                label_mensagem.Text = mensagemInfo;
                label_mensagem.Font = new Font("", 12);
                label_mensagem.ForeColor = Color.White;
                label_mensagem.AutoSize = true;
                label_mensagem.Padding = new Padding(100, 0, 0, 0);
                panel_mensagens.Controls.Add(label_mensagem);

                //da refresh e adiciona tudo
                panel_mensagens.PerformLayout();
            }
            public static DataTable ObterAssuntos()
            {
                //vai mostrar todos os assuntos 
                DataTable dataTable = new DataTable();

                using (SQLiteConnection conexao = Conectar())
                {
                    string query = @"SELECT * from Assuntos";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conexao))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                return dataTable;
            }
            public static List<string> Grafico(bool fazer)
            { //vou fazer isto duas vezes , 1) para saber o numero do mes , 2)para saber o lucro desse mes

                List<string> dados = new List<string>();

                string query = "SELECT strftime('%Y-%m', E.\"data_encomenda\") AS month, SUM(LE.\"preco_produto\" * LE.\"quantidade\") AS total_amount FROM \"Encomendas\" AS E JOIN \"Linha_de_Encomenda\" AS LE ON E.\"id_Encomendas\" = LE.\"Encomendas_id_Encomendas\" GROUP BY month ORDER BY month";
                using (SQLiteCommand command = new SQLiteCommand(query, Conectar()))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (fazer)
                                dados.Add(reader.GetString(0));
                            else
                                dados.Add(reader.GetDecimal(1).ToString());
                        }
                    }
                }
                return dados;
            }
        }

        //coisa para fazer curvas redondas
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int wHeightEllipse);
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
        }
        private void SetNavigation(object sender)
        {
            //função para mudar as cores e parecer que esta selecionado
            foreach (Control objeto in panel_sidebar.Controls)
            { //isto vai tirar as cores de todos botoes
                if (objeto is Button btns)
                    btns.BackColor = Color.FromArgb(23, 25, 31);
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
            switch (sender)
            {
                case Button btn:
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
                        case "button_lucro":
                            MostrarFormulario(new Lucro());
                            break;
                        case "button_mensagens":
                            MostrarFormulario(new Mensagens());
                            break;
                        default:
                            MessageBox.Show("Botão sem função");
                            break;
                    }
                    break;
                case (Panel pln):
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
                    break;
                case (PictureBox img):
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
                    break;
                case(Chart cht):
                    SetNavigation(button_lucro);
                    MostrarFormulario(new Lucro());
                    break;
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
