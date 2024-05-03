using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{//otimizado
    public partial class Mensagens : Form
    {
        public Mensagens()
        {
            InitializeComponent();
        }
        private void Mensagens_Load(object sender, EventArgs e)
        {
            //quando o programa começar vai escrever tudo
            DisporDados(sender, e);
        }
        private void DisporDados(object sender, EventArgs e)
        {
            //vai preencher tudo oq é dados 
            Principal.Funcs.PreencherDataGridView(dataGridView_assuntos, Principal.Funcs.ObterAssuntos(), new[] { "ID", "Assunto" });
            ConfigurarDataGridView(dataGridView_assuntos);
            EditarPanel();
            AnosComboBox();
            MesComboBox();
            ClienteComboBox();
            AssuntosComboBox();
            FazerMensagens(sender, e);
        }
        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            //vai usar estas formatações para configurar as datagridview
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 40;
            dataGridView_assuntos.Columns["id_assunto"].Visible = false;
            dataGridView_assuntos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(23, 25, 31);
            dataGridView_assuntos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }
        private void EditarPanel()
        {
            //vai editar o panel
            Principal.Funcs.ArredondarBordas(panel_assuntos, 50);
            Principal.Funcs.ArredondarBordas(panel_config, 50);
            panel_mensagens.AutoScroll = false;
            panel_mensagens.HorizontalScroll.Enabled = false;
            panel_mensagens.HorizontalScroll.Visible = false;
            panel_mensagens.HorizontalScroll.Maximum = 0;
            panel_mensagens.AutoScroll = true;
        }
        private void AnosComboBox()
        {
            //quando o programa inicial vai buscar todos os anos de serviço e mete numa comboBox
            List<string> anos = Principal.Funcs.DadosMensagens(true, false, false, false);
            comboBox_anos.Items.AddRange(anos.ToArray());
        }
        private void MesComboBox()
        {
            //vai escrever todos os meses que têm mensagens e vai dispor 

            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            List<string> mes = Principal.Funcs.DadosMensagens(false, true, false, false);
            string[] arraymes = mes.ToArray();

            comboBox_mes.Items.Clear();
            if (mes.Count > 0)
                comboBox_mes.Enabled = true;

            for (int i = 0; i < arraymes.Length; i++)
            {
                comboBox_mes.Items.Add(meses[Convert.ToInt32(arraymes[i]) - 1]);
            }
        }
        private void ClienteComboBox()
        {
            //vai escrever todos os clientes que têm mensagens e vai dispor 
            List<string> dados = Principal.Funcs.DadosMensagens(false, false, true, false);
            comboBox_clientes.Items.Clear();
            comboBox_clientes.Items.AddRange(dados.ToArray());
        }
        private void AssuntosComboBox()
        {
            //vai escrever todos os assuntos que têm mensagens e vai dispor 
            List<string> assunto = Principal.Funcs.DadosMensagens(false, false, false, true);
            comboBox_assunto.Items.Clear();
            comboBox_assunto.Items.AddRange(assunto.ToArray());
        }
        private void FazerMensagens(object sender, EventArgs e)
        {
            //vai escrever as mensagens
            //string com os meses (porque eu ou tenho o nome e preciso do numero do mes ou vice-verça)
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            //vai comparar com uma combobox e saber a posição do mes
            int indice = Array.IndexOf(meses, comboBox_mes.SelectedItem) + 1;

            //se o numero for menor que 10 vai adicionar um 0 (01,02,03,..09,10)
            string posicaoMes = indice.ToString("D2");

            //se o mes ainda nao estiver selecionado vai passar a null
            if (indice == 0)
                posicaoMes = null;

            //variaveis para escrever as mensagens
            string ano = comboBox_anos.SelectedItem?.ToString() ?? null;
            string mes = posicaoMes ?? null;
            string cliente = comboBox_clientes.SelectedItem?.ToString() ?? null;
            string assunto = comboBox_assunto.SelectedItem?.ToString() ?? null;

            //função de escrever as mensagens
            Principal.Funcs.MostrarMensagens(panel_mensagens, ano, mes, cliente, assunto);
        }
        private void panel_assuntos_Click(object sender, EventArgs e)
        {
            //vai trocar de pagina 
            if (tabControl1.SelectedTab == tabPage1)
                tabControl1.SelectedTab = tabPage2;
            else
                tabControl1.SelectedTab = tabPage1;
        }
        private void pictureBox_aviso_encomendas_Click(object sender, EventArgs e)
        {
            //menmsagem de aviso
            MessageBox.Show("Esta é a pagina para ver as mensagens. Podes por diferentes filtros e ver as mensagens que se enquandram nas tuas preferencias.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void dataGridView_assuntos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //quando dou o primeiro click as cores default mudam e apartir dai vai ficar sempre selecionado
            dataGridView_assuntos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(253, 156, 58);
            dataGridView_assuntos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(23, 25, 31);

            //vai tentar is buscar os dados da tabela para a as entrys
            if (e.RowIndex >= 0)
                textBox_nome_Assunto.Text = dataGridView_assuntos.Rows[e.RowIndex].Cells["nome_assunto"].Value.ToString();
        }
        private void pictureBox_icon_confirmar_Click(object sender, EventArgs e)
        {
            //pelas cores vai ver oq tem de fazer
            Color corDataGrid = dataGridView_assuntos.DefaultCellStyle.SelectionBackColor;
            Color adicionar = Color.FromArgb(23, 25, 31);
            Color alterar = Color.FromArgb(253, 156, 58);

            //vai comparar as cores para saber oq tem de fazer
            if (corDataGrid.Equals(adicionar))
                AdicionarBD(sender, e);
            else if (corDataGrid.Equals(alterar))
                AlterarBD(sender, e);
        }
        private void AdicionarBD(object sender, EventArgs e)
        {
            //vai adicionar na bd
            //se o nome estiver vazio nao deixa fazer
            if (textBox_nome_Assunto.Text == "")
                label_msg_erro.Text = "Nome Inválido";
            else
            {
                //se o nome nao estiver vazio vai adicionar
                //vai limpar a mensagem de erro
                label_msg_erro.Text = "";

                //command que vai executar a querry com a conexao e as variaveis certas
                string query = @"INSERT INTO Assuntos (nome_assunto) VALUES (@NomeAssunto)";
                using (var command = new SQLiteCommand(query, Principal.Funcs.Conectar()))
                {
                    //vai trocar os paramentros da query para os certos
                    command.Parameters.AddWithValue("@NomeAssunto", textBox_nome_Assunto.Text);

                    //executa
                    command.ExecuteNonQuery();

                    //mensagem de aviso
                    MessageBox.Show("Assunto adicionado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //refresh
                Mensagens_Load(sender, e);
            }
        }
        private void AlterarBD(object sender, EventArgs e)
        {
            //vai alterar a BD
            //se a entry para o novo nome estiver vazio vai buscar o anterior (ou seja no final vai alterar para o mesmo nome)
            string? assunto = textBox_nome_Assunto.Text ?? dataGridView_assuntos.Rows[dataGridView_assuntos.SelectedRows[0].Index].Cells["nome_assunto"].Value.ToString();
            
            //limpar mensagem de erro 
            label_msg_erro.Text = "";

            //vai adicionar a query a um command
            string query = @"UPDATE Assuntos SET nome_assunto = @NovoNomeAssunto WHERE id_assunto = @IdProduto";
            using (var command = new SQLiteCommand(query, Principal.Funcs.Conectar()))
            {
                //vai adicioanar os paramentros á query
                command.Parameters.AddWithValue("@NovoNomeAssunto", assunto);
                command.Parameters.AddWithValue("@IdProduto", dataGridView_assuntos.Rows[dataGridView_assuntos.SelectedRows[0].Index].Cells["id_assunto"].Value.ToString());

                //executa
                command.ExecuteNonQuery();

                //mensagem de verificação
                MessageBox.Show("Assunto Alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //dá refresh para aparecerem os dados novos
            Mensagens_Load(sender, e);
        }
        private void pictureBox_icon_limpar_Click(object sender, EventArgs e)
        {
            //vai fazer tudo para limpar
            Mensagens_Load(sender, e);

            //vai limpar a entry
            textBox_nome_Assunto.Clear();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //mensagem de aviso
            MessageBox.Show("Esta é a página para configurar os assuntos que os clientes podem usar no site", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void pictureBox_icon_aviso_Click(object sender, EventArgs e)
        {
            //mensagem de aviso
            MessageBox.Show("Para usar isto é da mesma maneira que se faz encomendas.\n\n1)Se quiser adicionar um assunto novo, basta escrever o nome do novo assunto e adicionar.\n2)Para Alterar tem de selecionar um assunto na tabela ao lado, apartir do momento que seleciona um assunto esta em modo de edição.\n3)Para sair do modo de edição é carregar no icon da vassoura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
