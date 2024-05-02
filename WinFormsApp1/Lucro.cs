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
    public partial class Lucro : Form
    {
        public Lucro()
        {
            InitializeComponent();
            foreach (Control objeto in Controls)
            {
                if (objeto is Panel pln)
                {
                    foreach (Control obj in pln.Controls)
                    {
                        if (obj is DataGridView dgv)
                        {
                            ConfigurarDataGridView(dgv);
                            dgv.ColumnHeadersHeight = 40;
                        }
                        if (obj is Panel pln1)
                        {
                            foreach (Control obj2 in pln1.Controls)
                            {
                                if (obj2 is DataGridView dgv2)
                                {
                                    ConfigurarDataGridView(dgv2);
                                    dgv2.ColumnHeadersHeight = 40;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Lucro_Load(object sender, EventArgs e)
        {
            AnosComboBox();
        }
        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            //vai usar estas formatações para configurar as datagridview
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 30;
        }
        private void LabelsAnos_Mes()
        {
            label_titulo_ano.Text = "Lucro e Estatisticas de " + comboBox_anos.Text;
            label_titulo_mes.Text = "Lucro e Estatisticas de " + dataGridView_Mes.Rows[dataGridView_Mes.SelectedRows[0].Index].Cells["Mês"].Value.ToString() + " de " + comboBox_anos.Text;
        }
        private void AnosComboBox()
        {
            List<string> anos = Principal.Funcs.AnosServico();
            comboBox_anos.Items.AddRange(anos.ToArray());
            comboBox_anos.SelectedIndex = 0;
        }
        private void LucroMeses()
        {
            string ano = comboBox_anos.Text;
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            List<string> mes = Principal.Funcs.MesesTotal(true, ano);
            string[] arraymes = mes.ToArray(); // tenho os meses // tenho de fazer -1 para funcionar

            List<string> lucro = Principal.Funcs.MesesTotal(false, ano);
            string[] arraylucro = lucro.ToArray(); // tenho o lucro dos meses 

            DataTable tabela = new DataTable();
            tabela.Columns.Add("Mês");
            tabela.Columns.Add("Lucro");

            for (int i = 0; i < arraymes.Length; i++)
            {
                tabela.Rows.Add(meses[Convert.ToInt32(arraymes[i]) - 1], arraylucro[i] + " €");
            }

            dataGridView_Mes.DataSource = tabela;
        }
        private void PreencherTabelas()
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            // Obtém o nome do mês da DataGridView
            string? nomeMes = dataGridView_Mes.Rows[dataGridView_Mes.SelectedRows[0].Index].Cells["Mês"].Value.ToString();

            // Obtém a posição do mês no array de meses
            int posicaoMes = Array.IndexOf(meses, nomeMes) + 1;

            //vai fazer aqueles que so pedem anos 
            Principal.Funcs.PreencherDataGridView(dataGridView_melhores_compreadores, Principal.Funcs.Lucros(comboBox_anos.Text, posicaoMes.ToString(), "Melhores Clientes,Ano"), new[] { "Nome", "Total Encomendas" });
            Principal.Funcs.PreencherDataGridView(dataGridView_produtos_mais_comprados, Principal.Funcs.Lucros(comboBox_anos.Text, posicaoMes.ToString(), "Produtos mais Comprados,Ano"), new[] { "Produto", "Vezes Encomendados" });
            Principal.Funcs.PreencherDataGridView(dataGridView_total_faturado, Principal.Funcs.Lucros(comboBox_anos.Text, posicaoMes.ToString(), "Total Faturado,Ano"), new[] { "Total Faturado" });

            //vai fazer aqueles que so pedem anos e mes
            Principal.Funcs.PreencherDataGridView(dataGridView_melhores_compreadores_mes, Principal.Funcs.Lucros(comboBox_anos.Text, posicaoMes.ToString(), "Melhores Clientes,Mes"), new[] { "Nome", "Total Encomendas" });
            Principal.Funcs.PreencherDataGridView(dataGridView_produtos_mais_comprados_mes, Principal.Funcs.Lucros(comboBox_anos.Text, posicaoMes.ToString(), "Produtos mais Comprados,Mes"), new[] { "Produto", "Vezes Encomendados" });
            Principal.Funcs.PreencherDataGridView(dataGridView_total_faturado_mes, Principal.Funcs.Lucros(comboBox_anos.Text, posicaoMes.ToString(), "Total Faturado,Mes"), new[] { "Total Faturado" });

        }
        private void comboBox_anos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LucroMeses();
            LabelsAnos_Mes();
            PreencherTabelas();
        }

        private void dataGridView_Mes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Mes.SelectedRows.Count > 0)
            { //corrigir isto
                LabelsAnos_Mes();
                PreencherTabelas();
            }
        }
    }
}
