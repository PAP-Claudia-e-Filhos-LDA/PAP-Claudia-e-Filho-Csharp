namespace WinFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox_aviso_dashboard = new PictureBox();
            panel_grafico = new Panel();
            panel_encomendas = new Panel();
            label_linha_encomendas = new Label();
            label_num_encomendas = new Label();
            pictureBox_icon_encomendas = new PictureBox();
            label_encomendas = new Label();
            panel_produtos = new Panel();
            label_linha_dashboard_produtos = new Label();
            label_num_produtos = new Label();
            label_dashboard_produtos = new Label();
            pictureBox_dashboard_icon_produtos = new PictureBox();
            panel_clientes = new Panel();
            label_num_clientes = new Label();
            label_linha_dashboard_clientes = new Label();
            label_dashboard_clientes = new Label();
            pictureBox_dashboard_icon_clientes = new PictureBox();
            label_linha_dashboard = new Label();
            label_dashboard = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_dashboard).BeginInit();
            panel_encomendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_encomendas).BeginInit();
            panel_produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_produtos).BeginInit();
            panel_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_clientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_aviso_dashboard
            // 
            pictureBox_aviso_dashboard.Cursor = Cursors.Help;
            pictureBox_aviso_dashboard.Image = (Image)resources.GetObject("pictureBox_aviso_dashboard.Image");
            pictureBox_aviso_dashboard.Location = new Point(180, 50);
            pictureBox_aviso_dashboard.Name = "pictureBox_aviso_dashboard";
            pictureBox_aviso_dashboard.Size = new Size(24, 24);
            pictureBox_aviso_dashboard.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_aviso_dashboard.TabIndex = 13;
            pictureBox_aviso_dashboard.TabStop = false;
            pictureBox_aviso_dashboard.Click += pictureBox_aviso_dashboard_Click_1;
            // 
            // panel_grafico
            // 
            panel_grafico.BackColor = Color.FromArgb(23, 25, 31);
            panel_grafico.Cursor = Cursors.Hand;
            panel_grafico.Location = new Point(26, 105);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(938, 346);
            panel_grafico.TabIndex = 12;
            // 
            // panel_encomendas
            // 
            panel_encomendas.BackColor = Color.FromArgb(23, 25, 31);
            panel_encomendas.Controls.Add(label_linha_encomendas);
            panel_encomendas.Controls.Add(label_num_encomendas);
            panel_encomendas.Controls.Add(pictureBox_icon_encomendas);
            panel_encomendas.Controls.Add(label_encomendas);
            panel_encomendas.Cursor = Cursors.Hand;
            panel_encomendas.Location = new Point(695, 508);
            panel_encomendas.Name = "panel_encomendas";
            panel_encomendas.Size = new Size(269, 253);
            panel_encomendas.TabIndex = 10;
            panel_encomendas.Click += panel_Click;
            // 
            // label_linha_encomendas
            // 
            label_linha_encomendas.AutoSize = true;
            label_linha_encomendas.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha_encomendas.Location = new Point(50, 2);
            label_linha_encomendas.Name = "label_linha_encomendas";
            label_linha_encomendas.Size = new Size(127, 15);
            label_linha_encomendas.TabIndex = 7;
            label_linha_encomendas.Text = "________________________";
            // 
            // label_num_encomendas
            // 
            label_num_encomendas.AutoSize = true;
            label_num_encomendas.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_num_encomendas.ForeColor = Color.White;
            label_num_encomendas.Location = new Point(78, 80);
            label_num_encomendas.Name = "label_num_encomendas";
            label_num_encomendas.Size = new Size(74, 86);
            label_num_encomendas.TabIndex = 10;
            label_num_encomendas.Text = "0";
            // 
            // pictureBox_icon_encomendas
            // 
            pictureBox_icon_encomendas.Image = (Image)resources.GetObject("pictureBox_icon_encomendas.Image");
            pictureBox_icon_encomendas.Location = new Point(12, 15);
            pictureBox_icon_encomendas.Name = "pictureBox_icon_encomendas";
            pictureBox_icon_encomendas.Size = new Size(32, 32);
            pictureBox_icon_encomendas.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_encomendas.TabIndex = 8;
            pictureBox_icon_encomendas.TabStop = false;
            // 
            // label_encomendas
            // 
            label_encomendas.AutoSize = true;
            label_encomendas.BackColor = Color.Transparent;
            label_encomendas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_encomendas.ForeColor = Color.Transparent;
            label_encomendas.Location = new Point(48, 15);
            label_encomendas.Name = "label_encomendas";
            label_encomendas.Size = new Size(158, 32);
            label_encomendas.TabIndex = 9;
            label_encomendas.Text = "Encomendas";
            // 
            // panel_produtos
            // 
            panel_produtos.BackColor = Color.FromArgb(23, 25, 31);
            panel_produtos.Controls.Add(label_linha_dashboard_produtos);
            panel_produtos.Controls.Add(label_num_produtos);
            panel_produtos.Controls.Add(label_dashboard_produtos);
            panel_produtos.Controls.Add(pictureBox_dashboard_icon_produtos);
            panel_produtos.Cursor = Cursors.Hand;
            panel_produtos.Location = new Point(362, 508);
            panel_produtos.Name = "panel_produtos";
            panel_produtos.Size = new Size(269, 253);
            panel_produtos.TabIndex = 11;
            panel_produtos.Click += panel_Click;
            // 
            // label_linha_dashboard_produtos
            // 
            label_linha_dashboard_produtos.AutoSize = true;
            label_linha_dashboard_produtos.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha_dashboard_produtos.Location = new Point(51, 2);
            label_linha_dashboard_produtos.Name = "label_linha_dashboard_produtos";
            label_linha_dashboard_produtos.Size = new Size(97, 15);
            label_linha_dashboard_produtos.TabIndex = 4;
            label_linha_dashboard_produtos.Text = "__________________";
            // 
            // label_num_produtos
            // 
            label_num_produtos.AutoSize = true;
            label_num_produtos.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_num_produtos.ForeColor = Color.White;
            label_num_produtos.Location = new Point(75, 80);
            label_num_produtos.Name = "label_num_produtos";
            label_num_produtos.Size = new Size(74, 86);
            label_num_produtos.TabIndex = 6;
            label_num_produtos.Text = "0";
            // 
            // label_dashboard_produtos
            // 
            label_dashboard_produtos.AutoSize = true;
            label_dashboard_produtos.BackColor = Color.Transparent;
            label_dashboard_produtos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dashboard_produtos.ForeColor = Color.Transparent;
            label_dashboard_produtos.Location = new Point(49, 15);
            label_dashboard_produtos.Name = "label_dashboard_produtos";
            label_dashboard_produtos.Size = new Size(119, 32);
            label_dashboard_produtos.TabIndex = 5;
            label_dashboard_produtos.Text = "Produtos";
            // 
            // pictureBox_dashboard_icon_produtos
            // 
            pictureBox_dashboard_icon_produtos.Image = (Image)resources.GetObject("pictureBox_dashboard_icon_produtos.Image");
            pictureBox_dashboard_icon_produtos.Location = new Point(13, 15);
            pictureBox_dashboard_icon_produtos.Name = "pictureBox_dashboard_icon_produtos";
            pictureBox_dashboard_icon_produtos.Size = new Size(32, 32);
            pictureBox_dashboard_icon_produtos.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_dashboard_icon_produtos.TabIndex = 4;
            pictureBox_dashboard_icon_produtos.TabStop = false;
            // 
            // panel_clientes
            // 
            panel_clientes.BackColor = Color.FromArgb(23, 25, 31);
            panel_clientes.Controls.Add(label_num_clientes);
            panel_clientes.Controls.Add(label_linha_dashboard_clientes);
            panel_clientes.Controls.Add(label_dashboard_clientes);
            panel_clientes.Controls.Add(pictureBox_dashboard_icon_clientes);
            panel_clientes.Cursor = Cursors.Hand;
            panel_clientes.Location = new Point(26, 508);
            panel_clientes.Name = "panel_clientes";
            panel_clientes.Size = new Size(269, 253);
            panel_clientes.TabIndex = 9;
            panel_clientes.Click += panel_Click;
            // 
            // label_num_clientes
            // 
            label_num_clientes.AutoSize = true;
            label_num_clientes.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_num_clientes.ForeColor = Color.White;
            label_num_clientes.Location = new Point(79, 80);
            label_num_clientes.Name = "label_num_clientes";
            label_num_clientes.Size = new Size(74, 86);
            label_num_clientes.TabIndex = 3;
            label_num_clientes.Text = "0";
            // 
            // label_linha_dashboard_clientes
            // 
            label_linha_dashboard_clientes.AutoSize = true;
            label_linha_dashboard_clientes.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha_dashboard_clientes.Location = new Point(57, 2);
            label_linha_dashboard_clientes.Name = "label_linha_dashboard_clientes";
            label_linha_dashboard_clientes.Size = new Size(87, 15);
            label_linha_dashboard_clientes.TabIndex = 2;
            label_linha_dashboard_clientes.Text = "________________";
            // 
            // label_dashboard_clientes
            // 
            label_dashboard_clientes.AutoSize = true;
            label_dashboard_clientes.BackColor = Color.Transparent;
            label_dashboard_clientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dashboard_clientes.ForeColor = Color.Transparent;
            label_dashboard_clientes.Location = new Point(53, 15);
            label_dashboard_clientes.Name = "label_dashboard_clientes";
            label_dashboard_clientes.Size = new Size(104, 32);
            label_dashboard_clientes.TabIndex = 1;
            label_dashboard_clientes.Text = "Clientes";
            // 
            // pictureBox_dashboard_icon_clientes
            // 
            pictureBox_dashboard_icon_clientes.Image = (Image)resources.GetObject("pictureBox_dashboard_icon_clientes.Image");
            pictureBox_dashboard_icon_clientes.Location = new Point(17, 15);
            pictureBox_dashboard_icon_clientes.Name = "pictureBox_dashboard_icon_clientes";
            pictureBox_dashboard_icon_clientes.Size = new Size(32, 32);
            pictureBox_dashboard_icon_clientes.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_dashboard_icon_clientes.TabIndex = 0;
            pictureBox_dashboard_icon_clientes.TabStop = false;
            // 
            // label_linha_dashboard
            // 
            label_linha_dashboard.AutoSize = true;
            label_linha_dashboard.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha_dashboard.Location = new Point(33, 29);
            label_linha_dashboard.Name = "label_linha_dashboard";
            label_linha_dashboard.Size = new Size(132, 15);
            label_linha_dashboard.TabIndex = 8;
            label_linha_dashboard.Text = "_________________________";
            // 
            // label_dashboard
            // 
            label_dashboard.AutoSize = true;
            label_dashboard.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dashboard.ForeColor = Color.White;
            label_dashboard.Location = new Point(26, 42);
            label_dashboard.Name = "label_dashboard";
            label_dashboard.Size = new Size(157, 37);
            label_dashboard.TabIndex = 7;
            label_dashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 51);
            ClientSize = new Size(991, 791);
            Controls.Add(panel_clientes);
            Controls.Add(pictureBox_aviso_dashboard);
            Controls.Add(panel_grafico);
            Controls.Add(panel_encomendas);
            Controls.Add(panel_produtos);
            Controls.Add(label_linha_dashboard);
            Controls.Add(label_dashboard);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Form2";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_dashboard).EndInit();
            panel_encomendas.ResumeLayout(false);
            panel_encomendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_encomendas).EndInit();
            panel_produtos.ResumeLayout(false);
            panel_produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_produtos).EndInit();
            panel_clientes.ResumeLayout(false);
            panel_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_aviso_dashboard;
        private Panel panel_grafico;
        private Panel panel_encomendas;
        private Panel panel_produtos;
        private Panel panel_clientes;
        private Label label_num_clientes;
        private Label label_linha_dashboard_clientes;
        private Label label_dashboard_clientes;
        private PictureBox pictureBox_dashboard_icon_clientes;
        private Label label_linha_dashboard;
        private Label label_dashboard;
        private Label label_linha_dashboard_produtos;
        private Label label_num_produtos;
        private Label label_dashboard_produtos;
        private PictureBox pictureBox_dashboard_icon_produtos;
        private Label label_linha_encomendas;
        private Label label_num_encomendas;
        private PictureBox pictureBox_icon_encomendas;
        private Label label_encomendas;
    }
}