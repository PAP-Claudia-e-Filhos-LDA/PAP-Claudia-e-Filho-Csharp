using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            //vai arredondar as bordas dos panels
            Principal.Funcs.ArredondarBordas(panel_grafico, 5);
            Principal.Funcs.ArredondarBordas(panel_clientes, 50);
            Principal.Funcs.ArredondarBordas(panel1, 25);

            //vai fazer com que apenas se possa selecionar linhas 
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //mudar a default color pq nao consigo desselecionar 
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(23, 25, 31);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        }
        private void pictureBox_aviso_produtos_Click(object sender, EventArgs e)
        {
            //Mensagem de aviso
            MessageBox.Show("Esta é a Página dos Produtos, aqui pode editar,adicionar, remover (ativar/desativar) os produtos que quiser.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            //texto a dizer numero de produtos
            label_num_produtos.Text = Convert.ToString(Principal.Funcs.NumeroProdutos());

            //vai obter os dados da primeira dataGridView
            DataTable dtProdutos = Principal.Funcs.ObterProdutos();

            //Vai preencher, tornar apenas de leitura e aumentar a altura das cells
            dataGridView_produtos.DataSource = dtProdutos;
            dataGridView_produtos.ReadOnly = true;
            dataGridView_produtos.RowTemplate.Height = 40;

            //vai trocar os cabeçalhos (que eram os campos da base de dados) para um nome melhor
            dataGridView_produtos.Columns["id_produto"].HeaderText = "ID";
            dataGridView_produtos.Columns["nome_produto"].HeaderText = "Nome";
            dataGridView_produtos.Columns["preco"].HeaderText = "Preço";
            dataGridView_produtos.Columns["desc"].HeaderText = "Descrição";
            dataGridView_produtos.Columns["caminho_imagem"].HeaderText = "Imagem";
            dataGridView_produtos.Columns["ativo_status"].HeaderText = "Ativo";

            //vou esconder o campo do caminho da imagem pq nao me dá jeito ter , mas preciso dele para algumas coisas
            dataGridView_produtos.Columns["caminho_imagem"].Visible = false;

            //muda as cores para parecer que nada esta selecionado
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(23, 25, 31);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

            //a picture box vai começar sem nenhuma imagem
            pictureBox_imagem.Image = null;

            //todas as entrys começam sempre vazias
            foreach (Control objeto in panel1.Controls)
            {
                if (objeto is TextBox txt)
                {
                    txt.Clear();
                }
            }

            //a mensagem de erro fica vazia
            label_msg_erro.Text = "";
        }

        private void dataGridView_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //quando dou o primeiro click as cores default mudam e apartir dai vai ficar sempre selecionado
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(253, 156, 58);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 25, 31);

            // Verificar se há pelo menos uma linha selecionada na DataGridView
            if (dataGridView_produtos.SelectedRows.Count > 0)
            {
                try
                {
                    //vai tentar ir buscar os dados á tabela
                    DataGridViewRow row = dataGridView_produtos.SelectedRows[0];
                    textBox_nome_produto.Text = row.Cells["nome_produto"].Value.ToString();
                    textBox_preço.Text = row.Cells["preco"].Value.ToString().Split(' ')[0];
                    textBox_desc.Text = row.Cells["desc"].Value.ToString();

                    //Mete a imagem se o caminho estiver certo
                    string? caminhoImagem = row.Cells["caminho_imagem"].Value.ToString();
                    if (!string.IsNullOrEmpty(caminhoImagem))
                    {
                        pictureBox_imagem.Image = Image.FromFile(caminhoImagem);
                    }
                    else
                    {
                        pictureBox_imagem.Image = null;
                    }
                }
                catch (Exception)
                {
                    //mete uma imagem a dizer "sem imagem"
                    pictureBox_imagem.Image = Image.FromFile(@"..\..\..\..\img\Produtos\sem_imagem.png");
                }
            }
            //limpar os erros quando vou buscar os produtos
            label_msg_erro.Text = "";
        }

        private void pictureBox_icon_Click(object sender, EventArgs e)
        {
            //mensagem de aviso
            MessageBox.Show("Como usar a janela de alterar produtos:\n\n1)Para alterar um produto dê um click no produto que quer, depois se quiser auto preencher as entrys para saber que produto selecionou faça double click;\n2) Para adicionar um produto não pode ter nenhum produto selecionado;\n3) Para remover faça um click com o botão direito do rato;", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox_icon_limpar_Click(object sender, EventArgs e)
        {
            //vai perguntar de quer limpar as entrys
            DialogResult result = MessageBox.Show("Deseja limpar todas as Entrys?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se sim vai limpar 
            if (result == DialogResult.Yes)
            {
                Produtos_Load(sender, e);
            }
        }

        private void button_add_imagem_Click(object sender, EventArgs e)
        {
            try
            {
                //faz a janela de pedir imagem
                OpenFileDialog openFileDialog = new OpenFileDialog();

                //faz com que só apareçam imagens
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

                //mostra a janela para selecionar a imagem
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //vai buscar o caminho da imagem e exibe na PictureBox
                    pictureBox_imagem.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                //mensagem de erro
                label_msg_erro.Text = "Tipo de ficheiro errado";
            }

        }

        private void pictureBox_icon_confirmar_Click(object sender, EventArgs e)
        {
            //Estas sao as cores que eu estou sempre a mudar , depois posso saber oq quero fazer
            Color corDataGrid = dataGridView_produtos.DefaultCellStyle.SelectionBackColor;
            Color adicionar = Color.FromArgb(23, 25, 31);
            Color alterar = Color.FromArgb(253, 156, 58);

            //se a cor de fundo for a Adicionar (amarelo/laranja) vai adicionar o produto
            if (corDataGrid.Equals(adicionar))
            {
                AdicionarBD(sender, e);
            }
            else if (corDataGrid.Equals(alterar)) //aqui vai começar a alterar
            {
                AlterarBD(sender, e);
            }
        }
        private void AdicionarBD(object sender, EventArgs e)
        {
            //ligar á base de dados
            Principal.Funcs.Conectar();

            //lista que vai ter os erros depois de passar por todos os campos
            List<string> erros = new List<string>();

            //variaveis 
            string caminhoDestino = "";
            string nomeProduto = "";
            decimal preço = 0;
            string descriçao = "";

            //se tiver texto vai guardar, se não tiver vai adicionar o nome do erro á lista para depois mostrar
            if (textBox_nome_produto.Text != "")
            {
                nomeProduto = textBox_nome_produto.Text;
            }
            else
            {
                erros.Add("Nome");
            }

            //vai fazer a mesma coisa que o anterior mas aqui tento passar para decimal.
            if (textBox_preço.Text != "" && decimal.TryParse(textBox_preço.Text, out decimal preco))
            {
                preço = preco;
            }
            else
            {
                erros.Add("Preço");
            }

            //não verificação para a descrição, tanto pode ter numeros, letras, simbolos
            if (textBox_desc.Text != "")
            {
                descriçao = textBox_desc.Text;
            }
            else
            {
                erros.Add("Descrição");
            }

            //faz o mesmo que os outros 
            if (pictureBox_imagem.Image != null)
            {
                //escreve o nome da imagem e guarda numa pasta especifica
                caminhoDestino = Path.Combine(@"..\..\..\..\img\Produtos\", @"imagem_produto_" + (Principal.Funcs.NumeroProdutos() + 1) + ".png");
            }
            else
            {
                erros.Add("Imagem");
            }


            //se tiver algum erro vai escrever a mensagem de erro se nao tiver vai tentar adicionar o produto
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

                //limpa a mensagem de erro
                label_msg_erro.Text = "";

                //vai guardar a imagem no caminho certo
                pictureBox_imagem.Image?.Save(caminhoDestino, System.Drawing.Imaging.ImageFormat.Png);

                //vai fazer a querry com as variaveis certas
                string query = @"INSERT INTO Produtos (nome_produto, preco, `desc`, caminho_imagem, ativo) VALUES (@NomeProduto, @Preco, @Descricao, @CaminhoImagem, 1)";

                //faz o commando sql
                SQLiteCommand command = new SQLiteCommand(query, Principal.Funcs.Conectar());

                //mete as variveis nos parametros 
                command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                command.Parameters.AddWithValue("@Preco", preço);
                command.Parameters.AddWithValue("@Descricao", descriçao);
                command.Parameters.AddWithValue("@CaminhoImagem", caminhoDestino);

                //Executa (já adiciona)
                command.ExecuteNonQuery();

                //mensagem a dizer que correu tudo bem
                MessageBox.Show("Produto adicionado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //basicamente limpa tudo
                Produtos_Load(sender, e);
            }

        }
        private void AlterarBD(object sender, EventArgs e)
        {
            //ligar á base de dados
            Principal.Funcs.Conectar();

            //variaveis 
            string? caminhoDestino = "";
            string? nomeProduto = "";
            decimal? preço = 0;
            string? descriçao = "";

            //se o nome estiver vazio vai buscar o anterior á tabela, para não alterar para um campo nulo/vazio
            if (textBox_nome_produto.Text != "")
            {
                nomeProduto = textBox_nome_produto.Text;
            }
            else
            {
                if (dataGridView_produtos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                    nomeProduto = selectedRow.Cells["nome_produto"].Value.ToString();
                }
                textBox_nome_produto.Text = nomeProduto;
            }

            //faz o mesmo com o preço
            if (textBox_preço.Text != "" && decimal.TryParse(textBox_preço.Text, out decimal preco))
            {
                preço = preco;
            }
            else
            {
                if (dataGridView_produtos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                    preço = Convert.ToDecimal(selectedRow.Cells["preco"].Value);
                }
                textBox_preço.Text = preço.ToString();
            }

            //faz o mesmo com a descrição
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

            if (pictureBox_imagem.Image != null)
            {
                //assumindo que os caminhos estão bem isto vai buscar o nome anterior e vai usar sempre o mesmo acho
                if (dataGridView_produtos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                    caminhoDestino = selectedRow.Cells["caminho_imagem"].Value.ToString();
                }
            }

            //vai guardar a imagem no caminho certo

            // Guardar a nova imagem no caminho correto
            try
            {
                using (var imagem = pictureBox_imagem.Image)
                {
                    if (imagem != null)
                    {
                        imagem.Save(caminhoDestino);
                    }
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Erro ao adicionar");
            }

            //vai fazer a querry com as variaveis certas
            string query = @"
                            UPDATE Produtos 
                            SET nome_produto = @NomeProduto, preco = @Preco, `desc` = @Descricao, caminho_imagem = @CaminhoImagem 
                            WHERE id_produto = @IdProduto";

            // Conectar à base de dados SQLite
            SQLiteConnection conexao = Principal.Funcs.Conectar();
            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    if (dataGridView_produtos.SelectedRows.Count > 0)
                    {
                        //atualizar pelo id
                        DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                        int idProduto = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);

                        command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                        command.Parameters.AddWithValue("@Preco", preço);
                        command.Parameters.AddWithValue("@Descricao", descriçao);
                        command.Parameters.AddWithValue("@CaminhoImagem", caminhoDestino);
                        command.Parameters.AddWithValue("@IdProduto", idProduto);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Produto atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception )
            {
                // Exibe uma mensagem de erro ao usuário em caso de falha
                MessageBox.Show("Produto não atualizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //basicamente limpa tudo
            Produtos_Load(sender, e);
        }
        private void textBox_nome_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // se tentar escrever um numero vai apagar
                e.Handled = true;
            }
        }
        private void textBox_preço_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                //so vai deixar escrever numeros e o "."
                e.Handled = true;
            }
        }
        private void dataGridView_produtos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit = dataGridView_produtos.HitTest(e.X, e.Y);

                //verifica se foi clicado
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    //vou assumir que estas duas vairveis começam quando o produto esta 0 ou seja desativado
                    //vou deixar um pois caso seja para mudar a variavel ja esta 1
                    int? ativo = 1;
                    string mensagem = "Quer ativar este produto?";

                    int rowIndex = hit.RowIndex;
                    DataGridViewRow clickedRow = dataGridView_produtos.Rows[rowIndex];

                    string? nomeProduto = clickedRow.Cells["nome_produto"].Value.ToString();

                    if (clickedRow.Cells["ativo_status"].Value.ToString() == "Sim")
                    {
                        //vou mudar a mensagem de erro e a variavel para oq é suposto
                        mensagem = "Quer desativar este produto?";
                        //vai icar 0 pois supostamento o produto esta ativo e vai ficar desativado ou seja 0
                        ativo = 0;
                    }

                    
                    //vai perguntar de quer atualizar o produto
                    DialogResult result = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //se sim faz
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            //vai tentar atualizar pelo nome do produto
                            string query = "UPDATE Produtos SET ativo = @ativo WHERE nome_produto = @nomeProduto";

                            using (SQLiteConnection conexao = Principal.Funcs.Conectar())
                            using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                            {
                                command.Parameters.AddWithValue("@ativo", ativo);
                                command.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                                command.ExecuteNonQuery();

                            }
                            MessageBox.Show("Alteração feita com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (SQLiteException)
                        {
                            MessageBox.Show("A Alteração não foi feita", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Produtos_Load(sender, e);
                
                }
            }
        }
    }
}