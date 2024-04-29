using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{ //otimizado
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            //vai iniciar as furnções que vão consfigurar as datagrid view
            ConfigurarDataGridView(dataGridView_clientes);
            ConfigurarDataGridView(dataGridView_melhores_clientes);
        }
        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            //vai usar estas formatações para configurar as datagridview
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 40;
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            //vai preencher a datagridview
            Principal.Funcs.PreencherDataGridView(dataGridView_clientes, Principal.Funcs.ObterClientes(),new[] { "ID", "Username", "Nome", "Contacto", "Email" });
            Principal.Funcs.PreencherDataGridView(dataGridView_melhores_clientes, Principal.Funcs.ObterMelhoresClientes(),new[] { "ID", "Nome", "Total Encomendas" });

            //label com numeros clientes
            label_num_clientes.Text = Convert.ToString(Principal.Funcs.NumeroClientes());
        }
        private void pictureBox_aviso_clientes_Click(object sender, EventArgs e)
        {
            //mensagem de aviso a explicar oq e 
            MessageBox.Show("Esta é a página dos Clientes, aqui podes ver os dados dos clientes, e uma lista de quem são os melhores compradores.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void pictureBox_icon_Click(object sender, EventArgs e)
        {
            //mensagem de aviso a explicar oq e 
            MessageBox.Show("Esta é a lista dos nossos melhores compradores, podes ver o nome de cada cliente e a quantidade de encomendas que cada um fez.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
