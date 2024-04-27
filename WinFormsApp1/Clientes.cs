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
    
        public Clientes()
        {
            InitializeComponent();
            this.principal = principal;
            //faz com a primeira fila esteja selecionada nas duas dataGridViews
            dataGridView_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_melhores_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Arredondar os 3 panels com raios diferentes
            Principal.Funcs.ArredondarBordas(panel_clientes, 50);
            Principal.Funcs.ArredondarBordas(panel1, 15);
            Principal.Funcs.ArredondarBordas(panel_grafico, 20);
        }


        private void pictureBox_aviso_clientes_Click(object sender, EventArgs e)
        {//mensagem de ajuda
            MessageBox.Show("Esta é a página dos Clientes, aqui podes ver os dados dos clientes, e uma lista de quem são os melhores compradores.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //escreve o numero de clientes 
            label_num_clientes.Text = Convert.ToString(Principal.Funcs.NumeroClientes());

            //vai obter os dados da primeira dataGridView
            DataTable dtClientes = Principal.Funcs.ObterClientes();

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
            dtClientes = Principal.Funcs.ObterMelhoresClientes();
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
