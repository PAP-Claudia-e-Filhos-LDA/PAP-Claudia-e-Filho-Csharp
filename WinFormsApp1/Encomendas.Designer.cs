namespace WinFormsApp1
{
    partial class Encomendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encomendas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pictureBox_aviso_encomendas = new PictureBox();
            panel_grafico = new Panel();
            dataGridView_clientes = new DataGridView();
            label_linha = new Label();
            label_encomendas = new Label();
            label8 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            dataGridView_produtos = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox_limpar_encomendas = new PictureBox();
            comboBox_pagemento = new ComboBox();
            comboBox_entrega = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label_msg_erro = new Label();
            panel_encomendas = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_encomendas).BeginInit();
            panel_grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_limpar_encomendas).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_aviso_encomendas
            // 
            pictureBox_aviso_encomendas.Cursor = Cursors.Help;
            pictureBox_aviso_encomendas.Image = (Image)resources.GetObject("pictureBox_aviso_encomendas.Image");
            pictureBox_aviso_encomendas.Location = new Point(200, 51);
            pictureBox_aviso_encomendas.Name = "pictureBox_aviso_encomendas";
            pictureBox_aviso_encomendas.Size = new Size(24, 24);
            pictureBox_aviso_encomendas.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_aviso_encomendas.TabIndex = 32;
            pictureBox_aviso_encomendas.TabStop = false;
            pictureBox_aviso_encomendas.Click += pictureBox_aviso_encomendas_Click;
            // 
            // panel_grafico
            // 
            panel_grafico.BackColor = Color.FromArgb(23, 25, 31);
            panel_grafico.Controls.Add(dataGridView_clientes);
            panel_grafico.Cursor = Cursors.Hand;
            panel_grafico.Location = new Point(41, 172);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(119, 589);
            panel_grafico.TabIndex = 31;
            // 
            // dataGridView_clientes
            // 
            dataGridView_clientes.AllowUserToAddRows = false;
            dataGridView_clientes.AllowUserToDeleteRows = false;
            dataGridView_clientes.AllowUserToOrderColumns = true;
            dataGridView_clientes.AllowUserToResizeColumns = false;
            dataGridView_clientes.AllowUserToResizeRows = false;
            dataGridView_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_clientes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_clientes.ColumnHeadersHeight = 27;
            dataGridView_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_clientes.Dock = DockStyle.Fill;
            dataGridView_clientes.EnableHeadersVisualStyles = false;
            dataGridView_clientes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_clientes.Location = new Point(0, 0);
            dataGridView_clientes.MultiSelect = false;
            dataGridView_clientes.Name = "dataGridView_clientes";
            dataGridView_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_clientes.RowHeadersVisible = false;
            dataGridView_clientes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_clientes.Size = new Size(119, 589);
            dataGridView_clientes.TabIndex = 0;
            // 
            // label_linha
            // 
            label_linha.AutoSize = true;
            label_linha.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha.Location = new Point(32, 30);
            label_linha.Name = "label_linha";
            label_linha.Size = new Size(112, 15);
            label_linha.TabIndex = 29;
            label_linha.Text = "_____________________";
            // 
            // label_encomendas
            // 
            label_encomendas.AutoSize = true;
            label_encomendas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_encomendas.ForeColor = Color.White;
            label_encomendas.Location = new Point(25, 43);
            label_encomendas.Name = "label_encomendas";
            label_encomendas.Size = new Size(177, 37);
            label_encomendas.TabIndex = 28;
            label_encomendas.Text = "Encomendas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(30, 148);
            label8.Name = "label8";
            label8.Size = new Size(148, 21);
            label8.TabIndex = 35;
            label8.Text = "Selecionar Cliente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(293, 148);
            label10.Name = "label10";
            label10.Size = new Size(163, 21);
            label10.TabIndex = 38;
            label10.Text = "Selecionar Produtos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 25, 31);
            panel2.Controls.Add(dataGridView_produtos);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(190, 172);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 589);
            panel2.TabIndex = 37;
            // 
            // dataGridView_produtos
            // 
            dataGridView_produtos.AllowUserToAddRows = false;
            dataGridView_produtos.AllowUserToDeleteRows = false;
            dataGridView_produtos.AllowUserToOrderColumns = true;
            dataGridView_produtos.AllowUserToResizeColumns = false;
            dataGridView_produtos.AllowUserToResizeRows = false;
            dataGridView_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_produtos.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_produtos.ColumnHeadersHeight = 27;
            dataGridView_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_produtos.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_produtos.Dock = DockStyle.Fill;
            dataGridView_produtos.EnableHeadersVisualStyles = false;
            dataGridView_produtos.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos.Location = new Point(0, 0);
            dataGridView_produtos.MultiSelect = false;
            dataGridView_produtos.Name = "dataGridView_produtos";
            dataGridView_produtos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_produtos.RowHeadersVisible = false;
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_produtos.Size = new Size(362, 589);
            dataGridView_produtos.TabIndex = 0;
            dataGridView_produtos.EditingControlShowing += dataGridView_produtos_EditingControlShowing;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Help;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(233, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox_limpar_encomendas
            // 
            pictureBox_limpar_encomendas.Cursor = Cursors.Help;
            pictureBox_limpar_encomendas.Image = (Image)resources.GetObject("pictureBox_limpar_encomendas.Image");
            pictureBox_limpar_encomendas.Location = new Point(263, 51);
            pictureBox_limpar_encomendas.Name = "pictureBox_limpar_encomendas";
            pictureBox_limpar_encomendas.Size = new Size(24, 24);
            pictureBox_limpar_encomendas.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_limpar_encomendas.TabIndex = 40;
            pictureBox_limpar_encomendas.TabStop = false;
            pictureBox_limpar_encomendas.Click += pictureBox2_Click;
            // 
            // comboBox_pagemento
            // 
            comboBox_pagemento.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_pagemento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_pagemento.ForeColor = Color.FromArgb(23, 25, 31);
            comboBox_pagemento.FormattingEnabled = true;
            comboBox_pagemento.Items.AddRange(new object[] { "Pagamentto em Mão", "MBway" });
            comboBox_pagemento.Location = new Point(590, 109);
            comboBox_pagemento.Name = "comboBox_pagemento";
            comboBox_pagemento.Size = new Size(168, 23);
            comboBox_pagemento.TabIndex = 41;
            // 
            // comboBox_entrega
            // 
            comboBox_entrega.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_entrega.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_entrega.FormattingEnabled = true;
            comboBox_entrega.Items.AddRange(new object[] { "Pickup", "Entrega ao Domicilio " });
            comboBox_entrega.Location = new Point(795, 109);
            comboBox_entrega.Name = "comboBox_entrega";
            comboBox_entrega.Size = new Size(168, 23);
            comboBox_entrega.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(587, 85);
            label1.Name = "label1";
            label1.Size = new Size(184, 21);
            label1.TabIndex = 43;
            label1.Text = "Metedo de Pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(795, 85);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 44;
            label2.Text = "Metedo de Entrega";
            // 
            // label_msg_erro
            // 
            label_msg_erro.AutoSize = true;
            label_msg_erro.ForeColor = Color.Red;
            label_msg_erro.Location = new Point(307, 133);
            label_msg_erro.Name = "label_msg_erro";
            label_msg_erro.Size = new Size(0, 15);
            label_msg_erro.TabIndex = 45;
            // 
            // panel_encomendas
            // 
            panel_encomendas.BackColor = Color.FromArgb(23, 25, 31);
            panel_encomendas.Location = new Point(575, 172);
            panel_encomendas.Name = "panel_encomendas";
            panel_encomendas.Size = new Size(388, 589);
            panel_encomendas.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(677, 148);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 46;
            label3.Text = "Ver Encomendas";
            // 
            // Encomendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 51);
            ClientSize = new Size(991, 791);
            Controls.Add(label3);
            Controls.Add(panel_encomendas);
            Controls.Add(label_msg_erro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_entrega);
            Controls.Add(comboBox_pagemento);
            Controls.Add(pictureBox_limpar_encomendas);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(pictureBox_aviso_encomendas);
            Controls.Add(panel_grafico);
            Controls.Add(label_linha);
            Controls.Add(label_encomendas);
            ForeColor = SystemColors.Control;
            Name = "Encomendas";
            Text = "Form1";
            Load += Encomendas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_encomendas).EndInit();
            panel_grafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_clientes).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_limpar_encomendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox_aviso_encomendas;
        private Panel panel_grafico;
        private DataGridView dataGridView_clientes;
        private Label label_linha;
        private Label label_encomendas;
        private Label label8;
        private Label label10;
        private Panel panel2;
        private DataGridView dataGridView_produtos;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_limpar_encomendas;
        private ComboBox comboBox_pagemento;
        private ComboBox comboBox_entrega;
        private Label label1;
        private Label label2;
        private Label label_msg_erro;
        private Panel panel_encomendas;
        private Label label3;
    }
}