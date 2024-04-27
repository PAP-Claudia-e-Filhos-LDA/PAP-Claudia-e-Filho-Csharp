using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Encomendas : Form
    {
        private Principal principal;
        public Encomendas(Principal principal)
        {
            this.principal = principal;
            InitializeComponent();
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void pictureBox_aviso_encomendas_Click(object sender, EventArgs e)
        {
            //mensagem de aviso
            MessageBox.Show("Esta é a página das encomendas, aqui podes fazer e ver todas as encomendas.\n\nComo fazer uma encomenda:\n\n1)Selecione um cliente;\n2)Depois para adicionar um produto só tem de mudar a quantidade dele para algo maior que 0;\n3)Se quiser esse produto frito ou congelado é so marcar a caixa ao lado desse mesmo produto (só rissois seram fritos e congelados);\n4)Depois é confirmar a encomenda e ela vai aparecer na janela ao lado.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Encomendas_Load(object sender, EventArgs e)
        {
            DataTable dtClientes = Principal.Funcs.NomeCLientes();

            //Vai preencher, tornar apenas de leitura e aumentar a altura das cells
            dataGridView_clientes.DataSource = dtClientes;
            dataGridView_clientes.ReadOnly = true;
            dataGridView_clientes.RowTemplate.Height = 40;

            //vai trocar os cabeçalhos (que eram os campos da base de dados) para um nome melhor
            dataGridView_clientes.Columns["nome_cliente"].HeaderText = "Cliente";




            //isto é pra adicionar campos á mao que nao estao na base de dados
            DataGridViewCheckBoxColumn coluna1 = new DataGridViewCheckBoxColumn();
            coluna1.HeaderText = "Encomendar";
            coluna1.Name = "encomendar";
            // Adiciona a coluna ao DataGridView
            dataGridView_produtos.Columns.Add(coluna1);

            DataTable dtProdutos = Principal.Funcs.NomeProdutos();
            //Vai preencher, tornar apenas de leitura e aumentar a altura das cells
            dataGridView_produtos.DataSource = dtProdutos;
            dataGridView_produtos.Columns["nome_produto"].HeaderText = "Produto";
            dataGridView_produtos.RowTemplate.Height = 25;
            dataGridView_produtos.Columns["nome_produto"].ReadOnly = true;

            DataGridViewCheckBoxColumn coluna2 = new DataGridViewCheckBoxColumn();
            coluna2.HeaderText = "Fritar";
            coluna2.Name = "fritar";
            // Adiciona a coluna ao DataGridView
            dataGridView_produtos.Columns.Add(coluna2);

            DataGridViewTextBoxColumn coluna3 = new DataGridViewTextBoxColumn();
            coluna3.HeaderText = "Quantidade";
            coluna3.Name = "quantidade";
            // Adiciona a coluna ao DataGridView
            dataGridView_produtos.Columns.Add(coluna3);

            dataGridView_produtos.Columns["Quantidade"].DefaultCellStyle.NullValue = "0";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //vai perguntar de quer limpar as entrys
            DialogResult result = MessageBox.Show("Deseja limpar todas as Entrys?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se sim vai limpar 
            if (result == DialogResult.Yes)
            {
                principal.button_Click(pictureBox_limpar_encomendas, EventArgs.Empty);
            }
        }
    }
}

