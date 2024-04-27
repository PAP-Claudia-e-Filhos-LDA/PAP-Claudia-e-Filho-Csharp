namespace WinFormsApp1
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label_msg_erro = new Label();
            pictureBox_icon_confirmar = new PictureBox();
            pictureBox_icon_limpar = new PictureBox();
            pictureBox_imagem = new PictureBox();
            button_add_imagem = new Button();
            textBox_desc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox_preço = new TextBox();
            label4 = new Label();
            textBox_nome_produto = new TextBox();
            label3 = new Label();
            pictureBox_icon_aviso = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel_clientes = new Panel();
            label_num_produtos = new Label();
            label_linha_dashboard_clientes = new Label();
            label_dashboard_clientes = new Label();
            pictureBox_dashboard_icon_produtos = new PictureBox();
            pictureBox_aviso_produtos = new PictureBox();
            panel_grafico = new Panel();
            dataGridView_produtos = new DataGridView();
            label_linha = new Label();
            label_produtos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_confirmar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_limpar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_aviso).BeginInit();
            panel_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_produtos).BeginInit();
            panel_grafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 25, 31);
            panel1.Controls.Add(label_msg_erro);
            panel1.Controls.Add(pictureBox_icon_confirmar);
            panel1.Controls.Add(pictureBox_icon_limpar);
            panel1.Controls.Add(pictureBox_imagem);
            panel1.Controls.Add(button_add_imagem);
            panel1.Controls.Add(textBox_desc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_preço);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_nome_produto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox_icon_aviso);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(678, 298);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 463);
            panel1.TabIndex = 27;
            // 
            // label_msg_erro
            // 
            label_msg_erro.AutoSize = true;
            label_msg_erro.ForeColor = Color.Red;
            label_msg_erro.Location = new Point(17, 45);
            label_msg_erro.Name = "label_msg_erro";
            label_msg_erro.Size = new Size(0, 15);
            label_msg_erro.TabIndex = 34;
            // 
            // pictureBox_icon_confirmar
            // 
            pictureBox_icon_confirmar.Cursor = Cursors.Help;
            pictureBox_icon_confirmar.Image = (Image)resources.GetObject("pictureBox_icon_confirmar.Image");
            pictureBox_icon_confirmar.Location = new Point(251, 15);
            pictureBox_icon_confirmar.Name = "pictureBox_icon_confirmar";
            pictureBox_icon_confirmar.Size = new Size(24, 24);
            pictureBox_icon_confirmar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_confirmar.TabIndex = 33;
            pictureBox_icon_confirmar.TabStop = false;
            pictureBox_icon_confirmar.Click += pictureBox_icon_confirmar_Click;
            // 
            // pictureBox_icon_limpar
            // 
            pictureBox_icon_limpar.Cursor = Cursors.Help;
            pictureBox_icon_limpar.Image = (Image)resources.GetObject("pictureBox_icon_limpar.Image");
            pictureBox_icon_limpar.Location = new Point(222, 15);
            pictureBox_icon_limpar.Name = "pictureBox_icon_limpar";
            pictureBox_icon_limpar.Size = new Size(24, 24);
            pictureBox_icon_limpar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_limpar.TabIndex = 32;
            pictureBox_icon_limpar.TabStop = false;
            pictureBox_icon_limpar.Click += pictureBox_icon_limpar_Click;
            // 
            // pictureBox_imagem
            // 
            pictureBox_imagem.Location = new Point(18, 303);
            pictureBox_imagem.Name = "pictureBox_imagem";
            pictureBox_imagem.Size = new Size(257, 151);
            pictureBox_imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_imagem.TabIndex = 31;
            pictureBox_imagem.TabStop = false;
            // 
            // button_add_imagem
            // 
            button_add_imagem.BackColor = Color.FromArgb(23, 25, 31);
            button_add_imagem.FlatAppearance.BorderColor = Color.FromArgb(46, 49, 51);
            button_add_imagem.FlatAppearance.BorderSize = 3;
            button_add_imagem.FlatStyle = FlatStyle.Flat;
            button_add_imagem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_add_imagem.ForeColor = Color.White;
            button_add_imagem.Location = new Point(8, 245);
            button_add_imagem.Name = "button_add_imagem";
            button_add_imagem.Size = new Size(267, 51);
            button_add_imagem.TabIndex = 30;
            button_add_imagem.Text = "Adicionar Imagem";
            button_add_imagem.UseVisualStyleBackColor = false;
            button_add_imagem.Click += button_add_imagem_Click;
            // 
            // textBox_desc
            // 
            textBox_desc.BackColor = Color.FromArgb(23, 25, 31);
            textBox_desc.BorderStyle = BorderStyle.FixedSingle;
            textBox_desc.ForeColor = Color.White;
            textBox_desc.Location = new Point(93, 133);
            textBox_desc.MaxLength = 300;
            textBox_desc.Multiline = true;
            textBox_desc.Name = "textBox_desc";
            textBox_desc.Size = new Size(165, 106);
            textBox_desc.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 130);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 28;
            label6.Text = "Descrição:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(104, 97);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 27;
            label5.Text = "€";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_preço
            // 
            textBox_preço.BackColor = Color.FromArgb(23, 25, 31);
            textBox_preço.BorderStyle = BorderStyle.FixedSingle;
            textBox_preço.ForeColor = Color.White;
            textBox_preço.Location = new Point(67, 97);
            textBox_preço.MaxLength = 5;
            textBox_preço.Name = "textBox_preço";
            textBox_preço.Size = new Size(36, 23);
            textBox_preço.TabIndex = 26;
            textBox_preço.KeyPress += textBox_preço_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(8, 96);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 25;
            label4.Text = "Preço:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_nome_produto
            // 
            textBox_nome_produto.BackColor = Color.FromArgb(23, 25, 31);
            textBox_nome_produto.BorderStyle = BorderStyle.FixedSingle;
            textBox_nome_produto.ForeColor = Color.White;
            textBox_nome_produto.Location = new Point(158, 67);
            textBox_nome_produto.MaxLength = 45;
            textBox_nome_produto.Name = "textBox_nome_produto";
            textBox_nome_produto.Size = new Size(100, 23);
            textBox_nome_produto.TabIndex = 24;
            textBox_nome_produto.KeyPress += textBox_nome_produto_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 66);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 23;
            label3.Text = "Nome do Produto:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_icon_aviso
            // 
            pictureBox_icon_aviso.Cursor = Cursors.Help;
            pictureBox_icon_aviso.Image = (Image)resources.GetObject("pictureBox_icon_aviso.Image");
            pictureBox_icon_aviso.Location = new Point(192, 15);
            pictureBox_icon_aviso.Name = "pictureBox_icon_aviso";
            pictureBox_icon_aviso.Size = new Size(24, 24);
            pictureBox_icon_aviso.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_icon_aviso.TabIndex = 22;
            pictureBox_icon_aviso.TabStop = false;
            pictureBox_icon_aviso.Click += pictureBox_icon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(253, 156, 58);
            label1.Location = new Point(22, -3);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 5;
            label1.Text = "_______________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(176, 30);
            label2.TabIndex = 4;
            label2.Text = "Alterar Produtos";
            // 
            // panel_clientes
            // 
            panel_clientes.BackColor = Color.FromArgb(23, 25, 31);
            panel_clientes.Controls.Add(label_num_produtos);
            panel_clientes.Controls.Add(label_linha_dashboard_clientes);
            panel_clientes.Controls.Add(label_dashboard_clientes);
            panel_clientes.Controls.Add(pictureBox_dashboard_icon_produtos);
            panel_clientes.Cursor = Cursors.Hand;
            panel_clientes.Location = new Point(678, 101);
            panel_clientes.Name = "panel_clientes";
            panel_clientes.Size = new Size(287, 160);
            panel_clientes.TabIndex = 24;
            // 
            // label_num_produtos
            // 
            label_num_produtos.AutoSize = true;
            label_num_produtos.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_num_produtos.ForeColor = Color.White;
            label_num_produtos.Location = new Point(83, 47);
            label_num_produtos.Name = "label_num_produtos";
            label_num_produtos.Size = new Size(74, 86);
            label_num_produtos.TabIndex = 3;
            label_num_produtos.Text = "0";
            // 
            // label_linha_dashboard_clientes
            // 
            label_linha_dashboard_clientes.AutoSize = true;
            label_linha_dashboard_clientes.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha_dashboard_clientes.Location = new Point(57, 2);
            label_linha_dashboard_clientes.Name = "label_linha_dashboard_clientes";
            label_linha_dashboard_clientes.Size = new Size(102, 15);
            label_linha_dashboard_clientes.TabIndex = 2;
            label_linha_dashboard_clientes.Text = "___________________";
            // 
            // label_dashboard_clientes
            // 
            label_dashboard_clientes.AutoSize = true;
            label_dashboard_clientes.BackColor = Color.Transparent;
            label_dashboard_clientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_dashboard_clientes.ForeColor = Color.Transparent;
            label_dashboard_clientes.Location = new Point(53, 15);
            label_dashboard_clientes.Name = "label_dashboard_clientes";
            label_dashboard_clientes.Size = new Size(119, 32);
            label_dashboard_clientes.TabIndex = 1;
            label_dashboard_clientes.Text = "Produtos";
            // 
            // pictureBox_dashboard_icon_produtos
            // 
            pictureBox_dashboard_icon_produtos.Image = (Image)resources.GetObject("pictureBox_dashboard_icon_produtos.Image");
            pictureBox_dashboard_icon_produtos.Location = new Point(17, 15);
            pictureBox_dashboard_icon_produtos.Name = "pictureBox_dashboard_icon_produtos";
            pictureBox_dashboard_icon_produtos.Size = new Size(32, 32);
            pictureBox_dashboard_icon_produtos.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_dashboard_icon_produtos.TabIndex = 0;
            pictureBox_dashboard_icon_produtos.TabStop = false;
            // 
            // pictureBox_aviso_produtos
            // 
            pictureBox_aviso_produtos.Cursor = Cursors.Help;
            pictureBox_aviso_produtos.Image = (Image)resources.GetObject("pictureBox_aviso_produtos.Image");
            pictureBox_aviso_produtos.Location = new Point(160, 51);
            pictureBox_aviso_produtos.Name = "pictureBox_aviso_produtos";
            pictureBox_aviso_produtos.Size = new Size(24, 24);
            pictureBox_aviso_produtos.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_aviso_produtos.TabIndex = 26;
            pictureBox_aviso_produtos.TabStop = false;
            pictureBox_aviso_produtos.Click += pictureBox_aviso_produtos_Click;
            // 
            // panel_grafico
            // 
            panel_grafico.BackColor = Color.FromArgb(23, 25, 31);
            panel_grafico.Controls.Add(dataGridView_produtos);
            panel_grafico.Cursor = Cursors.Hand;
            panel_grafico.Location = new Point(25, 101);
            panel_grafico.Name = "panel_grafico";
            panel_grafico.Size = new Size(617, 660);
            panel_grafico.TabIndex = 25;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_produtos.ColumnHeadersHeight = 27;
            dataGridView_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(23, 25, 31);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 156, 58);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_produtos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_produtos.Dock = DockStyle.Fill;
            dataGridView_produtos.EnableHeadersVisualStyles = false;
            dataGridView_produtos.GridColor = Color.FromArgb(23, 25, 31);
            dataGridView_produtos.Location = new Point(0, 0);
            dataGridView_produtos.MultiSelect = false;
            dataGridView_produtos.Name = "dataGridView_produtos";
            dataGridView_produtos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_produtos.RowHeadersVisible = false;
            dataGridView_produtos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView_produtos.Size = new Size(617, 660);
            dataGridView_produtos.TabIndex = 0;
            dataGridView_produtos.CellClick += dataGridView_produtos_CellContentClick;
            dataGridView_produtos.MouseDown += dataGridView_produtos_MouseDown;
            // 
            // label_linha
            // 
            label_linha.AutoSize = true;
            label_linha.ForeColor = Color.FromArgb(253, 156, 58);
            label_linha.Location = new Point(32, 30);
            label_linha.Name = "label_linha";
            label_linha.Size = new Size(112, 15);
            label_linha.TabIndex = 23;
            label_linha.Text = "_____________________";
            // 
            // label_produtos
            // 
            label_produtos.AutoSize = true;
            label_produtos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_produtos.ForeColor = Color.White;
            label_produtos.Location = new Point(25, 43);
            label_produtos.Name = "label_produtos";
            label_produtos.Size = new Size(135, 37);
            label_produtos.TabIndex = 22;
            label_produtos.Text = "Produtos";
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 49, 51);
            ClientSize = new Size(991, 791);
            Controls.Add(panel1);
            Controls.Add(panel_clientes);
            Controls.Add(pictureBox_aviso_produtos);
            Controls.Add(panel_grafico);
            Controls.Add(label_linha);
            Controls.Add(label_produtos);
            Name = "Produtos";
            Text = "Form1";
            Load += Produtos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_confirmar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_limpar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_imagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_icon_aviso).EndInit();
            panel_clientes.ResumeLayout(false);
            panel_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_dashboard_icon_produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_aviso_produtos).EndInit();
            panel_grafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_produtos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_melhores_clientes;
        private PictureBox pictureBox_icon_aviso;
        private Label label1;
        private Label label2;
        private Panel panel_clientes;
        private Label label_num_produtos;
        private Label label_linha_dashboard_clientes;
        private Label label_dashboard_clientes;
        private PictureBox pictureBox_dashboard_icon_produtos;
        private PictureBox pictureBox_aviso_produtos;
        private Panel panel_grafico;
        private DataGridView dataGridView_produtos;
        private Label label_linha;
        private Label label_produtos;
        private TextBox textBox_nome_produto;
        private Label label3;
        private TextBox textBox_desc;
        private Label label6;
        private Label label5;
        private TextBox textBox_preço;
        private Label label4;
        private Button button_add_imagem;
        private PictureBox pictureBox_imagem;
        private PictureBox pictureBox_icon_confirmar;
        private PictureBox pictureBox_icon_limpar;
        private Label label_msg_erro;
    }
}