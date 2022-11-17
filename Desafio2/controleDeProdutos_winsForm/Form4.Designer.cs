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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CadastrarProduto
            // 
            this.button_CadastrarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_CadastrarProduto.Location = new System.Drawing.Point(152, 13);
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
            this.button_cadastrarFornecedor.Location = new System.Drawing.Point(6, 12);
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
            this.button_cadastrarCliente.Location = new System.Drawing.Point(276, 14);
            this.button_cadastrarCliente.Name = "button_cadastrarCliente";
            this.button_cadastrarCliente.Size = new System.Drawing.Size(112, 39);
            this.button_cadastrarCliente.TabIndex = 17;
            this.button_cadastrarCliente.Text = "Cadastrar cliente";
            this.button_cadastrarCliente.UseVisualStyleBackColor = true;
            this.button_cadastrarCliente.Click += new System.EventHandler(this.button_cadastrarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(371, 154);
            this.dataGridView1.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(417, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(371, 150);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 239);
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
            this.label2.Location = new System.Drawing.Point(584, 36);
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(417, 485);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(371, 150);
            this.dataGridView3.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 36;
            this.label7.Text = "Notas";
            // 
            // button_filtrarProduto
            // 
            this.button_filtrarProduto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrarProduto.Location = new System.Drawing.Point(272, 153);
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
            this.textBox_filtrarProduto.Location = new System.Drawing.Point(256, 121);
            this.textBox_filtrarProduto.Name = "textBox_filtrarProduto";
            this.textBox_filtrarProduto.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrarProduto.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(234, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Nome do produto para pesquisa";
            // 
            // textBox_filtrarCliente
            // 
            this.textBox_filtrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_filtrarCliente.Location = new System.Drawing.Point(256, 347);
            this.textBox_filtrarCliente.Name = "textBox_filtrarCliente";
            this.textBox_filtrarCliente.Size = new System.Drawing.Size(132, 23);
            this.textBox_filtrarCliente.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(234, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nome do cliente para pesquisa";
            // 
            // button_filtrarCliente
            // 
            this.button_filtrarCliente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_filtrarCliente.Location = new System.Drawing.Point(276, 385);
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
            this.button_filtrarNota.Location = new System.Drawing.Point(272, 570);
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
            this.textBox_FiltrarNota.Location = new System.Drawing.Point(256, 541);
            this.textBox_FiltrarNota.Name = "textBox_FiltrarNota";
            this.textBox_FiltrarNota.Size = new System.Drawing.Size(132, 23);
            this.textBox_FiltrarNota.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(256, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "ID da nota para pesquisa";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 653);
            this.Controls.Add(this.button_filtrarNota);
            this.Controls.Add(this.textBox_FiltrarNota);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_filtrarCliente);
            this.Controls.Add(this.textBox_filtrarCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_filtrarProduto);
            this.Controls.Add(this.textBox_filtrarProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
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
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_CadastrarProduto);
            this.Controls.Add(this.button_cadastrarFornecedor);
            this.Controls.Add(this.button_cadastrarCliente);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_CadastrarProduto;
        private Button button_cadastrarFornecedor;
        private Button button_cadastrarCliente;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
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
        private DataGridView dataGridView3;
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
    }
}