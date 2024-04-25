using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Produtos : Form
    {
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
            public static DataTable ObterProdutos()
            {//vai buscar os dados dos clientes á base de dados e mete na DatagridView
                SQLiteConnection conexao = Conectar();
                DataTable dtProdutos = new DataTable();
                try
                {
                    string query = "SELECT id_produto, nome_produto, preco, desc,caminho_imagem ,CASE WHEN ativo = 1 THEN 'Sim' ELSE 'Não' END AS ativo_status FROM Produtos;\r\n";
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
        public Produtos()
        {
            InitializeComponent();
            ArredondarBordas(panel_grafico, 5);
            ArredondarBordas(panel_clientes, 50);
            ArredondarBordas(panel1, 25);
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(23, 25, 31);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            dataGridView_produtos.ClearSelection();
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
        private void pictureBox_aviso_produtos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a Página dos Produtos, aqui pode editar,adicionar, remover (ativar/desativar) os produtos que quiser.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            label_num_produtos.Text = Convert.ToString(Funcs.NumeroProdutos());

            //vai obter os dados da primeira dataGridView
            DataTable dtProdutos = Funcs.ObterProdutos();

            //Vai preencher, tornar apenas de leitura e aumentar a altura das cells
            dataGridView_produtos.DataSource = dtProdutos;
            dataGridView_produtos.ReadOnly = true;
            dataGridView_produtos.RowTemplate.Height = 40;

            //vai trocar os cabeçalhos (que eram os campos da base de dados)
            dataGridView_produtos.Columns["id_produto"].HeaderText = "ID";
            dataGridView_produtos.Columns["nome_produto"].HeaderText = "Nome";
            dataGridView_produtos.Columns["preco"].HeaderText = "Preço";
            dataGridView_produtos.Columns["desc"].HeaderText = "Descrição";
            dataGridView_produtos.Columns["caminho_imagem"].HeaderText = "Imagem";
            dataGridView_produtos.Columns["ativo_status"].HeaderText = "Ativo";
            dataGridView_produtos.Columns["caminho_imagem"].Visible = false;


        }

        private void dataGridView_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(253, 156, 58);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 25, 31);
            Funcs.Desconectar();
            Color corDataGrid = dataGridView_produtos.DefaultCellStyle.SelectionBackColor;
            Color alterar = Color.FromArgb(253, 156, 58);
            if (corDataGrid.Equals(alterar))
            {
                // Verificar se há pelo menos uma linha selecionada na DataGridView
                if (dataGridView_produtos.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView_produtos.SelectedRows[0]; // Obter a primeira linha selecionada

                    // Preencher os campos com os valores da linha selecionada
                    textBox_nome_produto.Text = row.Cells["nome_produto"].Value.ToString();
                    textBox_preço.Text = row.Cells["preco"].Value.ToString();
                    textBox_desc.Text = row.Cells["desc"].Value.ToString();
                    pictureBox_imagem.Image = Image.FromFile(row.Cells["caminho_imagem"].Value.ToString());
                }
                else
                {
                    // Limpar os campos se não houver linha selecionada
                    textBox_nome_produto.Text = "";
                    textBox_preço.Text = "";
                    textBox_desc.Text = "";
                    pictureBox_imagem.Image = null;
                }
            }
        }

        private void pictureBox_icon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como usar a janela de alterar produtos:\n\n1)Para alterar um produto dê um click no produto que quer, depois se quiser auto preencher as entrys para saber que produto selecionou faça double click;\n2) Para adicionar um produto não pode ter nenhum produto selecionado;\n3) Para remover faça um click com o botão direito do rato;", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox_icon_limpar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja limpar todas as Entrys?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (Control objeto in panel1.Controls)
                {
                    if (objeto is TextBox txt)
                    {
                        txt.Clear();
                    }
                }
                pictureBox_imagem.Image = null;
                Produtos_Load(sender, e);
                dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(23, 25, 31);
                dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

            }
        }

        private void button_add_imagem_Click(object sender, EventArgs e)
        {
            // Cria um novo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define o filtro de arquivos para exibir apenas imagens
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

            // Exibe o diálogo e verifica se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho do arquivo selecionado
                string caminhoImagem = openFileDialog.FileName;

                // Carrega a imagem na PictureBox
                pictureBox_imagem.Image = Image.FromFile(caminhoImagem);
            }
        }

        private void pictureBox_icon_confirmar_Click(object sender, EventArgs e)
        {
            Funcs.Conectar();
            List<string> erros = new List<string>();

            string caminhoDestino = "";
            string nomeImagem = "";
            string pastaDestino = "";

            string nomeProduto = "";
            decimal preço = 0;
            string descriçao = "";
            Color corDataGrid = dataGridView_produtos.DefaultCellStyle.SelectionBackColor;
            Color adicionar = Color.FromArgb(23, 25, 31);
            Color alterar = Color.FromArgb(253, 156, 58);
            long numProduto = Funcs.NumeroProdutos() + 1;

            if (corDataGrid.Equals(adicionar))
            {
                if (textBox_nome_produto.Text != "")
                {
                    nomeProduto = textBox_nome_produto.Text;
                }
                else
                {
                    erros.Add("Nome");
                }

                if (textBox_preço.Text != "" && decimal.TryParse(textBox_preço.Text, out decimal preco))
                {
                    preço = preco;
                }
                else
                {
                    erros.Add("Preço");
                }

                if (textBox_desc.Text != "")
                {
                    descriçao = textBox_desc.Text;
                }
                else
                {
                    erros.Add("Descrição");
                }

                if (pictureBox_imagem.Image != null)
                {
                    nomeImagem = @"imagem_produto_" + numProduto + ".png";
                    pastaDestino = @"..\..\..\..\img\Produtos\";
                    caminhoDestino = Path.Combine(pastaDestino, nomeImagem);

                }
                else
                {
                    erros.Add("Imagem");
                }


                if (erros.Count > 0)
                {
                    //escreve a mensagem de erro
                    string mensagemErro = string.Join(", ", erros);
                    mensagemErro += " Invalidos";
                    label_msg_erro.Text = mensagemErro;
                }
                else
                {
                    //vai adicionar na base de dados e no ficheiro
                    label_msg_erro.Text = "";
                    pictureBox_imagem.Image?.Save(caminhoDestino, System.Drawing.Imaging.ImageFormat.Png);
                    string query = @"INSERT INTO Produtos (nome_produto, preco, `desc`, caminho_imagem, ativo) VALUES (@NomeProduto, @Preco, @Descricao, @CaminhoImagem, 1)";

                    SQLiteCommand command = new SQLiteCommand(query, Funcs.Conectar());

                    command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                    command.Parameters.AddWithValue("@Preco", preço);
                    command.Parameters.AddWithValue("@Descricao", descriçao);
                    command.Parameters.AddWithValue("@CaminhoImagem", caminhoDestino);

                    command.ExecuteNonQuery();
                    //já adiciona
                    Produtos_Load(sender, e);
                }

            }
            else
            {
                if (textBox_nome_produto.Text != "")
                {
                    nomeProduto = textBox_nome_produto.Text;
                }
                else
                {
                    if (dataGridView_produtos.SelectedRows.Count > 0) // Certifica-te de que há uma linha selecionada
                    {
                        DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                        nomeProduto = selectedRow.Cells["nome_produto"].Value.ToString();
                    }
                    textBox_nome_produto.Text = nomeProduto;
                }

                if (textBox_preço.Text != "" && decimal.TryParse(textBox_preço.Text, out decimal preco))
                {
                    preço = preco;
                }
                else
                {
                    if (dataGridView_produtos.SelectedRows.Count > 0) // Certifica-te de que há uma linha selecionada
                    {
                        DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                        preço = Convert.ToDecimal(selectedRow.Cells["preco"].Value);
                    }
                    textBox_preço.Text = preço.ToString();
                }

                if (textBox_desc.Text != "")
                {
                    descriçao = textBox_desc.Text;
                }
                else
                {
                    if (dataGridView_produtos.SelectedRows.Count > 0) // Certifica-te de que há uma linha selecionada
                    {
                        DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                        descriçao = selectedRow.Cells["desc"].Value.ToString();
                    }
                    textBox_desc.Text = descriçao.ToString();
                }

                //falta dar update na tabela 
            }

        }

    }
}
