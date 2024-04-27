namespace WinFormsApp1
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel_clientes = new Panel();
            label_num_clientes = new Label();
            label_linha_dashboard_clientes = new Label();
            label_dashboard_clientes = new Label();
            pictureBox_dashboard_icon_clientes = new PictureBox();
            pictureBox_aviso_clientes = new PictureBox();
            panel_grafico = new Panel();
            dataGridView_clientes = new DataGridView();
            label_linha = new Label();
            label_clientes = new Label();
            panel1 = new Panel();
            dataGridView_melhores_clientes = new DataGridView();
            pictureBox_icon = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_clientes).BeginInit();
            panel_grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_melhores_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon).BeginInit();
            SuspendLayout();
            // 
            // panel_clientes
            // 
            panel_clientes.BackColor = Color.FromArgb(23, 25, 31);
            panel_clientes.Controls.Add(label_num_clientes);
            panel_clientes.Controls.Add(label_linha_dashboard_clientes);
            panel_clientes.Controls.Add(label_dashboard_clientes);
            panel_clientes.Controls.Add(pictureBox_dashboard_icon_clientes);
            panel_clientes.Cursor = Cursors.Hand;
            panel_clientes.Location = new Point(679, 100);
            panel_clientes.Name = "panel_clientes";
            panel_clientes.Size = new Size(287, 160);
            panel_clientes.TabIndex = 16;
            // 
            // label_num_clientes
            // 
            label_num_clientes.AutoSize = true;
            label_num_clientes.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_num_clientes.ForeColor = Color.White;
            label_num_clientes.Location = new Point(83, 47);
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
            // pictureBox_aviso_clientes
            // 
            pictureBox_aviso_clientes.Cursor = Cursors.Help;
            pictureBox_aviso_clientes.Image = (Image)resources.GetObject("pictureBox_aviso_clientes.Image");
            pictureBox_aviso_clientes.Location = new Point(139, 50);
            pictureBox_aviso_clientes.Name = "pictureBox_aviso_clientes";
            pictureBox_aviso_clientes.Size = new Size(24, 24);
            pictureBox_aviso_clientes.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_aviso_clientes.TabIndex = 20;
            pictureBox_aviso_clientes.TabStop = false;
            pictureBox_aviso_clientes.Click += pictureBox_aviso_clientes_Click;
            // 
            // panel_grafico
            // 
            panel_grafico.BackColor = Color.FromArgb(23, 25, 31);
            panel_grafico.Controls.Add(dataGridView_clientes);
            panel_grafico.Cursor = Cursors.Hand;
            panel_grafico.Location = new Point(26, 100);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(617, 660);
            panel_grafico.TabIndex = 19;
            // 
            // dataGridView_clientes
            // 
            dataGridView_clientes.AllowUserToAddRows = false;
            dataGridView_clientes.AllowUserToDeleteRows = false;
            dataGridView_clientes.AllowUserToOrderColumns = true;
            dataGridView_clientes.AllowUserToResizeColumns = false;
            dataGridView_clientes.AllowUserToResizeRows = false;
            dataGridView_clientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_clientes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_clientes.ColumnHeadersHeight = 27;
            dataGridView_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_clientes.EnableHeadersVisualStyles = false;
            dataGridView_clientes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_clientes.Location = new Point(0, 0);
            dataGridView_clientes.MultiSelect = false;
            dataGridView_clientes.Name = "dataGridView_clientes";
            dataGridView_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_clientes.RowHeadersVisible = false;
            dataGridView_clientes.Size = new Size(617, 660);
            dataGridView_clientes.TabIndex = 0;
            // 
            // label_linha
            // 
            label_linha.AutoSize = true;
            label_linha.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha.Location = new Point(33, 29);
            label_linha.Name = "label_linha";
            label_linha.Size = new Size(102, 15);
            label_linha.TabIndex = 15;
            label_linha.Text = "___________________";
            // 
            // label_clientes
            // 
            label_clientes.AutoSize = true;
            label_clientes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_clientes.ForeColor = Color.White;
            label_clientes.Location = new Point(26, 42);
            label_clientes.Name = "label_clientes";
            label_clientes.Size = new Size(119, 37);
            label_clientes.TabIndex = 14;
            label_clientes.Text = "Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 25, 31);
            panel1.Controls.Add(dataGridView_melhores_clientes);
            panel1.Controls.Add(pictureBox_icon);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(679, 297);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 463);
            panel1.TabIndex = 21;
            // 
            // dataGridView_melhores_clientes
            // 
            dataGridView_melhores_clientes.AllowUserToAddRows = false;
            dataGridView_melhores_clientes.AllowUserToDeleteRows = false;
            dataGridView_melhores_clientes.AllowUserToOrderColumns = true;
            dataGridView_melhores_clientes.AllowUserToResizeColumns = false;
            dataGridView_melhores_clientes.AllowUserToResizeRows = false;
            dataGridView_melhores_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_melhores_clientes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_melhores_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_melhores_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_melhores_clientes.ColumnHeadersHeight = 35;
            dataGridView_melhores_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_melhores_clientes.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_melhores_clientes.Dock = DockStyle.Bottom;
            dataGridView_melhores_clientes.EnableHeadersVisualStyles = false;
            dataGridView_melhores_clientes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_melhores_clientes.Location = new Point(0, 77);
            dataGridView_melhores_clientes.MultiSelect = false;
            dataGridView_melhores_clientes.Name = "dataGridView_melhores_clientes";
            dataGridView_melhores_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_melhores_clientes.RowHeadersVisible = false;
            dataGridView_melhores_clientes.Size = new Size(287, 386);
            dataGridView_melhores_clientes.TabIndex = 1;
            // 
            // pictureBox_icon
            // 
            pictureBox_icon.Cursor = Cursors.Help;
            pictureBox_icon.Image = (Image)resources.GetObject("pictureBox_icon.Image");
            pictureBox_icon.Location = new Point(242, 23);
            pictureBox_icon.Name = "pictureBox_icon";
            pictureBox_icon.Size = new Size(24, 24);
            pictureBox_icon.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon.TabIndex = 22;
            pictureBox_icon.TabStop = false;
            pictureBox_icon.Click += pictureBox_icon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(253, 156, 58);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(222, 15);
            label1.TabIndex = 5;
            label1.Text = "___________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(2, 20);
            label2.Name = "label2";
            label2.Size = new Size(241, 30);
            label2.TabIndex = 4;
            label2.Text = "Melhores Compradores";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 51);
            ClientSize = new Size(991, 791);
            Controls.Add(panel1);
            Controls.Add(panel_clientes);
            Controls.Add(pictureBox_aviso_clientes);
            Controls.Add(panel_grafico);
            Controls.Add(label_linha);
            Controls.Add(label_clientes);
            Name = "Clientes";
            Text = "Form1";
            Load += Clientes_Load;
            panel_clientes.ResumeLayout(false);
            panel_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_clientes).EndInit();
            panel_grafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_melhores_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_clientes;
        private Label label_num_clientes;
        private Label label_linha_dashboard_clientes;
        private Label label_dashboard_clientes;
        private PictureBox pictureBox_dashboard_icon_clientes;
        private PictureBox pictureBox_aviso_clientes;
        private Panel panel_grafico;
        private Label label_linha;
        private Label label_clientes;
        private DataGridView dataGridView_clientes;
        private Panel panel1;
        private PictureBox pictureBox_icon;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView_melhores_clientes;
    }
}