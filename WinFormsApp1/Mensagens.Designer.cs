﻿namespace WinFormsApp1
{
    partial class Mensagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensagens));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel_mensagens = new Panel();
            panel_assuntos = new Panel();
            label3 = new Label();
            comboBox_assunto = new ComboBox();
            label = new Label();
            label_encomendas = new Label();
            label_linha = new Label();
            comboBox_clientes = new ComboBox();
            label2 = new Label();
            pictureBox_aviso_encomendas = new PictureBox();
            label1 = new Label();
            comboBox_mes = new ComboBox();
            label6 = new Label();
            comboBox_anos = new ComboBox();
            tabPage2 = new TabPage();
            label9 = new Label();
            panel_editar_assuntos = new Panel();
            label_msg_erro = new Label();
            label11 = new Label();
            pictureBox_icon_confirmar = new PictureBox();
            label12 = new Label();
            textBox_nome_Assunto = new TextBox();
            pictureBox_icon_limpar = new PictureBox();
            pictureBox_icon_aviso = new PictureBox();
            label10 = new Label();
            label5 = new Label();
            panel_grafico = new Panel();
            dataGridView_assuntos = new DataGridView();
            panel_config = new Panel();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel_assuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_encomendas).BeginInit();
            tabPage2.SuspendLayout();
            panel_editar_assuntos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_confirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_limpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_aviso).BeginInit();
            panel_grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_assuntos).BeginInit();
            panel_config.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-40, -31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1237, 936);
            tabControl1.TabIndex = 66;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(46, 49, 51);
            tabPage1.Controls.Add(panel_mensagens);
            tabPage1.Controls.Add(panel_assuntos);
            tabPage1.Controls.Add(comboBox_assunto);
            tabPage1.Controls.Add(label);
            tabPage1.Controls.Add(label_encomendas);
            tabPage1.Controls.Add(label_linha);
            tabPage1.Controls.Add(comboBox_clientes);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(pictureBox_aviso_encomendas);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBox_mes);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(comboBox_anos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1229, 908);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // panel_mensagens
            // 
            panel_mensagens.BackColor = Color.FromArgb(23, 25, 31);
            panel_mensagens.Location = new Point(162, 238);
            panel_mensagens.Name = "panel_mensagens";
            panel_mensagens.Size = new Size(700, 492);
            panel_mensagens.TabIndex = 80;
            // 
            // panel_assuntos
            // 
            panel_assuntos.BackColor = Color.FromArgb(23, 25, 31);
            panel_assuntos.Controls.Add(label3);
            panel_assuntos.Cursor = Cursors.Hand;
            panel_assuntos.Location = new Point(267, 52);
            panel_assuntos.Name = "panel_assuntos";
            panel_assuntos.Size = new Size(166, 38);
            panel_assuntos.TabIndex = 79;
            panel_assuntos.Click += panel_assuntos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(12, 7);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 80;
            label3.Text = "Configurar      ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += panel_assuntos_Click;
            // 
            // comboBox_assunto
            // 
            comboBox_assunto.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_assunto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_assunto.ForeColor = Color.FromArgb(23, 25, 31);
            comboBox_assunto.FormattingEnabled = true;
            comboBox_assunto.Location = new Point(675, 178);
            comboBox_assunto.Name = "comboBox_assunto";
            comboBox_assunto.Size = new Size(187, 23);
            comboBox_assunto.TabIndex = 77;
            comboBox_assunto.SelectedIndexChanged += FazerMensagens;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.Transparent;
            label.Location = new Point(735, 154);
            label.Name = "label";
            label.Size = new Size(78, 21);
            label.TabIndex = 78;
            label.Text = "Assuntos";
            // 
            // label_encomendas
            // 
            label_encomendas.AutoSize = true;
            label_encomendas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_encomendas.ForeColor = Color.White;
            label_encomendas.Location = new Point(65, 52);
            label_encomendas.Name = "label_encomendas";
            label_encomendas.Size = new Size(161, 37);
            label_encomendas.TabIndex = 67;
            label_encomendas.Text = "Mensagens";
            // 
            // label_linha
            // 
            label_linha.AutoSize = true;
            label_linha.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha.Location = new Point(65, 31);
            label_linha.Name = "label_linha";
            label_linha.Size = new Size(137, 15);
            label_linha.TabIndex = 68;
            label_linha.Text = "__________________________";
            // 
            // comboBox_clientes
            // 
            comboBox_clientes.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_clientes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_clientes.ForeColor = Color.FromArgb(23, 25, 31);
            comboBox_clientes.FormattingEnabled = true;
            comboBox_clientes.Location = new Point(675, 128);
            comboBox_clientes.Name = "comboBox_clientes";
            comboBox_clientes.Size = new Size(187, 23);
            comboBox_clientes.TabIndex = 73;
            comboBox_clientes.SelectedIndexChanged += FazerMensagens;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(735, 104);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 76;
            label2.Text = "Clientes";
            // 
            // pictureBox_aviso_encomendas
            // 
            pictureBox_aviso_encomendas.Cursor = Cursors.Help;
            pictureBox_aviso_encomendas.Image = (Image)resources.GetObject("pictureBox_aviso_encomendas.Image");
            pictureBox_aviso_encomendas.Location = new Point(226, 64);
            pictureBox_aviso_encomendas.Name = "pictureBox_aviso_encomendas";
            pictureBox_aviso_encomendas.Size = new Size(24, 24);
            pictureBox_aviso_encomendas.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_aviso_encomendas.TabIndex = 69;
            pictureBox_aviso_encomendas.TabStop = false;
            pictureBox_aviso_encomendas.Click += pictureBox_aviso_encomendas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(226, 154);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 75;
            label1.Text = "Meses";
            // 
            // comboBox_mes
            // 
            comboBox_mes.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_mes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_mes.Enabled = false;
            comboBox_mes.ForeColor = Color.FromArgb(23, 25, 31);
            comboBox_mes.FormattingEnabled = true;
            comboBox_mes.Location = new Point(162, 178);
            comboBox_mes.Name = "comboBox_mes";
            comboBox_mes.Size = new Size(187, 23);
            comboBox_mes.TabIndex = 72;
            comboBox_mes.SelectedIndexChanged += FazerMensagens;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(224, 104);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 74;
            label6.Text = "Anos";
            // 
            // comboBox_anos
            // 
            comboBox_anos.BackColor = Color.FromArgb(253, 156, 58);
            comboBox_anos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_anos.ForeColor = Color.FromArgb(23, 25, 31);
            comboBox_anos.FormattingEnabled = true;
            comboBox_anos.Location = new Point(162, 128);
            comboBox_anos.Name = "comboBox_anos";
            comboBox_anos.Size = new Size(187, 23);
            comboBox_anos.TabIndex = 70;
            comboBox_anos.SelectedIndexChanged += FazerMensagens;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(46, 49, 51);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(panel_editar_assuntos);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(panel_grafico);
            tabPage2.Controls.Add(panel_config);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1229, 908);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(499, 128);
            label9.Name = "label9";
            label9.Size = new Size(127, 21);
            label9.TabIndex = 96;
            label9.Text = "Editar Assuntos";
            // 
            // panel_editar_assuntos
            // 
            panel_editar_assuntos.BackColor = Color.FromArgb(23, 25, 31);
            panel_editar_assuntos.Controls.Add(label_msg_erro);
            panel_editar_assuntos.Controls.Add(label11);
            panel_editar_assuntos.Controls.Add(pictureBox_icon_confirmar);
            panel_editar_assuntos.Controls.Add(label12);
            panel_editar_assuntos.Controls.Add(textBox_nome_Assunto);
            panel_editar_assuntos.Controls.Add(pictureBox_icon_limpar);
            panel_editar_assuntos.Controls.Add(pictureBox_icon_aviso);
            panel_editar_assuntos.Controls.Add(label10);
            panel_editar_assuntos.Location = new Point(438, 152);
            panel_editar_assuntos.Name = "panel_editar_assuntos";
            panel_editar_assuntos.Size = new Size(332, 159);
            panel_editar_assuntos.TabIndex = 95;
            // 
            // label_msg_erro
            // 
            label_msg_erro.AutoSize = true;
            label_msg_erro.ForeColor = Color.Red;
            label_msg_erro.Location = new Point(12, 51);
            label_msg_erro.Name = "label_msg_erro";
            label_msg_erro.Size = new Size(0, 15);
            label_msg_erro.TabIndex = 97;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(253, 156, 58);
            label11.Location = new Point(12, -1);
            label11.Name = "label11";
            label11.Size = new Size(162, 15);
            label11.TabIndex = 98;
            label11.Text = "_______________________________";
            // 
            // pictureBox_icon_confirmar
            // 
            pictureBox_icon_confirmar.Cursor = Cursors.Help;
            pictureBox_icon_confirmar.Image = (Image)resources.GetObject("pictureBox_icon_confirmar.Image");
            pictureBox_icon_confirmar.Location = new Point(284, 17);
            pictureBox_icon_confirmar.Name = "pictureBox_icon_confirmar";
            pictureBox_icon_confirmar.Size = new Size(24, 24);
            pictureBox_icon_confirmar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_confirmar.TabIndex = 99;
            pictureBox_icon_confirmar.TabStop = false;
            pictureBox_icon_confirmar.Click += pictureBox_icon_confirmar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(7, 14);
            label12.Name = "label12";
            label12.Size = new Size(175, 30);
            label12.TabIndex = 97;
            label12.Text = "Alterar Assuntos";
            // 
            // textBox_nome_Assunto
            // 
            textBox_nome_Assunto.BackColor = Color.FromArgb(23, 25, 31);
            textBox_nome_Assunto.BorderStyle = BorderStyle.FixedSingle;
            textBox_nome_Assunto.ForeColor = Color.White;
            textBox_nome_Assunto.Location = new Point(158, 72);
            textBox_nome_Assunto.MaxLength = 30;
            textBox_nome_Assunto.Multiline = true;
            textBox_nome_Assunto.Name = "textBox_nome_Assunto";
            textBox_nome_Assunto.Size = new Size(150, 65);
            textBox_nome_Assunto.TabIndex = 98;
            // 
            // pictureBox_icon_limpar
            // 
            pictureBox_icon_limpar.Cursor = Cursors.Help;
            pictureBox_icon_limpar.Image = (Image)resources.GetObject("pictureBox_icon_limpar.Image");
            pictureBox_icon_limpar.Location = new Point(231, 17);
            pictureBox_icon_limpar.Name = "pictureBox_icon_limpar";
            pictureBox_icon_limpar.Size = new Size(24, 24);
            pictureBox_icon_limpar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_limpar.TabIndex = 98;
            pictureBox_icon_limpar.TabStop = false;
            pictureBox_icon_limpar.Click += pictureBox_icon_limpar_Click;
            // 
            // pictureBox_icon_aviso
            // 
            pictureBox_icon_aviso.Cursor = Cursors.Help;
            pictureBox_icon_aviso.Image = (Image)resources.GetObject("pictureBox_icon_aviso.Image");
            pictureBox_icon_aviso.Location = new Point(187, 17);
            pictureBox_icon_aviso.Name = "pictureBox_icon_aviso";
            pictureBox_icon_aviso.Size = new Size(24, 24);
            pictureBox_icon_aviso.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_aviso.TabIndex = 97;
            pictureBox_icon_aviso.TabStop = false;
            pictureBox_icon_aviso.Click += pictureBox_icon_aviso_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(8, 71);
            label10.Name = "label10";
            label10.Size = new Size(150, 21);
            label10.TabIndex = 97;
            label10.Text = "Nome do Assunto:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(239, 128);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 94;
            label5.Text = "Ver Assuntos";
            // 
            // panel_grafico
            // 
            panel_grafico.BackColor = Color.FromArgb(23, 25, 31);
            panel_grafico.Controls.Add(dataGridView_assuntos);
            panel_grafico.Cursor = Cursors.Hand;
            panel_grafico.Location = new Point(207, 152);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(176, 589);
            panel_grafico.TabIndex = 93;
            // 
            // dataGridView_assuntos
            // 
            dataGridView_assuntos.AllowUserToAddRows = false;
            dataGridView_assuntos.AllowUserToDeleteRows = false;
            dataGridView_assuntos.AllowUserToOrderColumns = true;
            dataGridView_assuntos.AllowUserToResizeColumns = false;
            dataGridView_assuntos.AllowUserToResizeRows = false;
            dataGridView_assuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_assuntos.BackgroundColor = Color.FromArgb(23, 25, 31);
            dataGridView_assuntos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_assuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_assuntos.ColumnHeadersHeight = 27;
            dataGridView_assuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_assuntos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_assuntos.Dock = DockStyle.Fill;
            dataGridView_assuntos.EnableHeadersVisualStyles = false;
            dataGridView_assuntos.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_assuntos.Location = new Point(0, 0);
            dataGridView_assuntos.MultiSelect = false;
            dataGridView_assuntos.Name = "dataGridView_assuntos";
            dataGridView_assuntos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_assuntos.RowHeadersVisible = false;
            dataGridView_assuntos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_assuntos.Size = new Size(176, 589);
            dataGridView_assuntos.TabIndex = 0;
            dataGridView_assuntos.CellClick += dataGridView_assuntos_CellClick;
            // 
            // panel_config
            // 
            panel_config.BackColor = Color.FromArgb(23, 25, 31);
            panel_config.Controls.Add(label4);
            panel_config.Cursor = Cursors.Hand;
            panel_config.Location = new Point(264, 51);
            panel_config.Name = "panel_config";
            panel_config.Size = new Size(166, 38);
            panel_config.TabIndex = 92;
            panel_config.Click += panel_assuntos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(12, 7);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 80;
            label4.Text = "Mensagens      ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += panel_assuntos_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 51);
            label7.Name = "label7";
            label7.Size = new Size(155, 37);
            label7.TabIndex = 81;
            label7.Text = "Configurar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(253, 156, 58);
            label8.Location = new Point(62, 30);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 82;
            label8.Text = "__________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Help;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(223, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 83;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Mensagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 51);
            ClientSize = new Size(991, 791);
            Controls.Add(tabControl1);
            Name = "Mensagens";
            Text = "Form1";
            Load += Mensagens_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel_assuntos.ResumeLayout(false);
            panel_assuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_encomendas).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel_editar_assuntos.ResumeLayout(false);
            panel_editar_assuntos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_confirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_limpar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_aviso).EndInit();
            panel_grafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_assuntos).EndInit();
            panel_config.ResumeLayout(false);
            panel_config.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label;
        private ComboBox comboBox_assunto;
        private Label label2;
        private Label label1;
        private Label label6;
        private ComboBox comboBox_clientes;
        private ComboBox comboBox_mes;
        private ComboBox comboBox_anos;
        private PictureBox pictureBox_aviso_encomendas;
        private Label label_linha;
        private Label label_encomendas;
        private Panel panel_assuntos;
        private Label label3;
        private Panel panel_mensagens;
        private Panel panel_config;
        private Label label4;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Panel panel_editar_assuntos;
        private Label label5;
        private Panel panel_grafico;
        private DataGridView dataGridView_assuntos;
        private TextBox textBox_nome_Assunto;
        private Label label10;
        private PictureBox pictureBox_icon_confirmar;
        private PictureBox pictureBox_icon_limpar;
        private PictureBox pictureBox_icon_aviso;
        private Label label11;
        private Label label12;
        private Label label_msg_erro;
    }
}