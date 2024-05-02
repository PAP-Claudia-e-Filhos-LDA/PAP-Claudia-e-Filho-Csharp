namespace WinFormsApp1
{
    partial class Lucro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lucro));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            pictureBox_aviso_encomendas = new PictureBox();
            label_linha = new Label();
            label_encomendas = new Label();
            comboBox_anos = new ComboBox();
            panel2 = new Panel();
            dataGridView_Mes = new DataGridView();
            panel1 = new Panel();
            panel5 = new Panel();
            dataGridView_total_faturado = new DataGridView();
            panel4 = new Panel();
            dataGridView_produtos_mais_comprados = new DataGridView();
            panel3 = new Panel();
            dataGridView_melhores_compreadores = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label_titulo_ano = new Label();
            Panel12 = new Panel();
            panel7 = new Panel();
            dataGridView_total_faturado_mes = new DataGridView();
            panel8 = new Panel();
            dataGridView_produtos_mais_comprados_mes = new DataGridView();
            panel9 = new Panel();
            dataGridView_melhores_compreadores_mes = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label_titulo_mes = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_encomendas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mes).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_total_faturado).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos_mais_comprados).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_melhores_compreadores).BeginInit();
            Panel12.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_total_faturado_mes).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos_mais_comprados_mes).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_melhores_compreadores_mes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_aviso_encomendas
            // 
            pictureBox_aviso_encomendas.Cursor = Cursors.Help;
            pictureBox_aviso_encomendas.Image = (Image)resources.GetObject("pictureBox_aviso_encomendas.Image");
            pictureBox_aviso_encomendas.Location = new Point(111, 51);
            pictureBox_aviso_encomendas.Name = "pictureBox_aviso_encomendas";
            pictureBox_aviso_encomendas.Size = new Size(24, 24);
            pictureBox_aviso_encomendas.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_aviso_encomendas.TabIndex = 43;
            pictureBox_aviso_encomendas.TabStop = false;
            pictureBox_aviso_encomendas.Click += pictureBox_aviso_encomendas_Click;
            // 
            // label_linha
            // 
            label_linha.AutoSize = true;
            label_linha.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha.Location = new Point(33, 30);
            label_linha.Name = "label_linha";
            label_linha.Size = new Size(62, 15);
            label_linha.TabIndex = 42;
            label_linha.Text = "___________";
            // 
            // label_encomendas
            // 
            label_encomendas.AutoSize = true;
            label_encomendas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_encomendas.ForeColor = Color.White;
            label_encomendas.Location = new Point(26, 43);
            label_encomendas.Name = "label_encomendas";
            label_encomendas.Size = new Size(88, 37);
            label_encomendas.TabIndex = 41;
            label_encomendas.Text = "Lucro";
            // 
            // comboBox_anos
            // 
            comboBox_anos.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_anos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_anos.ForeColor = Color.FromArgb(23, 25, 31);
            comboBox_anos.FormattingEnabled = true;
            comboBox_anos.Location = new Point(111, 115);
            comboBox_anos.Name = "comboBox_anos";
            comboBox_anos.Size = new Size(187, 23);
            comboBox_anos.TabIndex = 46;
            comboBox_anos.SelectedIndexChanged += comboBox_anos_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 25, 31);
            panel2.Controls.Add(dataGridView_Mes);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(111, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 589);
            panel2.TabIndex = 47;
            // 
            // dataGridView_Mes
            // 
            dataGridView_Mes.AllowUserToAddRows = false;
            dataGridView_Mes.AllowUserToDeleteRows = false;
            dataGridView_Mes.AllowUserToOrderColumns = true;
            dataGridView_Mes.AllowUserToResizeColumns = false;
            dataGridView_Mes.AllowUserToResizeRows = false;
            dataGridView_Mes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Mes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_Mes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Mes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Mes.ColumnHeadersHeight = 27;
            dataGridView_Mes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Mes.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Mes.Dock = DockStyle.Fill;
            dataGridView_Mes.EnableHeadersVisualStyles = false;
            dataGridView_Mes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_Mes.Location = new Point(0, 0);
            dataGridView_Mes.MultiSelect = false;
            dataGridView_Mes.Name = "dataGridView_Mes";
            dataGridView_Mes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_Mes.RowHeadersVisible = false;
            dataGridView_Mes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_Mes.Size = new Size(187, 589);
            dataGridView_Mes.TabIndex = 0;
            dataGridView_Mes.SelectionChanged += dataGridView_Mes_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 25, 31);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label_titulo_ano);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(352, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(571, 281);
            panel1.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(23, 25, 31);
            panel5.Controls.Add(dataGridView_total_faturado);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(439, 91);
            panel5.Name = "panel5";
            panel5.Size = new Size(120, 69);
            panel5.TabIndex = 50;
            // 
            // dataGridView_total_faturado
            // 
            dataGridView_total_faturado.AllowUserToAddRows = false;
            dataGridView_total_faturado.AllowUserToDeleteRows = false;
            dataGridView_total_faturado.AllowUserToOrderColumns = true;
            dataGridView_total_faturado.AllowUserToResizeColumns = false;
            dataGridView_total_faturado.AllowUserToResizeRows = false;
            dataGridView_total_faturado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_total_faturado.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_total_faturado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_total_faturado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_total_faturado.ColumnHeadersHeight = 27;
            dataGridView_total_faturado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView_total_faturado.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_total_faturado.Dock = DockStyle.Fill;
            dataGridView_total_faturado.EnableHeadersVisualStyles = false;
            dataGridView_total_faturado.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_total_faturado.Location = new Point(0, 0);
            dataGridView_total_faturado.MultiSelect = false;
            dataGridView_total_faturado.Name = "dataGridView_total_faturado";
            dataGridView_total_faturado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_total_faturado.RowHeadersVisible = false;
            dataGridView_total_faturado.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_total_faturado.Size = new Size(120, 69);
            dataGridView_total_faturado.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(23, 25, 31);
            panel4.Controls.Add(dataGridView_produtos_mais_comprados);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(205, 91);
            panel4.Name = "panel4";
            panel4.Size = new Size(210, 169);
            panel4.TabIndex = 49;
            // 
            // dataGridView_produtos_mais_comprados
            // 
            dataGridView_produtos_mais_comprados.AllowUserToAddRows = false;
            dataGridView_produtos_mais_comprados.AllowUserToDeleteRows = false;
            dataGridView_produtos_mais_comprados.AllowUserToOrderColumns = true;
            dataGridView_produtos_mais_comprados.AllowUserToResizeColumns = false;
            dataGridView_produtos_mais_comprados.AllowUserToResizeRows = false;
            dataGridView_produtos_mais_comprados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_produtos_mais_comprados.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos_mais_comprados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView_produtos_mais_comprados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_produtos_mais_comprados.ColumnHeadersHeight = 27;
            dataGridView_produtos_mais_comprados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView_produtos_mais_comprados.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_produtos_mais_comprados.Dock = DockStyle.Fill;
            dataGridView_produtos_mais_comprados.EnableHeadersVisualStyles = false;
            dataGridView_produtos_mais_comprados.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos_mais_comprados.Location = new Point(0, 0);
            dataGridView_produtos_mais_comprados.MultiSelect = false;
            dataGridView_produtos_mais_comprados.Name = "dataGridView_produtos_mais_comprados";
            dataGridView_produtos_mais_comprados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_produtos_mais_comprados.RowHeadersVisible = false;
            dataGridView_produtos_mais_comprados.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_produtos_mais_comprados.Size = new Size(210, 169);
            dataGridView_produtos_mais_comprados.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(23, 25, 31);
            panel3.Controls.Add(dataGridView_melhores_compreadores);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(12, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 169);
            panel3.TabIndex = 48;
            // 
            // dataGridView_melhores_compreadores
            // 
            dataGridView_melhores_compreadores.AllowUserToAddRows = false;
            dataGridView_melhores_compreadores.AllowUserToDeleteRows = false;
            dataGridView_melhores_compreadores.AllowUserToOrderColumns = true;
            dataGridView_melhores_compreadores.AllowUserToResizeColumns = false;
            dataGridView_melhores_compreadores.AllowUserToResizeRows = false;
            dataGridView_melhores_compreadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_melhores_compreadores.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_melhores_compreadores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView_melhores_compreadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView_melhores_compreadores.ColumnHeadersHeight = 27;
            dataGridView_melhores_compreadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView_melhores_compreadores.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView_melhores_compreadores.Dock = DockStyle.Fill;
            dataGridView_melhores_compreadores.EnableHeadersVisualStyles = false;
            dataGridView_melhores_compreadores.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_melhores_compreadores.Location = new Point(0, 0);
            dataGridView_melhores_compreadores.MultiSelect = false;
            dataGridView_melhores_compreadores.Name = "dataGridView_melhores_compreadores";
            dataGridView_melhores_compreadores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_melhores_compreadores.RowHeadersVisible = false;
            dataGridView_melhores_compreadores.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_melhores_compreadores.Size = new Size(187, 169);
            dataGridView_melhores_compreadores.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(439, 56);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 52;
            label2.Text = "Total Faturado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(205, 56);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 51;
            label1.Text = "Produtos mais Comprados";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(12, 56);
            label10.Name = "label10";
            label10.Size = new Size(187, 21);
            label10.TabIndex = 50;
            label10.Text = "Melhores Compradores";
            // 
            // label_titulo_ano
            // 
            label_titulo_ano.AutoSize = true;
            label_titulo_ano.BackColor = Color.Transparent;
            label_titulo_ano.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titulo_ano.ForeColor = Color.Transparent;
            label_titulo_ano.Location = new Point(147, 14);
            label_titulo_ano.Name = "label_titulo_ano";
            label_titulo_ano.Size = new Size(233, 30);
            label_titulo_ano.TabIndex = 50;
            label_titulo_ano.Text = "Lucro e Estatisticas de ";
            // 
            // Panel12
            // 
            Panel12.BackColor = Color.FromArgb(23, 25, 31);
            Panel12.Controls.Add(panel7);
            Panel12.Controls.Add(panel8);
            Panel12.Controls.Add(panel9);
            Panel12.Controls.Add(label3);
            Panel12.Controls.Add(label4);
            Panel12.Controls.Add(label5);
            Panel12.Controls.Add(label_titulo_mes);
            Panel12.Cursor = Cursors.Hand;
            Panel12.Location = new Point(352, 477);
            Panel12.Name = "Panel12";
            Panel12.Size = new Size(571, 281);
            Panel12.TabIndex = 53;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(23, 25, 31);
            panel7.Controls.Add(dataGridView_total_faturado_mes);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(439, 91);
            panel7.Name = "panel7";
            panel7.Size = new Size(120, 69);
            panel7.TabIndex = 50;
            // 
            // dataGridView_total_faturado_mes
            // 
            dataGridView_total_faturado_mes.AllowUserToAddRows = false;
            dataGridView_total_faturado_mes.AllowUserToDeleteRows = false;
            dataGridView_total_faturado_mes.AllowUserToOrderColumns = true;
            dataGridView_total_faturado_mes.AllowUserToResizeColumns = false;
            dataGridView_total_faturado_mes.AllowUserToResizeRows = false;
            dataGridView_total_faturado_mes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_total_faturado_mes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_total_faturado_mes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView_total_faturado_mes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView_total_faturado_mes.ColumnHeadersHeight = 27;
            dataGridView_total_faturado_mes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView_total_faturado_mes.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView_total_faturado_mes.Dock = DockStyle.Fill;
            dataGridView_total_faturado_mes.EnableHeadersVisualStyles = false;
            dataGridView_total_faturado_mes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_total_faturado_mes.Location = new Point(0, 0);
            dataGridView_total_faturado_mes.MultiSelect = false;
            dataGridView_total_faturado_mes.Name = "dataGridView_total_faturado_mes";
            dataGridView_total_faturado_mes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_total_faturado_mes.RowHeadersVisible = false;
            dataGridView_total_faturado_mes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_total_faturado_mes.Size = new Size(120, 69);
            dataGridView_total_faturado_mes.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(23, 25, 31);
            panel8.Controls.Add(dataGridView_produtos_mais_comprados_mes);
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(205, 91);
            panel8.Name = "panel8";
            panel8.Size = new Size(210, 169);
            panel8.TabIndex = 49;
            // 
            // dataGridView_produtos_mais_comprados_mes
            // 
            dataGridView_produtos_mais_comprados_mes.AllowUserToAddRows = false;
            dataGridView_produtos_mais_comprados_mes.AllowUserToDeleteRows = false;
            dataGridView_produtos_mais_comprados_mes.AllowUserToOrderColumns = true;
            dataGridView_produtos_mais_comprados_mes.AllowUserToResizeColumns = false;
            dataGridView_produtos_mais_comprados_mes.AllowUserToResizeRows = false;
            dataGridView_produtos_mais_comprados_mes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_produtos_mais_comprados_mes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos_mais_comprados_mes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView_produtos_mais_comprados_mes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView_produtos_mais_comprados_mes.ColumnHeadersHeight = 27;
            dataGridView_produtos_mais_comprados_mes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.Control;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridView_produtos_mais_comprados_mes.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridView_produtos_mais_comprados_mes.Dock = DockStyle.Fill;
            dataGridView_produtos_mais_comprados_mes.EnableHeadersVisualStyles = false;
            dataGridView_produtos_mais_comprados_mes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos_mais_comprados_mes.Location = new Point(0, 0);
            dataGridView_produtos_mais_comprados_mes.MultiSelect = false;
            dataGridView_produtos_mais_comprados_mes.Name = "dataGridView_produtos_mais_comprados_mes";
            dataGridView_produtos_mais_comprados_mes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_produtos_mais_comprados_mes.RowHeadersVisible = false;
            dataGridView_produtos_mais_comprados_mes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_produtos_mais_comprados_mes.Size = new Size(210, 169);
            dataGridView_produtos_mais_comprados_mes.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(23, 25, 31);
            panel9.Controls.Add(dataGridView_melhores_compreadores_mes);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(12, 91);
            panel9.Name = "panel9";
            panel9.Size = new Size(187, 169);
            panel9.TabIndex = 48;
            // 
            // dataGridView_melhores_compreadores_mes
            // 
            dataGridView_melhores_compreadores_mes.AllowUserToAddRows = false;
            dataGridView_melhores_compreadores_mes.AllowUserToDeleteRows = false;
            dataGridView_melhores_compreadores_mes.AllowUserToOrderColumns = true;
            dataGridView_melhores_compreadores_mes.AllowUserToResizeColumns = false;
            dataGridView_melhores_compreadores_mes.AllowUserToResizeRows = false;
            dataGridView_melhores_compreadores_mes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_melhores_compreadores_mes.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_melhores_compreadores_mes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView_melhores_compreadores_mes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView_melhores_compreadores_mes.ColumnHeadersHeight = 27;
            dataGridView_melhores_compreadores_mes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.Control;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView_melhores_compreadores_mes.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView_melhores_compreadores_mes.Dock = DockStyle.Fill;
            dataGridView_melhores_compreadores_mes.EnableHeadersVisualStyles = false;
            dataGridView_melhores_compreadores_mes.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_melhores_compreadores_mes.Location = new Point(0, 0);
            dataGridView_melhores_compreadores_mes.MultiSelect = false;
            dataGridView_melhores_compreadores_mes.Name = "dataGridView_melhores_compreadores_mes";
            dataGridView_melhores_compreadores_mes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_melhores_compreadores_mes.RowHeadersVisible = false;
            dataGridView_melhores_compreadores_mes.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_melhores_compreadores_mes.Size = new Size(187, 169);
            dataGridView_melhores_compreadores_mes.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(439, 56);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 52;
            label3.Text = "Total Faturado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(205, 56);
            label4.Name = "label4";
            label4.Size = new Size(210, 21);
            label4.TabIndex = 51;
            label4.Text = "Produtos mais Comprados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(12, 56);
            label5.Name = "label5";
            label5.Size = new Size(187, 21);
            label5.TabIndex = 50;
            label5.Text = "Melhores Compradores";
            // 
            // label_titulo_mes
            // 
            label_titulo_mes.AutoSize = true;
            label_titulo_mes.BackColor = Color.Transparent;
            label_titulo_mes.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titulo_mes.ForeColor = Color.Transparent;
            label_titulo_mes.Location = new Point(78, 14);
            label_titulo_mes.Name = "label_titulo_mes";
            label_titulo_mes.Size = new Size(233, 30);
            label_titulo_mes.TabIndex = 50;
            label_titulo_mes.Text = "Lucro e Estatisticas de ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(180, 91);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 53;
            label6.Text = "Anos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(177, 148);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 54;
            label7.Text = "Meses";
            // 
            // Lucro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 51);
            ClientSize = new Size(991, 791);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Panel12);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(comboBox_anos);
            Controls.Add(pictureBox_aviso_encomendas);
            Controls.Add(label_linha);
            Controls.Add(label_encomendas);
            Name = "Lucro";
            Text = "Form1";
            Load += Lucro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_encomendas).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Mes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_total_faturado).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos_mais_comprados).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_melhores_compreadores).EndInit();
            Panel12.ResumeLayout(false);
            Panel12.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_total_faturado_mes).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos_mais_comprados_mes).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_melhores_compreadores_mes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox_aviso_encomendas;
        private Label label_linha;
        private Label label_encomendas;
        private ComboBox comboBox_anos;
        private Panel panel2;
        private DataGridView dataGridView_Mes;
        private Panel panel1;
        private Label label_titulo_ano;
        private Label label2;
        private Label label1;
        private Label label10;
        private Panel panel5;
        private DataGridView dataGridView_total_faturado;
        private Panel panel4;
        private DataGridView dataGridView_produtos_mais_comprados;
        private Panel panel3;
        private DataGridView dataGridView_melhores_compreadores;
        private Panel Panel12;
        private Panel panel7;
        private DataGridView dataGridView_total_faturado_mes;
        private Panel panel8;
        private DataGridView dataGridView_produtos_mais_comprados_mes;
        private Panel panel9;
        private DataGridView dataGridView_melhores_compreadores_mes;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label_titulo_mes;
        private Label label6;
        private Label label7;
    }
}