using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{ //otimizdao
    public partial class Encomendas : Form
    {
        private Principal principal;
        public Encomendas(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();

            //só poder selecionar linhas nas datagridviews
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            PropiedadesPanel();
        }
        private void PropiedadesPanel()
        {
            //fazer o panel ficar com scrollbar 
            panel_encomendas.AutoScroll = false;
            panel_encomendas.HorizontalScroll.Enabled = false;
            panel_encomendas.HorizontalScroll.Visible = false;
            panel_encomendas.HorizontalScroll.Maximum = 0;
            panel_encomendas.AutoScroll = true;

            foreach (Control objeto in Controls)
            {
                if (objeto is Panel pln)
                {
                    Principal.Funcs.ArredondarBordas(pln, 20);
                }
            }
        }
        private void pictureBox_aviso_encomendas_Click(object sender, EventArgs e)
        {
            //mensagem de aviso
            MessageBox.Show("Esta é a página das encomendas, aqui podes fazer e ver todas as encomendas.\n\nComo fazer uma encomenda:\n\n1)Selecione um cliente;\n2)Depois para adicionar um produto só tem de mudar a quantidade dele para algo maior que 0;\n3)Se quiser esse produto frito ou congelado é so marcar a caixa ao lado desse mesmo produto (só rissois seram fritos e congelados);\n4)Depois é confirmar a encomenda e ela vai aparecer na janela ao lado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void TabelaClientes()
        {
            //Vai preencher, tornar apenas de leitura e aumentar a altura das cells
            dataGridView_clientes.DataSource = Principal.Funcs.BuscarNomes("Clientes"); ;
            dataGridView_clientes.ReadOnly = true;
            dataGridView_clientes.RowTemplate.Height = 40;
            dataGridView_clientes.Columns["nome_cliente"].HeaderText = "Cliente";
        }
        private void TabelaProdutos(string nome, Type Colunas)
        {
            //isto é para a tabela dos produtos
            //isto é pra adicionar campos á mao que nao estao na base de dados
            //coluna de checkboxs para saber se encomendo ou nao o produto
            var variavel = Activator.CreateInstance(Colunas) as DataGridViewColumn;
            string header = char.ToUpper(nome[0]) + nome.Substring(1);
            variavel.HeaderText = header;
            variavel.Name = nome;
            dataGridView_produtos.Columns.Add(variavel);
        }
        private void Encomendas_Load(object sender, EventArgs e)
        {
            //Escrever todas as encomendas
            Principal.Funcs.MostrarEncomendas(panel_encomendas);

            //função que vai preencher tabela dos cleintes
            TabelaClientes();

            //função que vai preecher a tabela dos produtos para fazer a encomenda
            dataGridView_produtos.RowTemplate.Height = 25;
            TabelaProdutos("encomendar", typeof(DataGridViewCheckBoxColumn));

            //coluna com o nomes dos produtos
            dataGridView_produtos.DataSource = Principal.Funcs.BuscarNomes("Produtos");
            dataGridView_produtos.Columns["nome_produto"].HeaderText = "Produto";
            dataGridView_produtos.Columns["nome_produto"].ReadOnly = true;
            dataGridView_produtos.RowTemplate.Height = 25;

            TabelaProdutos("fritar", typeof(DataGridViewCheckBoxColumn));

            TabelaProdutos("quantidade",typeof(DataGridViewTextBoxColumn));
            dataGridView_produtos.Columns["Quantidade"].DefaultCellStyle.NullValue = "0";


            //faz com que as duas comboboxs comecem ja com valores 
            comboBox_entrega.SelectedIndex = 0;
            comboBox_pagemento.SelectedIndex = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //vai perguntar de quer limpar as entrys
            DialogResult result = MessageBox.Show("Deseja limpar todas as Entrys?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se sim vai limpar 
            if (result == DialogResult.Yes)
                principal.button_Click(pictureBox_limpar_encomendas, EventArgs.Empty);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Variaveis
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("yyyy-MM-dd");

            bool metedo_pagamento = comboBox_pagemento.SelectedIndex == 1;
            bool metedo_entrega = comboBox_entrega.SelectedIndex == 1;

            string? clienteSelecionado = dataGridView_clientes.Rows[dataGridView_clientes.SelectedRows[0].Index].Cells["nome_cliente"].Value.ToString();
            long id = Principal.Funcs.BuscarID(clienteSelecionado,"Clientes");

            long numero_encomendas = Principal.Funcs.ContarRegistos("Encomendas") + 1;

            string mensagem = "Encomenda feita pelo administrador";

            SendKeys.SendWait("{TAB}");

            //ver os produtos todos
            if (dataGridView_produtos.SelectedRows.Count > 0)
            {
                string query = @"INSERT INTO Encomendas ('id_encomendas','id_clientes','data_encomenda','metedo_pagamento','metedo_entrega','mensagem') VALUES (@idEncomenda,@idClientes,@Data,@pagamento,@entrega,@mensagem)";
                //command que vai executar a querry com a conexao e as variaveis certas
                using (var command = new SQLiteCommand(query, Principal.Funcs.Conectar()))
                {
                    command.Parameters.AddWithValue("@idEncomenda", numero_encomendas);
                    command.Parameters.AddWithValue("@idClientes", id);
                    command.Parameters.AddWithValue("@Data", dataFormatada);
                    command.Parameters.AddWithValue("@pagamento", metedo_pagamento);
                    command.Parameters.AddWithValue("@entrega", metedo_entrega);
                    command.Parameters.AddWithValue("@mensagem", mensagem);

                    command.ExecuteNonQuery();
                }
                //entra aqui e passa so pelos produtos que tem o checkbox de encomendar ativa 
                foreach (DataGridViewRow row in dataGridView_produtos.Rows)
                {
                    //aqui dentro vou fazer a linha de encomendas
                    DataGridViewCheckBoxCell encomendar = row.Cells["encomendar"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(encomendar.Value) == true)
                    {
                        //variaveis de cada produto
                        string nomeProduto = row.Cells["nome_produto"].Value.ToString(); 
                        long idProduto = Principal.Funcs.BuscarID(nomeProduto,"Produtos");
                        bool congelado = Convert.ToBoolean(row.Cells["fritar"].Value); // true = fritar , false = congelados

                        int quantidade = 0;
                        if (int.TryParse(row.Cells["quantidade"].Value.ToString(), out quantidade))
                            quantidade = Convert.ToInt32(row.Cells["quantidade"].Value);
                        else
                            quantidade = 0; // Valor padrão caso a conversão falhe
                        

                        if (quantidade >= 0)
                        {
                            string querry = @"INSERT INTO Linha_de_Encomenda ('Encomendas_id_Encomendas','Produtos_id_produto','congelados','quantidade') VALUES (@idEncomenda, @idPRoduto, @congelados ,@quantidade)";
                            //command que vai executar a querry com a conexao e as variaveis certas
                            using (var command = new SQLiteCommand(querry, Principal.Funcs.Conectar()))
                            {
                                command.Parameters.AddWithValue("@idEncomenda", numero_encomendas);
                                command.Parameters.AddWithValue("@idPRoduto", idProduto);
                                command.Parameters.AddWithValue("@congelados", congelado);
                                command.Parameters.AddWithValue("@quantidade", quantidade);

                                command.ExecuteNonQuery();
                            }
                        }
                        
                    }

                }
                MessageBox.Show("Encomenda adicionada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            principal.button_Click(pictureBox_limpar_encomendas, EventArgs.Empty);

        }
        private void dataGridView_produtos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView_produtos.CurrentCell.ColumnIndex == dataGridView_produtos.Columns["quantidade"].Index) // Verifica se a célula atual pertence à coluna "quantidade"
            {
                TextBox textBox = e.Control as TextBox; // Obtém o controlo de edição (TextBox) da célula

                if (textBox != null)
                {
                    textBox.KeyPress -= PermitirNumerosEPontoDecimal;
                    textBox.KeyPress += PermitirNumerosEPontoDecimal;
                }
            }
        }
        private void PermitirNumerosEPontoDecimal(object sender, KeyPressEventArgs e)
        {
            //função que so deixa passar numeros e um . caso seja decimal e 2 casas decimais
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

            TextBox? textBox = sender as TextBox;
            string newText = textBox.Text.Substring(0, textBox.SelectionStart) + e.KeyChar + textBox.Text.Substring(textBox.SelectionStart + textBox.SelectionLength);
            if (newText.Length > 2 && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}

