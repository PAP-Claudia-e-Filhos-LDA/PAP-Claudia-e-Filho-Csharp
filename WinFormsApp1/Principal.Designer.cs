namespace WinFormsApp1
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel_sidebar = new Panel();
            PnlNav = new Panel();
            button_mensagens = new Button();
            button_sair = new Button();
            button_lucro = new Button();
            button_encomendas = new Button();
            button_produtos = new Button();
            button_clientes = new Button();
            button_dashboard = new Button();
            panel_icon = new Panel();
            label_Tit = new Label();
            pictureBox_icon = new PictureBox();
            panel_principal = new Panel();
            panel_sidebar.SuspendLayout();
            panel_icon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon).BeginInit();
            SuspendLayout();
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = Color.FromArgb(23, 25, 31);
            panel_sidebar.Controls.Add(PnlNav);
            panel_sidebar.Controls.Add(button_mensagens);
            panel_sidebar.Controls.Add(button_sair);
            panel_sidebar.Controls.Add(button_lucro);
            panel_sidebar.Controls.Add(button_encomendas);
            panel_sidebar.Controls.Add(button_produtos);
            panel_sidebar.Controls.Add(button_clientes);
            panel_sidebar.Controls.Add(button_dashboard);
            panel_sidebar.Controls.Add(panel_icon);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(200, 830);
            panel_sidebar.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(253, 156, 58);
            PnlNav.Location = new Point(-31, 582);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(5, 100);
            PnlNav.TabIndex = 3;
            // 
            // button_mensagens
            // 
            button_mensagens.BackColor = Color.Transparent;
            button_mensagens.Cursor = Cursors.Hand;
            button_mensagens.Dock = DockStyle.Top;
            button_mensagens.FlatAppearance.BorderSize = 0;
            button_mensagens.FlatStyle = FlatStyle.Flat;
            button_mensagens.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_mensagens.ForeColor = Color.White;
            button_mensagens.Image = (Image)resources.GetObject("button_mensagens.Image");
            button_mensagens.Location = new Point(0, 517);
            button_mensagens.Name = "button_mensagens";
            button_mensagens.Size = new Size(200, 60);
            button_mensagens.TabIndex = 2;
            button_mensagens.Text = "        Mensagens";
            button_mensagens.TextAlign = ContentAlignment.MiddleLeft;
            button_mensagens.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_mensagens.UseVisualStyleBackColor = false;
            button_mensagens.Click += button_Click;
            // 
            // button_sair
            // 
            button_sair.Cursor = Cursors.Hand;
            button_sair.Dock = DockStyle.Bottom;
            button_sair.FlatAppearance.BorderSize = 0;
            button_sair.FlatStyle = FlatStyle.Flat;
            button_sair.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sair.ForeColor = Color.White;
            button_sair.Image = (Image)resources.GetObject("button_sair.Image");
            button_sair.Location = new Point(0, 755);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(200, 75);
            button_sair.TabIndex = 1;
            button_sair.Text = "        Sair             ";
            button_sair.TextAlign = ContentAlignment.MiddleLeft;
            button_sair.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += button_sair_Click;
            // 
            // button_lucro
            // 
            button_lucro.BackColor = Color.Transparent;
            button_lucro.Cursor = Cursors.Hand;
            button_lucro.Dock = DockStyle.Top;
            button_lucro.FlatAppearance.BorderSize = 0;
            button_lucro.FlatStyle = FlatStyle.Flat;
            button_lucro.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_lucro.ForeColor = Color.White;
            button_lucro.Image = (Image)resources.GetObject("button_lucro.Image");
            button_lucro.Location = new Point(0, 457);
            button_lucro.Name = "button_lucro";
            button_lucro.Size = new Size(200, 60);
            button_lucro.TabIndex = 1;
            button_lucro.Text = "        Lucro         ";
            button_lucro.TextAlign = ContentAlignment.MiddleLeft;
            button_lucro.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_lucro.UseVisualStyleBackColor = false;
            button_lucro.Click += button_Click;
            // 
            // button_encomendas
            // 
            button_encomendas.BackColor = Color.Transparent;
            button_encomendas.Cursor = Cursors.Hand;
            button_encomendas.Dock = DockStyle.Top;
            button_encomendas.FlatAppearance.BorderSize = 0;
            button_encomendas.FlatStyle = FlatStyle.Flat;
            button_encomendas.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_encomendas.ForeColor = Color.White;
            button_encomendas.Image = (Image)resources.GetObject("button_encomendas.Image");
            button_encomendas.Location = new Point(0, 397);
            button_encomendas.Name = "button_encomendas";
            button_encomendas.Size = new Size(200, 60);
            button_encomendas.TabIndex = 1;
            button_encomendas.Text = "        Encomendas";
            button_encomendas.TextAlign = ContentAlignment.MiddleLeft;
            button_encomendas.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_encomendas.UseVisualStyleBackColor = false;
            button_encomendas.Click += button_Click;
            // 
            // button_produtos
            // 
            button_produtos.BackColor = Color.Transparent;
            button_produtos.Cursor = Cursors.Hand;
            button_produtos.Dock = DockStyle.Top;
            button_produtos.FlatAppearance.BorderSize = 0;
            button_produtos.FlatStyle = FlatStyle.Flat;
            button_produtos.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_produtos.ForeColor = Color.White;
            button_produtos.Image = (Image)resources.GetObject("button_produtos.Image");
            button_produtos.Location = new Point(0, 337);
            button_produtos.Name = "button_produtos";
            button_produtos.Size = new Size(200, 60);
            button_produtos.TabIndex = 1;
            button_produtos.Text = "        Produtos    ";
            button_produtos.TextAlign = ContentAlignment.MiddleLeft;
            button_produtos.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_produtos.UseVisualStyleBackColor = false;
            button_produtos.Click += button_Click;
            // 
            // button_clientes
            // 
            button_clientes.BackColor = Color.Transparent;
            button_clientes.Cursor = Cursors.Hand;
            button_clientes.Dock = DockStyle.Top;
            button_clientes.FlatAppearance.BorderSize = 0;
            button_clientes.FlatStyle = FlatStyle.Flat;
            button_clientes.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clientes.ForeColor = Color.White;
            button_clientes.Image = (Image)resources.GetObject("button_clientes.Image");
            button_clientes.Location = new Point(0, 277);
            button_clientes.Name = "button_clientes";
            button_clientes.Size = new Size(200, 60);
            button_clientes.TabIndex = 1;
            button_clientes.Text = "        Clientes       ";
            button_clientes.TextAlign = ContentAlignment.MiddleLeft;
            button_clientes.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_clientes.UseVisualStyleBackColor = false;
            button_clientes.Click += button_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = Color.Transparent;
            button_dashboard.Cursor = Cursors.Hand;
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Image = (Image)resources.GetObject("button_dashboard.Image");
            button_dashboard.Location = new Point(0, 217);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(200, 60);
            button_dashboard.TabIndex = 1;
            button_dashboard.Text = "        Dashboard  ";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_Click;
            // 
            // panel_icon
            // 
            panel_icon.Controls.Add(label_Tit);
            panel_icon.Controls.Add(pictureBox_icon);
            panel_icon.Dock = DockStyle.Top;
            panel_icon.Location = new Point(0, 0);
            panel_icon.Name = "panel_icon";
            panel_icon.Size = new Size(200, 217);
            panel_icon.TabIndex = 0;
            // 
            // label_Tit
            // 
            label_Tit.AutoSize = true;
            label_Tit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Tit.ForeColor = Color.White;
            label_Tit.Location = new Point(4, 171);
            label_Tit.Name = "label_Tit";
            label_Tit.Size = new Size(191, 25);
            label_Tit.TabIndex = 1;
            label_Tit.Text = "Claúdia e Filhos, Lda";
            // 
            // pictureBox_icon
            // 
            pictureBox_icon.Image = (Image)resources.GetObject("pictureBox_icon.Image");
            pictureBox_icon.Location = new Point(27, 22);
            pictureBox_icon.Name = "pictureBox_icon";
            pictureBox_icon.Size = new Size(146, 146);
            pictureBox_icon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_icon.TabIndex = 0;
            pictureBox_icon.TabStop = false;
            // 
            // panel_principal
            // 
            panel_principal.BackColor = Color.FromArgb(46, 49, 51);
            panel_principal.Dock = DockStyle.Right;
            panel_principal.Location = new Point(193, 0);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(1007, 830);
            panel_principal.TabIndex = 3;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 25, 31);
            ClientSize = new Size(1200, 830);
            Controls.Add(panel_principal);
            Controls.Add(panel_sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_sidebar.ResumeLayout(false);
            panel_icon.ResumeLayout(false);
            panel_icon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Panel panel_icon;
        private PictureBox pictureBox_icon;
        private Label label_Tit;
        private Button button_dashboard;
        private Button button_sair;
        private Button button_lucro;
        private Button button_encomendas;
        private Button button_produtos;
        private Button button_clientes;
        private Button button_mensagens;
        private Panel PnlNav;
        private Panel panel_principal;
    }
}
