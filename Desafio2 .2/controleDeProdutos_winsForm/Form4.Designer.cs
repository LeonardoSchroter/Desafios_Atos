namespace controleDeProdutos_winsForm
{
    partial class Form4
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
            this.button_CadastrarProduto = new System.Windows.Forms.Button();
            this.button_cadastrarFornecedor = new System.Windows.Forms.Button();
            this.button_cadastrarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_idDocliente = new System.Windows.Forms.TextBox();
            this.textBox_idDoProduto = new System.Windows.Forms.TextBox();
            this.textBox_quantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_consultar = new System.Windows.Forms.Button();
            this.textBox_deletar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_deletar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_filtrarProduto = new System.Windows.Forms.Button();
            this.textBox_filtrarProduto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_filtrarCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_filtrarCliente = new System.Windows.Forms.Button();
            this.button_filtrarNota = new System.Windows.Forms.Button();
            this.textBox_FiltrarNota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CadastrarProduto
            // 
            this.button_CadastrarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_CadastrarProduto.Location = new System.Drawing.Point(147, 5);
            this.button_CadastrarProduto.Name = "button_CadastrarProduto";
            this.button_CadastrarProduto.Size = new System.Drawing.Size(108, 38);
            this.button_CadastrarProduto.TabIndex = 19;
            this.button_CadastrarProduto.Text = "Cadastrar produto";
            this.button_CadastrarProduto.UseVisualStyleBackColor = true;
            this.button_CadastrarProduto.Click += new System.EventHandler(this.button_CadastrarProduto_Click_1);
            // 
            // button_cadastrarFornecedor
            // 
            this.button_cadastrarFornecedor.ForeColor = System.Drawing.Color.Red;
            this.button_cadastrarFornecedor.Location = new System.Drawing.Point(1, 4);
            this.button_cadastrarFornecedor.Name = "button_cadastrarFornecedor";
            this.button_cadastrarFornecedor.Size = new System.Drawing.Size(125, 39);
            this.button_cadastrarFornecedor.TabIndex = 18;
            this.button_cadastrarFornecedor.Text = "Cadastrar fornecedor";
            this.button_cadastrarFornecedor.UseVisualStyleBackColor = true;
            this.button_cadastrarFornecedor.Click += new System.EventHandler(this.button_cadastrarFornecedor_Click);
            // 
            // button_cadastrarCliente
            // 
            this.button_cadastrarCliente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cadastrarCliente.Location = new System.Drawing.Point(271, 6);
            this.button_cadastrarCliente.Name = "button_cadastrarCliente";
            this.button_cadastrarCliente.Size = new System.Drawing.Size(112, 39);
            this.button_cadastrarCliente.TabIndex = 17;
            this.button_cadastrarCliente.Text = "Cadastrar cliente";
            this.button_cadastrarCliente.UseVisualStyleBackColor = true;
            this.button_cadastrarCliente.Click += new System.EventHandler(this.button_cadastrarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Clientes";
            // 
            // button_salvar
            // 
            this.button_salvar.Location = new System.Drawing.Point(65, 256);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(75, 23);
            this.button_salvar.TabIndex = 23;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // textBox_idDocliente
            // 
            this.textBox_idDocliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_idDocliente.Location = new System.Drawing.Point(93, 75);
            this.textBox_idDocliente.Name = "textBox_idDocliente";
            this.textBox_idDocliente.Size = new System.Drawing.Size(47, 23);
            this.textBox_idDocliente.TabIndex = 24;
            // 
            // textBox_idDoProduto
            // 
            this.textBox_idDoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_idDoProduto.Location = new System.Drawing.Point(98, 139);
            this.textBox_idDoProduto.Name = "textBox_idDoProduto";
            this.textBox_idDoProduto.Size = new System.Drawing.Size(52, 23);
            this.textBox_idDoProduto.TabIndex = 25;
            // 
            // textBox_quantidade
            // 
            this.textBox_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_quantidade.Location = new System.Drawing.Point(134, 195);
            this.textBox_quantidade.Name = "textBox_quantidade";
            this.textBox_quantidade.Size = new System.Drawing.Size(47, 23);
            this.textBox_quantidade.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantidade comprada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID do produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID do cliente";
            // 
            // button_consultar
            // 
            this.button_consultar.Location = new System.Drawing.Point(820, 333);
            this.button_consultar.Name = "button_consultar";
            this.button_consultar.Size = new System.Drawing.Size(84, 47);
            this.button_consultar.TabIndex = 31;
            this.button_consultar.Text = "Consultar";
            this.button_consultar.UseVisualStyleBackColor = true;
            this.button_consultar.Click += new System.EventHandler(this.button_consultar_Click);
            // 
            // textBox_deletar
            // 
            this.textBox_deletar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_deletar.Location = new System.Drawing.Point(66, 466);
            this.textBox_deletar.Name = "textBox_deletar";
            this.textBox_deletar.Size = new System.Drawing.Size(74, 23);
            this.textBox_deletar.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(22, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Escreva um id de uma nota para deletar";
            // 
            // button_deletar
            // 
            this.button_deletar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_deletar.Location = new System.Drawing.Point(65, 499);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 32;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Notas";
            // 
            // button_filtrarProduto
            // 
            this.button_filtrarProduto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrarProduto.Location = new System.Drawing.Point(41, 105);
            this.button_filtrarProduto.Name = "button_filtrarProduto";
            this.button_filtrarProduto.Size = new System.Drawing.Size(94, 28);
            this.button_filtrarProduto.TabIndex = 39;
            this.button_filtrarProduto.Text = "Filtrar";
            this.button_filtrarProduto.UseVisualStyleBackColor = true;
            this.button_filtrarProduto.Click += new System.EventHandler(this.button_filtrarProduto_Click);
            // 
            // textBox_filtrarProduto
            // 
            this.textBox_filtrarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtrarProduto.Location = new System.Drawing.Point(23, 76);
            this.textBox_filtrarProduto.Name = "textBox_filtrarProduto";
            this.textBox_filtrarProduto.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrarProduto.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(14, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "ID do produto para pesquisa";
            // 
            // textBox_filtrarCliente
            // 
            this.textBox_filtrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtrarCliente.Location = new System.Drawing.Point(14, 78);
            this.textBox_filtrarCliente.Name = "textBox_filtrarCliente";
            this.textBox_filtrarCliente.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrarCliente.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "ID do cliente para pesquisa";
            // 
            // button_filtrarCliente
            // 
            this.button_filtrarCliente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrarCliente.Location = new System.Drawing.Point(32, 111);
            this.button_filtrarCliente.Name = "button_filtrarCliente";
            this.button_filtrarCliente.Size = new System.Drawing.Size(94, 28);
            this.button_filtrarCliente.TabIndex = 42;
            this.button_filtrarCliente.Text = "Filtrar";
            this.button_filtrarCliente.UseVisualStyleBackColor = true;
            this.button_filtrarCliente.Click += new System.EventHandler(this.button_filtrarCliente_Click);
            // 
            // button_filtrarNota
            // 
            this.button_filtrarNota.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrarNota.Location = new System.Drawing.Point(32, 107);
            this.button_filtrarNota.Name = "button_filtrarNota";
            this.button_filtrarNota.Size = new System.Drawing.Size(94, 28);
            this.button_filtrarNota.TabIndex = 45;
            this.button_filtrarNota.Text = "Filtrar";
            this.button_filtrarNota.UseVisualStyleBackColor = true;
            this.button_filtrarNota.Click += new System.EventHandler(this.button_filtrarNota_Click);
            // 
            // textBox_FiltrarNota
            // 
            this.textBox_FiltrarNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FiltrarNota.Location = new System.Drawing.Point(14, 78);
            this.textBox_FiltrarNota.Name = "textBox_FiltrarNota";
            this.textBox_FiltrarNota.Size = new System.Drawing.Size(132, 23);
            this.textBox_FiltrarNota.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "ID da nota para pesquisa";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(443, 239);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 192);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            this.columnHeader3.Width = 100;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(444, 46);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(370, 172);
            this.listView2.TabIndex = 47;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID produto";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Preço";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tipo";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID fornecedor";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nome do produto";
            this.columnHeader8.Width = 100;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(444, 461);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(370, 181);
            this.listView3.TabIndex = 48;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ID";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ID cliente";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID produto";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Quantidade";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Valor";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Codigo";
            this.columnHeader14.Width = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(6, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 229);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 145);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox_filtrarProduto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button_filtrarProduto);
            this.panel3.Location = new System.Drawing.Point(260, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 172);
            this.panel3.TabIndex = 51;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox_filtrarCliente);
            this.panel4.Controls.Add(this.button_filtrarCliente);
            this.panel4.Location = new System.Drawing.Point(269, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 201);
            this.panel4.TabIndex = 52;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.textBox_FiltrarNota);
            this.panel5.Controls.Add(this.button_filtrarNota);
            this.panel5.Location = new System.Drawing.Point(269, 461);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 189);
            this.panel5.TabIndex = 53;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 653);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_deletar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_consultar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_quantidade);
            this.Controls.Add(this.textBox_idDoProduto);
            this.Controls.Add(this.textBox_idDocliente);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CadastrarProduto);
            this.Controls.Add(this.button_cadastrarFornecedor);
            this.Controls.Add(this.button_cadastrarCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_CadastrarProduto;
        private Button button_cadastrarFornecedor;
        private Button button_cadastrarCliente;
        private Label label1;
        private Button button_salvar;
        private TextBox textBox_idDocliente;
        private TextBox textBox_idDoProduto;
        private TextBox textBox_quantidade;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_consultar;
        private TextBox textBox_deletar;
        private Label label6;
        private Button button_deletar;
        private Label label7;
        private Button button_filtrarProduto;
        private TextBox textBox_filtrarProduto;
        private Label label9;
        private TextBox textBox_filtrarCliente;
        private Label label8;
        private Button button_filtrarCliente;
        private Button button_filtrarNota;
        private TextBox textBox_FiltrarNota;
        private Label label10;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ListView listView2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView listView3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}