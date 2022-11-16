using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace controleDeProdutos_winsForm
{
    public partial class Form2 : Form
    {
        Thread nt;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form1());
        }

        private void button_cadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm2()
        {
            Application.Run(new Form3());
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_idFornecedor.Text) || string.IsNullOrWhiteSpace(textBox_nomeProduto.Text) || string.IsNullOrWhiteSpace(textBox_preco.Text) || string.IsNullOrWhiteSpace(textBox_tipo.Text))
            {
                MessageBox.Show("Insira as informações requisitadas");
            }
            else
            {
                Produto p = new Produto();
                p.preco = float.Parse(textBox_preco.Text);
                p.tipo = textBox_tipo.Text;
                p.idFornecedor = int.Parse(textBox_idFornecedor.Text);
                p.nome = textBox_nomeProduto.Text;

                if (p.gravar())
                {
                    MessageBox.Show("Produto salvo com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao salvar produto");

                }
            }
        }

        private void atualizarDataGrid()
        {

            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from fornecedores ");
            dataGridView1.DataSource = dt;



            dt = bd.executaConsulta("select * from produtos ");
            dataGridView2.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

        private void button_gerarNota_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm4);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm4(object? obj)
        {
            Application.Run(new Form4());
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_deletar.Text))
            {
                MessageBox.Show("Escreva algo para deletar");
            }
            else
            {
                int idProduto = int.Parse(textBox_deletar.Text);
                try
                {
                    string sqlTexto = "DELETE FROM produtos WHERE idProdutos = @idProduto";
                    Banco b = new Banco();
                    SqlCommand comando = new SqlCommand(sqlTexto, b.abrirConexao());
                    comando.Parameters.AddWithValue("@idProduto", idProduto);

                    //executar sentença SQL
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Deletado com sucesso");
                    textBox_deletar.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas para deletar");
                    throw;
                }
            }
        }
    }
}
