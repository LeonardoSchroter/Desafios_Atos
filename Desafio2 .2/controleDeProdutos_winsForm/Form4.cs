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
//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS

using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ExTENSAO 2 (PDF)
using Font = iTextSharp.text.Font;
using Microsoft.VisualBasic.ApplicationServices;

namespace controleDeProdutos_winsForm
{
    public partial class Form4 : Form
    {
        Thread nt;
        public Form4()
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

        private void button_cadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm3);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm3(object? obj)
        {
            Application.Run(new Form3());
        }



        private void novoForm2(object? obj)
        {
            Application.Run(new Form2());
        }

        private void button_CadastrarProduto_Click_1(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoForm2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void atualizarListView()
        {

            try
            {
                listView1.Items.Clear();
                listView2.Items.Clear();
                listView3.Items.Clear();
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                List<Client> lista = new List<Client>();

                lista = (from Client p in contexto.Clients select p).ToList();
                int i = 0;
                foreach (Client p in lista)
                {
                    listView1.Items.Add(p.IdClientes.ToString());
                    listView1.Items[i].SubItems.Add(p.Nome.ToString());
                    listView1.Items[i].SubItems.Add(p.Cpf.ToString());
                    i++;
                }


                List<Product> lista2 = new List<Product>();
                lista2 = (from Product pr in contexto.Products select pr).ToList();
                i = 0;
                foreach (Product p in lista2)
                {
                    listView2.Items.Add(p.IdProdutos.ToString());
                    listView2.Items[i].SubItems.Add(p.Preco.ToString());
                    listView2.Items[i].SubItems.Add(p.Tipo.ToString());
                    listView2.Items[i].SubItems.Add(p.FkIdFornecedor.ToString());
                    listView2.Items[i].SubItems.Add(p.Nome.ToString());
                    i++;

                }
                List<Notum> lista3 = new List<Notum>();
                lista3 = (from Notum no in contexto.Nota select no).ToList();
                i = 0;
                foreach (Notum p in lista3)
                {
                    listView3.Items.Add(p.IdNota.ToString());
                    listView3.Items[i].SubItems.Add(p.FkIdClientes.ToString());
                    listView3.Items[i].SubItems.Add(p.FkIdProdutos.ToString());
                    listView3.Items[i].SubItems.Add(p.Quantidade.ToString());
                    listView3.Items[i].SubItems.Add(p.Valor.ToString());
                    listView3.Items[i].SubItems.Add(p.Codigo.ToString());
                    i++;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar");
            }

        }

        private void button_consultar_Click(object sender, EventArgs e)
        {
            atualizarListView();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_idDocliente.Text) || string.IsNullOrWhiteSpace(textBox_idDoProduto.Text) || string.IsNullOrWhiteSpace(textBox_quantidade.Text))
            {
                MessageBox.Show("Insira as informações requisitadas");
            }
            else
            {
                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    Notum n = new Notum();
                    
                    DateTime agora = DateTime.Now;

                    n.Codigo = double.Parse(agora.Second.ToString() + agora.Hour.ToString() + agora.Minute.ToString() + agora.Year.ToString() + agora.DayOfYear.ToString() + agora.Month.ToString());
                    n.FkIdProdutos = int.Parse(textBox_idDoProduto.Text);
                    n.FkIdClientes = int.Parse(textBox_idDocliente.Text);
                    n.Quantidade = int.Parse(textBox_quantidade.Text);
                    Product p = contexto.Products.Find(n.FkIdProdutos);
                    Client C  = contexto.Clients.Find(n.FkIdClientes);
                    n.Valor = p.Preco * n.Quantidade;
                    contexto.Nota.Add(n);
                    contexto.SaveChanges();
                    textBox_idDocliente.Clear();
                    textBox_idDoProduto.Clear();
                    textBox_quantidade.Clear();

                    MessageBox.Show("Nota salva com sucesso");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Você quer gerar um PDF da nota?", "Gerar nota", buttons);
                    if (result == DialogResult.Yes)
                    {

                        Document doc = new Document(PageSize.A4);
                        doc.SetMargins(40, 40, 40, 80);
                        doc.AddCreationDate();

                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\leosc\OneDrive\Área de Trabalho\Desafios atos\Desafio2 .2" + "\\NOTAFISCAL.PDF", FileMode.Create));
                        doc.Open();


                        string dados = "";

                        Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14);
                        Paragraph paragrafo = new Paragraph();
                        paragrafo.Font = fonte;


                        DateOnly hora = new DateOnly();
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("O cliente  " + n.FkIdClientesNavigation.Nome + " comprou " + n.Quantidade + " unidades do produto  " + n.FkIdProdutosNavigation.Nome + ". Preço total: R$" + n.Valor);
                        Paragraph paragrafo2 = new Paragraph();
                        paragrafo2.Font = fonte;
                        paragrafo2.Add("Data: " + agora.Day + "/" + agora.Month + "/" + agora.Year);
                        Paragraph paragrafo3 = new Paragraph();
                        paragrafo3.Font = fonte;
                        paragrafo3.Add("Código:" + n.Codigo);




                        doc.Add(paragrafo);
                        doc.Add(paragrafo2);
                        doc.Add(paragrafo3);


                        doc.Close();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao salvar nota");
                }


            }
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
                    Notum n = new Notum();
                    int idNota = int.Parse(textBox_deletar.Text);
                    n = contexto.Nota.Find(idNota);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Você quer mesmo deletar esta nota?", "Deletando nota", buttons);
                    if (result == DialogResult.Yes)
                    {
                        contexto.Remove(n);
                        contexto.SaveChanges();
                        MessageBox.Show("Nota deletada");
                        textBox_deletar.Clear();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao deletar nota");
                }





            }
        }

        private void button_filtrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();

                Product p = contexto.Products.FirstOrDefault(proNome => proNome.IdProdutos == int.Parse(textBox_filtrarProduto.Text));
                listView2.Items.Clear();
                listView2.Items.Add(p.IdProdutos.ToString());
                listView2.Items[0].SubItems.Add(p.Preco.ToString());
                listView2.Items[0].SubItems.Add(p.Tipo.ToString());
                listView2.Items[0].SubItems.Add(p.FkIdFornecedor.ToString());
                listView2.Items[0].SubItems.Add(p.Nome.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao filtrar");
            }
        }

        private void button_filtrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();

                Client p = contexto.Clients.FirstOrDefault(cliNome => cliNome.IdClientes == int.Parse(textBox_filtrarCliente.Text));
                listView1.Items.Clear();
                listView1.Items.Add(p.IdClientes.ToString());
                listView1.Items[0].SubItems.Add(p.Nome.ToString());
                listView1.Items[0].SubItems.Add(p.Cpf.ToString());


            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao filtrar");
            }
        }

        private void button_filtrarNota_Click(object sender, EventArgs e)
        {
            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();

                Notum p = contexto.Nota.FirstOrDefault(noNome => noNome.IdNota == int.Parse(textBox_filtrarCliente.Text));
                listView3.Items.Clear();
                listView3.Items.Add(p.IdNota.ToString());
                listView3.Items[0].SubItems.Add(p.FkIdClientes.ToString());
                listView3.Items[0].SubItems.Add(p.FkIdProdutos.ToString());
                listView3.Items[0].SubItems.Add(p.Quantidade.ToString());
                listView3.Items[0].SubItems.Add(p.Valor.ToString());
                listView3.Items[0].SubItems.Add(p.Codigo.ToString());


            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao filtrar");
            }
        }
    }
}
