using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Produtos : Form
    {
        //otimizado
        public Produtos()
        {
            //vai começar o form com algumas configurações ja feitas
            InitializeComponent();
            ConfigurarControls();
        }

        private void ConfigurarControls()
        {
            //vai arredondar os 3 panels de forma diferente
            Principal.Funcs.ArredondarBordas(panel_grafico, 5);
            Principal.Funcs.ArredondarBordas(panel_clientes, 50);
            Principal.Funcs.ArredondarBordas(panel1, 25);

            //vai configurar as datagridview
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_produtos.RowTemplate.Height = 40;
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            //vai fazer estas duas funções quando iniciar e em outras ocasiões
            CarregarProdutos();
            LimparCampos();
        }

        private void CarregarProdutos()
        {
            //vai escrever o numero de produtos que existe
            label_num_produtos.Text = Convert.ToString(Principal.Funcs.NumeroProdutos());

            //vai preencher a datagridview e atualizar os cabeçalhos
            DataTable dtProdutos = Principal.Funcs.ObterProdutos();
            dataGridView_produtos.DataSource = dtProdutos;
            Principal.Funcs.PreencherDataGridView(dataGridView_produtos, Principal.Funcs.ObterProdutos(), new[] { "ID", "Nome", "Preço", "Descrição", "Imagem", "Ativo" });
            dataGridView_produtos.Columns["caminho_imagem"].Visible = false;
        }

        private void LimparCampos()
        {
            //vai limpar todas as seleções basicamante
            foreach (Control objeto in panel1.Controls)
            {
                if (objeto is TextBox txt)
                {
                    txt.Clear();
                }
            }
            pictureBox_imagem.Image = null;
            label_msg_erro.Text = "";
        }

        private void AdicionarBD(object sender, EventArgs e)
        {
            //função que vai buscar os valores e vai adicionar a base de dados

            //lista de string que vai ter o nome dos erros depois a mostra no final
            List<string> erros = new List<string>();

            //variaveis que vai ser adicionadas na base de dados
            string nomeProduto = textBox_nome_produto.Text.Trim();
            decimal preco;
            bool precoValido = decimal.TryParse(textBox_preço.Text, out preco) && preco > 0;
            string descricao = textBox_desc.Text.Trim();
            string caminhoDestino = pictureBox_imagem.Image != null ? Path.Combine(@"..\..\..\..\img\Produtos\", $"imagem_produto_{Principal.Funcs.NumeroProdutos() + 1}.png") : "";

            //vai verificar todas as variaveis 
            if (string.IsNullOrEmpty(nomeProduto))
                erros.Add("Nome");

            if (!precoValido)
                erros.Add("Preço");

            if (string.IsNullOrEmpty(descricao))
                erros.Add("Descrição");

            if (pictureBox_imagem.Image == null)
                erros.Add("Imagem");

            //vai tentar adicionar 
            if (erros.Count > 0)
            {
                //como tem erros só vai escrever os erros
                string mensagemErro = string.Join(", ", erros) + " Inválidos";
                label_msg_erro.Text = mensagemErro;
            }
            else
            {
                //como nao tem erros vai adicionar

                //vai limpar a mensagem de erro
                label_msg_erro.Text = "";

                //vai guardar a imagem no sitio certo com o nome expecifico
                pictureBox_imagem.Image?.Save(caminhoDestino, System.Drawing.Imaging.ImageFormat.Png);

                //querry que vai adicionar os produtos
                string query = @"INSERT INTO Produtos (nome_produto, preco, `desc`, caminho_imagem, ativo) VALUES (@NomeProduto, @Preco, @Descricao, @CaminhoImagem, 1)";

                //command que vai executar a querry com a conexao e as variaveis certas
                using (var command = new SQLiteCommand(query, Principal.Funcs.Conectar()))
                {
                    command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                    command.Parameters.AddWithValue("@Preco", preco);
                    command.Parameters.AddWithValue("@Descricao", descricao);
                    command.Parameters.AddWithValue("@CaminhoImagem", caminhoDestino);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Produto adicionado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Produtos_Load(sender, e);
                }
            }
        }

        private void AlterarBD(object sender, EventArgs e)
        {
            //variaveis
            string caminhoDestino = "";
            string nomeProduto = textBox_nome_produto.Text.Trim();
            decimal preco = 0;
            string descricao = textBox_desc.Text.Trim();

            //vai verificar as variavies 
            if (pictureBox_imagem.Image != null && dataGridView_produtos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                caminhoDestino = selectedRow.Cells["caminho_imagem"].Value.ToString();
            }

            if (string.IsNullOrEmpty(nomeProduto) && dataGridView_produtos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                nomeProduto = selectedRow.Cells["nome_produto"].Value.ToString();
                textBox_nome_produto.Text = nomeProduto;
            }

            if (!decimal.TryParse(textBox_preço.Text.Replace("€", ""), out preco) || preco <= 0)
            {
                if (dataGridView_produtos.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                    string precoString = selectedRow.Cells["preco"].Value.ToString().Replace("€", "");
                    preco = decimal.TryParse(precoString, out decimal precoConvertido) ? precoConvertido : 0;
                }
                textBox_preço.Text = preco.ToString();
            }


            if (string.IsNullOrEmpty(descricao) && dataGridView_produtos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                descricao = selectedRow.Cells["desc"].Value.ToString();
                textBox_desc.Text = descricao;
            }

            //vai tentar guardar a imagem
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

            //querry que avai atualizar
            string query = @"
                     UPDATE Produtos 
                     SET nome_produto = @NomeProduto, preco = @Preco, `desc` = @Descricao, caminho_imagem = @CaminhoImagem 
                     WHERE id_produto = @IdProduto";

            //vai tentar adicionar 
            try
            {
                //comamando que vai execurar com a conexao a base de dados e as variaveis certas
                using (SQLiteCommand command = new SQLiteCommand(query, Principal.Funcs.Conectar()))
                {
                    if (dataGridView_produtos.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dataGridView_produtos.SelectedRows[0];
                        int idProduto = Convert.ToInt32(selectedRow.Cells["id_produto"].Value);

                        command.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                        command.Parameters.AddWithValue("@Preco", preco);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@CaminhoImagem", caminhoDestino);
                        command.Parameters.AddWithValue("@IdProduto", idProduto);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Produto atualizado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Produto não atualizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //vai recarregar para atualizar os dados
            Produtos_Load(sender, e);
        }

        private void DesativarProduto(string nomeProduto, int ativo)
        {
            //função para alterar o estado de ativo do produto
            string mensagem = ativo == 1 ? "Quer ativar este produto?" : "Quer desativar este produto?";
            DialogResult result = MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "UPDATE Produtos SET ativo = @ativo WHERE nome_produto = @nomeProduto";

                    using (SQLiteConnection conexao = Principal.Funcs.Conectar())
                    using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@ativo", ativo);
                        command.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Alteração feita.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SQLiteException)
                {
                    MessageBox.Show("A Alteração não foi feita", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //quando dou o primeiro click as cores default mudam e apartir dai vai ficar sempre selecionado
            dataGridView_produtos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(253, 156, 58);
            dataGridView_produtos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 25, 31);

            //vai tentar is buscar os dados da tabela para a as entrys
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_produtos.Rows[e.RowIndex];
                textBox_nome_produto.Text = row.Cells["nome_produto"].Value.ToString();
                textBox_preço.Text = row.Cells["preco"].Value.ToString().Split(' ')[0];
                textBox_desc.Text = row.Cells["desc"].Value.ToString();

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
            label_msg_erro.Text = "";
        }

        private void pictureBox_icon_Click(object sender, EventArgs e)
        {
            //mensagem a explicar oq e 
            MessageBox.Show("Como usar a janela de alterar produtos:\n\n1)Para alterar um produto dê um click no produto que quer, depois se quiser auto preencher as entrys para saber que produto selecionou faça double click;\n2) Para adicionar um produto não pode ter nenhum produto selecionado;\n3) Para remover faça um click com o botão direito do rato;", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox_icon_limpar_Click(object sender, EventArgs e)
        {
            //função para limpar 
            DialogResult result = MessageBox.Show("Deseja limpar todas as Entrys?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Produtos_Load(sender, e);
            }
        }

        private void button_add_imagem_Click(object sender, EventArgs e)
        {
            //vai tentar adicionar a imagem
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_imagem.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                label_msg_erro.Text = "Tipo de ficheiro errado";
            }
        }

        private void pictureBox_icon_confirmar_Click(object sender, EventArgs e)
        {
            //pelas cores vai ver oq tem de fazer
            Color corDataGrid = dataGridView_produtos.DefaultCellStyle.SelectionBackColor;
            Color adicionar = Color.FromArgb(23, 25, 31);
            Color alterar = Color.FromArgb(253, 156, 58);

            if (corDataGrid.Equals(adicionar))
            {
                AdicionarBD(sender, e);
            }
            else if (corDataGrid.Equals(alterar))
            {
                AlterarBD(sender, e);
            }
        }

        private void textBox_nome_produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao deixa escrever caracters que eu nao quero
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox_preço_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao deixa escrever caracters que eu nao quero
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView_produtos_MouseDown(object sender, MouseEventArgs e)
        {
            //quando faço um click com botao direito pergunta se quer apagar 
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dataGridView_produtos.HitTest(e.X, e.Y).RowIndex;

                if (rowIndex >= 0 && rowIndex < dataGridView_produtos.Rows.Count)
                {
                    DataGridViewRow clickedRow = dataGridView_produtos.Rows[rowIndex];
                    string nomeProduto = clickedRow.Cells["nome_produto"].Value.ToString();
                    int ativo = clickedRow.Cells["ativo_status"].Value.ToString() == "Sim" ? 0 : 1;

                    DesativarProduto(nomeProduto, ativo);
                    Produtos_Load(sender, e);
                }
            }
        }

        private void pictureBox_aviso_produtos_Click(object sender, EventArgs e)
        {
            //mensagem de aviso
            MessageBox.Show("Esta página é a dos Produtos aqui dá para gerir os produtos da maneira que quiser");
        }
    }
}
