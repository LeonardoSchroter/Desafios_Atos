namespace controleDeProdutos_winsForm
{
    partial class Form3
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
            this.button_cadastrarFornecedor = new System.Windows.Forms.Button();
            this.button_cadastrarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_cpf = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_consulta = new System.Windows.Forms.Button();
            this.button_gerarNota = new System.Windows.Forms.Button();
            this.textBox_deletar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cadastrarFornecedor
            // 
            this.button_cadastrarFornecedor.ForeColor = System.Drawing.Color.Red;
            this.button_cadastrarFornecedor.Location = new System.Drawing.Point(7, 12);
            this.button_cadastrarFornecedor.Name = "button_cadastrarFornecedor";
            this.button_cadastrarFornecedor.Size = new System.Drawing.Size(125, 39);
            this.button_cadastrarFornecedor.TabIndex = 3;
            this.button_cadastrarFornecedor.Text = "Cadastrar fornecedor";
            this.button_cadastrarFornecedor.UseVisualStyleBackColor = true;
            this.button_cadastrarFornecedor.Click += new System.EventHandler(this.button_cadastrarFornecedor_Click);
            // 
            // button_cadastrarProduto
            // 
            this.button_cadastrarProduto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_cadastrarProduto.Location = new System.Drawing.Point(138, 12);
            this.button_cadastrarProduto.Name = "button_cadastrarProduto";
            this.button_cadastrarProduto.Size = new System.Drawing.Size(112, 39);
            this.button_cadastrarProduto.TabIndex = 2;
            this.button_cadastrarProduto.Text = "Cadastrar produto";
            this.button_cadastrarProduto.UseVisualStyleBackColor = true;
            this.button_cadastrarProduto.Click += new System.EventHandler(this.button_cadastrarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nome.Location = new System.Drawing.Point(93, 140);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 23);
            this.textBox_nome.TabIndex = 7;
            // 
            // textBox_cpf
            // 
            this.textBox_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cpf.Location = new System.Drawing.Point(93, 100);
            this.textBox_cpf.Name = "textBox_cpf";
            this.textBox_cpf.Size = new System.Drawing.Size(100, 23);
            this.textBox_cpf.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(311, 214);
            this.dataGridView1.TabIndex = 9;
            // 
            // button_consulta
            // 
            this.button_consulta.Location = new System.Drawing.Point(348, 83);
            this.button_consulta.Name = "button_consulta";
            this.button_consulta.Size = new System.Drawing.Size(90, 40);
            this.button_consulta.TabIndex = 10;
            this.button_consulta.Text = "Consulta";
            this.button_consulta.UseVisualStyleBackColor = true;
            this.button_consulta.Click += new System.EventHandler(this.button_consulta_Click);
            // 
            // button_gerarNota
            // 
            this.button_gerarNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_gerarNota.Location = new System.Drawing.Point(256, 12);
            this.button_gerarNota.Name = "button_gerarNota";
            this.button_gerarNota.Size = new System.Drawing.Size(103, 39);
            this.button_gerarNota.TabIndex = 11;
            this.button_gerarNota.Text = "Gerar nota";
            this.button_gerarNota.UseVisualStyleBackColor = true;
            this.button_gerarNota.Click += new System.EventHandler(this.button_gerarNota_Click);
            // 
            // textBox_deletar
            // 
            this.textBox_deletar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_deletar.Location = new System.Drawing.Point(52, 294);
            this.textBox_deletar.Name = "textBox_deletar";
            this.textBox_deletar.Size = new System.Drawing.Size(74, 23);
            this.textBox_deletar.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(8, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Escreva um id de cliente para deletar";
            // 
            // button_deletar
            // 
            this.button_deletar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button_deletar.Location = new System.Drawing.Point(51, 327);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(75, 23);
            this.button_deletar.TabIndex = 12;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = true;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 387);
            this.Controls.Add(this.textBox_deletar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.button_gerarNota);
            this.Controls.Add(this.button_consulta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_cpf);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cadastrarFornecedor);
            this.Controls.Add(this.button_cadastrarProduto);
            this.Name = "Form3";
            this.Text = "Cadastro de cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_cadastrarFornecedor;
        private Button button_cadastrarProduto;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox_nome;
        private TextBox textBox_cpf;
        private DataGridView dataGridView1;
        private Button button_consulta;
        private Button button_gerarNota;
        private TextBox textBox_deletar;
        private Label label3;
        private Button button_deletar;
    }
}