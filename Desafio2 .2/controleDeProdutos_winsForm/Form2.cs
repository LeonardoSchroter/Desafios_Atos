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
                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    Product p = new Product();
                    p.Preco = float.Parse(textBox_preco.Text);
                    p.Tipo = textBox_tipo.Text;
                    p.FkIdFornecedor = int.Parse(textBox_idFornecedor.Text);
                    p.Nome = textBox_nomeProduto.Text;
                    p.FkIdFornecedorNavigation = contexto.Providers.Find(int.Parse(textBox_idFornecedor.Text));
                    contexto.Products.Add(p);
                    contexto.SaveChanges();
                    textBox_idFornecedor.Clear();
                    textBox_nomeProduto.Clear();
                    textBox_preco.Clear();
                    textBox_tipo.Clear();
                    MessageBox.Show("Produto salvo com sucesso");
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao salvar");

                }


            }
        }

        private void atualizarListView()
        {
            try
            {
                listView1.Items.Clear();
                listView2.Items.Clear();
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                List<Provider> lista = new List<Provider>();

                lista = (from Provider p in contexto.Providers select p).ToList();
                int i = 0;
                foreach (Provider p in lista)
                {
                    listView2.Items.Add(p.IdFornecedor.ToString());
                    listView2.Items[i].SubItems.Add(p.Nome.ToString());
                    i++;
                }
                List<Product> lista2 = new List<Product>();
                lista2 = (from Product pr in contexto.Products select pr).ToList();
                i = 0;
                foreach (Product p in lista2)
                {
                    listView1.Items.Add(p.IdProdutos.ToString());
                    listView1.Items[i].SubItems.Add(p.Preco.ToString());
                    listView1.Items[i].SubItems.Add(p.Tipo.ToString());
                    listView1.Items[i].SubItems.Add(p.FkIdFornecedorNavigation.IdFornecedor.ToString());
                    listView1.Items[i].SubItems.Add(p.Nome.ToString());
                    i++;

                }
            }

            catch (Exception)
            {

                MessageBox.Show("Erro ao atualizar");
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizarListView();
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

                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    int idProduto = int.Parse(textBox_deletar.Text);
                    Product p = contexto.Products.Find(idProduto);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Você quer mesmo deletar o produto ?" + p.Nome, "Deletando produto", buttons);
                    if (result == DialogResult.Yes)
                    {
                        contexto.Products.Remove(p);
                        contexto.SaveChanges();
                        textBox_deletar.Clear();
                        MessageBox.Show("Produto deletado com sucesso");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao deletar");
                }



            }
        }





        private void button_filtrar_Click(object sender, EventArgs e)
        {
            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                listView2.Items.Clear();
                Provider p = contexto.Providers.FirstOrDefault(proNome => proNome.IdFornecedor == int.Parse(textBox_filtrarFornecedor.Text));
                
                listView2.Items.Add(p.IdFornecedor.ToString());
                listView2.Items[0].SubItems.Add(p.Nome.ToString());


            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao filtrar");
            }
        }

       

        private void button_produto_Click(object sender, EventArgs e)
        {

            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                listView1.Items.Clear();
                Product p = contexto.Products.FirstOrDefault(proNome => proNome.IdProdutos == int.Parse(textBox_filtrarProduto.Text));
                
                listView1.Items.Add(p.IdProdutos.ToString());
                listView1.Items[0].SubItems.Add(p.Preco.ToString());
                listView1.Items[0].SubItems.Add(p.Tipo.ToString());
                listView1.Items[0].SubItems.Add(p.FkIdFornecedor.ToString());
                listView1.Items[0].SubItems.Add(p.Nome.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao filtrar");

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
