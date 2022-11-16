using System.Data;
using System.Data.SqlClient;
using System.Threading;
namespace controleDeProdutos_winsForm
{
    public partial class Form1 : Form
    {
        Thread nt;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_cadastrarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm(object? obj)
        {
            Application.Run(new Form2());
        }



        private void novoForm2(object? obj)
        {
            Application.Run(new Form3());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_cadastrarCliente_Click_1(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }



        private void atualizarDataGrid()
        {

            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from fornecedores ");
            dataGridView1.DataSource = dt;
        }



        private void button_salvarFornecedor_Click(object sender, EventArgs e)
        {
            if (textBox_nomeFornecedor.Text == "" || textBox_nomeFornecedor.Text == null)
            {
                MessageBox.Show("Insira um nome para o fornecedor");
            }
            else
            {
                Fornecedores f = new Fornecedores();
                f.nome = textBox_nomeFornecedor.Text;
                if (f.gravar())
                {
                    MessageBox.Show("Fornecedor inserido com sucesso");
                    textBox_nomeFornecedor.Clear();

                };
            }
        }

        private void button_consultarFornecedores_Click_1(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

        private void button_gerarNota_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm3(object? obj)
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


                int idFornecedor = int.Parse(textBox_deletar.Text);
                string sqlTexto = "DELETE FROM fornecedores WHERE idFornecedor = @idFornecedor";
                Banco b = new Banco();
                SqlCommand comando = new SqlCommand(sqlTexto, b.abrirConexao());
                
                comando.Parameters.AddWithValue("@idFornecedor", idFornecedor);
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
}