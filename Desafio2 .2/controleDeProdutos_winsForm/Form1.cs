using System.Data;
using System.Data.SqlClient;
using System.Threading;
using Microsoft.EntityFrameworkCore;

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



        private void atualizarListView()
        {
            try
            {
                listView1.Items.Clear();
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                List<Provider> lista = new List<Provider>();

                lista =(from Provider p in contexto.Providers select p).ToList();
                int i = 0;
                foreach(Provider p in lista)
                {
                    listView1.Items.Add(p.IdFornecedor.ToString());
                    listView1.Items[i].SubItems.Add(p.Nome.ToString());
                    i++;
                }
            }
            catch (Exception)
            {

                throw;
            }


        }



        private void button_salvarFornecedor_Click(object sender, EventArgs e)
        {
            if (textBox_nomeFornecedor.Text == "" || textBox_nomeFornecedor.Text == null)
            {
                MessageBox.Show("Insira um nome para o fornecedor");
            }
            else
            {
                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    Provider p = new Provider();
                    p.Nome = textBox_nomeFornecedor.Text;
                    contexto.Providers.Add(p);
                    contexto.SaveChanges();
                    MessageBox.Show("Fornecedor salvo com sucesso");
                    textBox_nomeFornecedor.Clear();



                }
                catch (Exception)
                {

                    MessageBox.Show("Erros ao salvar o fornecedor");
                    textBox_nomeFornecedor.Clear();
                }


            }
        }

        private void button_consultarFornecedores_Click_1(object sender, EventArgs e)
        {
            atualizarListView();
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

                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    int idFornecedor = int.Parse(textBox_deletar.Text);
                    Provider fornecedor = contexto.Providers.Find(idFornecedor);

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Você quer mesmo deletar " + fornecedor.Nome + " e seus produtos", "Deletando fornecedor", buttons);
                    if (result == DialogResult.Yes)
                    {
                        contexto.Providers.Remove(fornecedor);
                        contexto.SaveChanges();
                        MessageBox.Show("Excluido com sucesso");
                        textBox_deletar.Clear();
                        
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erros ao excluir");
                }


            }
        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                listView1.Items.Clear();
                Provider p = contexto.Providers.FirstOrDefault(proNome => proNome.IdFornecedor == int.Parse(textBox_filtrar.Text));
                
                listView1.Items.Add(p.IdFornecedor.ToString());
                listView1.Items[0].SubItems.Add(p.Nome.ToString());

              


            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao filtrar");
            }
           

        }

        
    }

    
}
