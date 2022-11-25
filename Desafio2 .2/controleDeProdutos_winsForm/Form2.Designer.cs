namespace controleDeProdutos_winsForm
{
    partial class Form2
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
            this.button_cadastrarCliente = new System.Windows.Forms.Button();
            this.button_cadastrarFornecedor = new System.Windows.Forms.Button();
            this.textBox_nomeProduto = new System.Windows.Forms.TextBox();
            this.textBox_tipo = new System.Windows.Forms.TextBox();
            this.textBox_idFornecedor = new System.Windows.Forms.TextBox();
            this.textBox_preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_gerarNota = new System.Windows.Forms.Button();
            this.textBox_deletar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_deletar = new System.Windows.Forms.Button();
            this.textBox_filtrarFornecedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.textBox_filtrarProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_produto = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_cadastrarCliente
            // 
            this.button_cadastrarCliente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cadastrarCliente.Location = new System.Drawing.Point(131, 3);
            this.button_cadastrarCliente.Name = "button_cadastrarCliente";
            this.button_cadastrarCliente.Size = new System.Drawing.Size(112, 39);
            this.button_cadastrarCliente.TabIndex = 0;
            this.button_cadastrarCliente.Text = "Cadastrar cliente";
            this.button_cadastrarCliente.UseVisualStyleBackColor = true;
            this.button_cadastrarCliente.Click += new System.EventHandler(this.button_cadastrarCliente_Click);
            // 
            // button_cadastrarFornecedor
            // 
            this.button_cadastrarFornecedor.ForeColor = System.Drawing.Color.Red;
            this.button_cadastrarFornecedor.Location = new System.Drawing.Point(0, 3);
            this.button_cadastrarFornecedor.Name = "button_cadastrarFornecedor";
            this.button_cadastrarFornecedor.Size = new System.Drawing.Size(125, 39);
            this.button_cadastrarFornecedor.TabIndex = 1;
            this.button_cadastrarFornecedor.Text = "Cadastrar fornecedor";
            this.button_cadastrarFornecedor.UseVisualStyleBackColor = true;
            this.button_cadastrarFornecedor.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_nomeProduto
            // 
            this.textBox_nomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeProduto.Location = new System.Drawing.Point(25, 78);
            this.textBox_nomeProduto.Name = "textBox_nomeProduto";
            this.textBox_nomeProduto.Size = new System.Drawing.Size(100, 23);
            this.textBox_nomeProduto.TabIndex = 2;
            // 
            // textBox_tipo
            // 
            this.textBox_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tipo.Location = new System.Drawing.Point(25, 188);
            this.textBox_tipo.Name = "textBox_tipo";
            this.textBox_tipo.Size = new System.Drawing.Size(100, 23);
            this.textBox_tipo.TabIndex = 3;
            // 
            // textBox_idFornecedor
            // 
            this.textBox_idFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_idFornecedor.Location = new System.Drawing.Point(25, 250);
            this.textBox_idFornecedor.Name = "textBox_idFornecedor";
            this.textBox_idFornecedor.Size = new System.Drawing.Size(100, 23);
            this.textBox_idFornecedor.TabIndex = 4;
            // 
            // textBox_preco
            // 
            this.textBox_preco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_preco.Location = new System.Drawing.Point(25, 131);
            this.textBox_preco.Name = "textBox_preco";
            this.textBox_preco.Size = new System.Drawing.Size(100, 23);
            this.textBox_preco.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID do fornecedor";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(35, 300);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 10;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Produtos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fornecedores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_gerarNota
            // 
            this.button_gerarNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_gerarNota.Location = new System.Drawing.Point(249, 3);
            this.button_gerarNota.Name = "button_gerarNota";
            this.button_gerarNota.Size = new System.Drawing.Size(105, 41);
            this.button_gerarNota.TabIndex = 16;
            this.button_gerarNota.Text = "Gerar nota";
            this.button_gerarNota.UseVisualStyleBackColor = true;
            this.button_gerarNota.Click += new System.EventHandler(this.button_gerarNota_Click);
            // 
            // textBox_deletar
            // 
            this.textBox_deletar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_deletar.Location = new System.Drawing.Point(56, 403);
            this.textBox_deletar.Name = "textBox_deletar";
            this.textBox_deletar.Size = new System.Drawing.Size(74, 23);
            this.textBox_deletar.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(12, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Escreva um id de produto para deletar";
            // 
            // button_deletar
            // 
            this.button_deletar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_deletar.Location = new System.Drawing.Point(55, 436);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 17;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // textBox_filtrarFornecedor
            // 
            this.textBox_filtrarFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtrarFornecedor.Location = new System.Drawing.Point(273, 344);
            this.textBox_filtrarFornecedor.Name = "textBox_filtrarFornecedor";
            this.textBox_filtrarFornecedor.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrarFornecedor.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(251, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID do fornecedor para pesquisa";
            // 
            // button_filtrar
            // 
            this.button_filtrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrar.Location = new System.Drawing.Point(289, 368);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(94, 31);
            this.button_filtrar.TabIndex = 20;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // textBox_filtrarProduto
            // 
            this.textBox_filtrarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtrarProduto.Location = new System.Drawing.Point(273, 131);
            this.textBox_filtrarProduto.Name = "textBox_filtrarProduto";
            this.textBox_filtrarProduto.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrarProduto.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(251, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID do produto para pesquisa";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button_produto
            // 
            this.button_produto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_produto.Location = new System.Drawing.Point(289, 163);
            this.button_produto.Name = "button_produto";
            this.button_produto.Size = new System.Drawing.Size(94, 28);
            this.button_produto.TabIndex = 25;
            this.button_produto.Text = "Filtrar";
            this.button_produto.UseVisualStyleBackColor = true;
            this.button_produto.Click += new System.EventHandler(this.button_produto_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(446, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 140);
            this.listView1.TabIndex = 26;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID produto";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Preço";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tipo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID fornecedor";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nome do produto";
            this.columnHeader7.Width = 100;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(450, 282);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(237, 148);
            this.listView2.TabIndex = 27;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID fornecedor";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 293);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 111);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(230, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 151);
            this.panel3.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(249, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 152);
            this.panel4.TabIndex = 55;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 561);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_produto);
            this.Controls.Add(this.textBox_filtrarProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_filtrarFornecedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.textBox_deletar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_gerarNota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_preco);
            this.Controls.Add(this.textBox_idFornecedor);
            this.Controls.Add(this.textBox_tipo);
            this.Controls.Add(this.textBox_nomeProduto);
            this.Controls.Add(this.button_cadastrarFornecedor);
            this.Controls.Add(this.button_cadastrarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form2";
            this.Text = "Cadastro de produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_cadastrarCliente;
        private Button button_cadastrarFornecedor;
        private TextBox textBox_nomeProduto;
        private TextBox textBox_tipo;
        private TextBox textBox_idFornecedor;
        private TextBox textBox_preco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_salvar;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button_gerarNota;
        private TextBox textBox_deletar;
        private Label label7;
        private Button button_deletar;
        private TextBox textBox_filtrarFornecedor;
        private Label label8;
        private Button button_filtrar;
        private TextBox textBox_filtrarProduto;
        private Label label9;
        private Button button_produto;
        private ListView listView1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}