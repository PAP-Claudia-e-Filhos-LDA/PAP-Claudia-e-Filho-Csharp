using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Mensagens : Form
    {
        public Mensagens()
        {
            InitializeComponent();
            EditarPanel();

            AnosComboBox();
            MesComboBox();
            ClienteComboBox();
            AssuntosComboBox();

        }
        private void Mensagens_Load(object sender, EventArgs e)
        {
            FazerMensagens(sender, e);
        }
        private void EditarPanel()
        {
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
            List<string> dados = Principal.Funcs.DadosMensagens(false, false, true, false);
            comboBox_clientes.Items.Clear();
            comboBox_clientes.Items.AddRange(dados.ToArray());
            AssuntosComboBox();
        }
        private void AssuntosComboBox()
        {

            List<string> assunto = Principal.Funcs.DadosMensagens(false, false, false, true);
            comboBox_assunto.Items.Clear();
            comboBox_assunto.Items.AddRange(assunto.ToArray());

        }
        private void FazerMensagens(object sender, EventArgs e)
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int indice = Array.IndexOf(meses, comboBox_mes.SelectedItem) + 1;
            string posicaoMes = indice.ToString("D2");

            if (indice == 0)
                posicaoMes = null;

            string ano = comboBox_anos.SelectedItem?.ToString() ?? null;
            string mes = posicaoMes ?? null;
            string cliente = comboBox_clientes.SelectedItem?.ToString() ?? null;
            string assunto = comboBox_assunto.SelectedItem?.ToString() ?? null;

            Principal.Funcs.MostrarMensagens(panel_mensagens, ano, mes, cliente, assunto);
        }
        private void panel_assuntos_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
                tabControl1.SelectedTab = tabPage2;
            else
                tabControl1.SelectedTab = tabPage1;
        }

        private void pictureBox_aviso_encomendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é a pagina para ver as mensagens. Podes por diferentes filtros e ver as mensagens que se enquandram nas tuas preferencias.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
