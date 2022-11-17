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
    public partial class Form3 : Form
    {
        Thread nt;
        public Form3()
        {
            InitializeComponent();
        }

        private void button_cadastrarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm(object? obj)
        {
            Application.Run(new Form1());
        }

        private void button_cadastrarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm2(object? obj)
        {
            Application.Run(new Form2());
        }

        private void button_consulta_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

        private void atualizarDataGrid()
        {

            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from clientes ");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_cpf.Text) || string.IsNullOrWhiteSpace(textBox_nome.Text))
            {
                MessageBox.Show("Preencha os campos para poder salvar os dados");
            }
            else
            {
                Cliente c = new Cliente();
                c.cpf = textBox_cpf.Text;
                c.nome = textBox_nome.Text;
                if (c.gravar())
                {
                    MessageBox.Show("Cliente salvo com sucesso");
                    textBox_cpf.Clear();
                    textBox_nome.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao tentar salvar cliente");
                }
            }
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
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Você quer mesmo deletar este cliente?", "Deletando cliente", buttons);
                if (result == DialogResult.Yes)
                {

                    int idCliente = int.Parse(textBox_deletar.Text);
                    string sqlTexto = "DELETE FROM clientes WHERE idClientes = @idCliente";
                    Banco b = new Banco();
                    SqlCommand comando = new SqlCommand(sqlTexto, b.abrirConexao());

                    comando.Parameters.AddWithValue("@idCliente", idCliente);
                    try
                    {
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

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from clientes " +
                "where nome = '" + textBox_filtrarCliente.Text + "'");
            dataGridView1.DataSource = dt;
            textBox_filtrarCliente.Clear();
        }
    }
}
