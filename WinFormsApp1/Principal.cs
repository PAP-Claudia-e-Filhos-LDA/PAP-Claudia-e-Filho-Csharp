using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
namespace WinFormsApp1
{
    public partial class Principal : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int wHeightEllipse);
        public Principal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Click(button_dashboard,e);
            MostrarFormulario(new Dashboard(this));
        }


        private void SetNavigation(object sender)
        {
            foreach (Control objeto in panel_sidebar.Controls)
            {
                if (objeto is Button btns)
                {
                    btns.BackColor = Color.FromArgb(23, 25, 31);
                }
            }
            Button? clickedButton = sender as Button;
            if (clickedButton != null)
            {
                PnlNav.Height = clickedButton.Height;
                PnlNav.Top = clickedButton.Top;
                PnlNav.Left = clickedButton.Left;
                clickedButton.BackColor = Color.FromArgb(76, 79, 81);
            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            SetNavigation(sender);
            Button? btn = sender as Button;
            Panel? pln = sender as Panel;
            PictureBox? img = sender as PictureBox;
            if (btn != null) { 
                switch (btn.Name)
                {
                    case "button_dashboard":
                        MostrarFormulario(new Dashboard(this));
                        break;
                    case "button_clientes":
                        MostrarFormulario(new Clientes());
                        break;
                    case "button_produtos":
                        MostrarFormulario(new Produtos());
                        break;
                    default:
                        // Caso nenhum botão corresponda, não faz nada
                        break;
                }
            }

            if (pln != null) {
            switch (pln.Name)
            {
                case "panel_clientes":
                        SetNavigation(button_clientes);
                        MostrarFormulario(new Clientes());
                        break;
                case "panel_produtos":
                        SetNavigation(button_produtos);
                        MostrarFormulario(new Produtos());
                        break;
                case "panel_encomendas":
                        break;
            }
                if(img != null)
                {
                    switch (img.Name)
                    {
                        case "pictureBox_icon_limpar":
                            SetNavigation(button_produtos);
                            MostrarFormulario(new Produtos());
                            break;
                    }
                }
            }

        }

        private void MostrarFormulario(Form formulario)
        {
            panel_principal.Controls.Clear();

            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            formulario.Size = panel_principal.Size;

            panel_principal.Controls.Add(formulario);

            formulario.Show();
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
