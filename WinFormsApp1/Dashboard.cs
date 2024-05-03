using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{ //otimizado
    public partial class Dashboard : Form
    {
        private readonly Principal principal;

        public Dashboard(Principal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }
        private void pictureBox_aviso_dashboard_Click_1(object sender, EventArgs e)
        {
            //mensagem a dizer oq e 
            MessageBox.Show("Esta é a página inicial, apenas mostra o essencial. Para mais detalhes use os botões ao lado para ver as outras janelas.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //vai arredondar os panels e preencher
            ArredondarBordasPanels();
            AtualizarValoresDashboard();
            Grafico();

        }
        private void Grafico()
        {
            //variaveis 
            List<string> meses = Principal.Funcs.Grafico(true);
            List<string> lucro = Principal.Funcs.Grafico(false);

            string[] mesesArray = Principal.Funcs.Grafico(true).ToArray();
            string[] lucroArray = Principal.Funcs.Grafico(false).ToArray();


            //adicionar uma area para as barras
            chart1.Series.Add("Lucro");
            int cont = 0;
            foreach (string mes in meses)
            {
                chart1.Series["Lucro"].Points.AddXY(cont , Convert.ToDecimal(lucroArray[cont]));
                chart1.Series["Lucro"].Points[cont].AxisLabel = mesesArray[cont];
                cont++;
            }

            //cor de fundo do grafico
            chart1.ChartAreas[0].BackColor = System.Drawing.ColorTranslator.FromHtml("#2E3133 ");

            //cor das bordas
            chart1.BorderlineColor = System.Drawing.Color.White;
            chart1.BorderlineWidth = 2; // Largura da borda

            //legendas dos eixos
            chart1.ChartAreas[0].AxisX.Title = "Mês";
            chart1.ChartAreas[0].AxisY.Title = "Total (€)";

            //definir que o grafico e de barras
            chart1.Series["Lucro"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            //cor das barras
            chart1.Series["Lucro"].Color = System.Drawing.ColorTranslator.FromHtml("#FD9C3A");

            //vai pintar as linhas e as letras de branco
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.White;

            //vai fazer o grafico
            Controls.Add(chart1);
            chart1.Show();


            GraphicsPath path = new GraphicsPath();
            path.AddArc(chart1.ClientRectangle.Width - 50, 0, 50, 50, 270, 90);
            path.AddArc(chart1.ClientRectangle.Width - 50, chart1.ClientRectangle.Height - 50, 50, 50, 0, 90);
            path.AddArc(0, chart1.ClientRectangle.Height - 50, 50, 50, 90, 90);
            path.AddArc(0, 0, 50, 50, 180, 90);
            chart1.Region = new Region(path);
        }
        private void ArredondarBordasPanels()
        {
            //função que vai arrendondar os panels
            foreach (Control objeto in Controls)
            {
                if (objeto is Panel pln)
                {
                    Principal.Funcs.ArredondarBordas(pln, 50);
                }
            }
        }
        private void AtualizarValoresDashboard()
        {
            //vai escrever os valores dos panels
            label_num_clientes.Text = Convert.ToString(Principal.Funcs.ContarRegistos("Clientes"));
            label_num_produtos.Text = Convert.ToString(Principal.Funcs.ContarRegistos("Produtos"));
            label_num_encomendas.Text = Convert.ToString(Principal.Funcs.ContarRegistos("Encomendas"));
        }
        private void panel_Click(object sender, EventArgs e)
        {
            //função que vai mudar para o form selecionado
            principal.button_Click(sender, EventArgs.Empty);
        }
    }
}
