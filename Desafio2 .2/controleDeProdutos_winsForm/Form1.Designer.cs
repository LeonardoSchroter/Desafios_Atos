namespace controleDeProdutos_winsForm
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.button_cadastrarProduto = new System.Windows.Forms.Button();
            this.button_cadastrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_salvarFornecedor = new System.Windows.Forms.Button();
            this.textBox_nomeFornecedor = new System.Windows.Forms.TextBox();
            this.button_consultarFornecedores = new System.Windows.Forms.Button();
            this.button_gerarNota = new System.Windows.Forms.Button();
            this.button_deletar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_deletar = new System.Windows.Forms.TextBox();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.textBox_filtrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_cadastrarProduto
            // 
            this.button_cadastrarProduto.ForeColor = System.Drawing.Color.Red;
            this.button_cadastrarProduto.Location = new System.Drawing.Point(-1, 0);
            this.button_cadastrarProduto.Name = "button_cadastrarProduto";
            this.button_cadastrarProduto.Size = new System.Drawing.Size(103, 43);
            this.button_cadastrarProduto.TabIndex = 0;
            this.button_cadastrarProduto.Text = "Cadastrar produto";
            this.button_cadastrarProduto.UseVisualStyleBackColor = true;
            this.button_cadastrarProduto.Click += new System.EventHandler(this.button_cadastrarProduto_Click);
            // 
            // button_cadastrarCliente
            // 
            this.button_cadastrarCliente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cadastrarCliente.Location = new System.Drawing.Point(108, 0);
            this.button_cadastrarCliente.Name = "button_cadastrarCliente";
            this.button_cadastrarCliente.Size = new System.Drawing.Size(105, 43);
            this.button_cadastrarCliente.TabIndex = 1;
            this.button_cadastrarCliente.Text = "Cadastrar cliente";
            this.button_cadastrarCliente.UseVisualStyleBackColor = true;
            this.button_cadastrarCliente.Click += new System.EventHandler(this.button_cadastrarCliente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do fornecedor";
            // 
            // button_salvarFornecedor
            // 
            this.button_salvarFornecedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_salvarFornecedor.Location = new System.Drawing.Point(55, 110);
            this.button_salvarFornecedor.Name = "button_salvarFornecedor";
            this.button_salvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.button_salvarFornecedor.TabIndex = 3;
            this.button_salvarFornecedor.Text = "Salvar";
            this.button_salvarFornecedor.UseVisualStyleBackColor = true;
            this.button_salvarFornecedor.Click += new System.EventHandler(this.button_salvarFornecedor_Click);
            // 
            // textBox_nomeFornecedor
            // 
            this.textBox_nomeFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nomeFornecedor.Location = new System.Drawing.Point(126, 70);
            this.textBox_nomeFornecedor.Name = "textBox_nomeFornecedor";
            this.textBox_nomeFornecedor.Size = new System.Drawing.Size(132, 23);
            this.textBox_nomeFornecedor.TabIndex = 4;
            // 
            // button_consultarFornecedores
            // 
            this.button_consultarFornecedores.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_consultarFornecedores.Location = new System.Drawing.Point(411, 128);
            this.button_consultarFornecedores.Name = "button_consultarFornecedores";
            this.button_consultarFornecedores.Size = new System.Drawing.Size(82, 31);
            this.button_consultarFornecedores.TabIndex = 6;
            this.button_consultarFornecedores.Text = "Consultar";
            this.button_consultarFornecedores.UseVisualStyleBackColor = true;
            this.button_consultarFornecedores.Click += new System.EventHandler(this.button_consultarFornecedores_Click_1);
            // 
            // button_gerarNota
            // 
            this.button_gerarNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_gerarNota.Location = new System.Drawing.Point(224, 0);
            this.button_gerarNota.Name = "button_gerarNota";
            this.button_gerarNota.Size = new System.Drawing.Size(105, 43);
            this.button_gerarNota.TabIndex = 7;
            this.button_gerarNota.Text = "Gerar nota";
            this.button_gerarNota.UseVisualStyleBackColor = true;
            this.button_gerarNota.Click += new System.EventHandler(this.button_gerarNota_Click);
            // 
            // button_deletar
            // 
            this.button_deletar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_deletar.Location = new System.Drawing.Point(45, 234);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 8;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(2, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Escreva um id de fornecedor para deletar";
            // 
            // textBox_deletar
            // 
            this.textBox_deletar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_deletar.Location = new System.Drawing.Point(46, 201);
            this.textBox_deletar.Name = "textBox_deletar";
            this.textBox_deletar.Size = new System.Drawing.Size(74, 23);
            this.textBox_deletar.TabIndex = 10;
            // 
            // button_filtrar
            // 
            this.button_filtrar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrar.Location = new System.Drawing.Point(311, 128);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(94, 31);
            this.button_filtrar.TabIndex = 11;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // textBox_filtrar
            // 
            this.textBox_filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtrar.Location = new System.Drawing.Point(333, 83);
            this.textBox_filtrar.Name = "textBox_filtrar";
            this.textBox_filtrar.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(322, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID do fornecedor para pesquisa";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(290, 201);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(203, 148);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID fornecedor";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 84);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(2, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 102);
            this.panel2.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(272, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 311);
            this.panel3.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 361);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox_filtrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.textBox_deletar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_gerarNota);
            this.Controls.Add(this.button_consultarFornecedores);
            this.Controls.Add(this.textBox_nomeFornecedor);
            this.Controls.Add(this.button_salvarFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cadastrarCliente);
            this.Controls.Add(this.button_cadastrarProduto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "Cadastro de fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Button button_salvarFornecedor;
        private Button button_cadastrarProduto;
        private Button button_cadastrarCliente;
        private Label label1;
        private TextBox textBox_nomeFornecedor;
        private Button button_consultarFornecedores;
        private Button button_gerarNota;
        private Button button_deletar;
        private Label label2;
        private TextBox textBox_deletar;
        private Button button_filtrar;
        private TextBox textBox_filtrar;
        private Label label3;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}