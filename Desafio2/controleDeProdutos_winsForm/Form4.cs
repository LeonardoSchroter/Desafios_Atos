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
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using Font = iTextSharp.text.Font;

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

        private void atualizarDataGrid()
        {

            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from produtos ");
            dataGridView2.DataSource = dt;


            dt = bd.executaConsulta("select * from clientes ");
            dataGridView1.DataSource = dt;

            dt = bd.executaConsulta("select * from nota ");
            dataGridView3.DataSource = dt;

        }

        private void button_consultar_Click(object sender, EventArgs e)
        {
            atualizarDataGrid();
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox_idDocliente.Text) || string.IsNullOrWhiteSpace(textBox_idDoProduto.Text) || string.IsNullOrWhiteSpace(textBox_quantidade.Text))
            {
                MessageBox.Show("Insira as informações requisitadas");
            }
            else
            {
                Nota n = new Nota();

                n.idProduto = int.Parse(textBox_idDoProduto.Text);
                n.idCliente = int.Parse(textBox_idDocliente.Text);
                n.quantidade = int.Parse(textBox_quantidade.Text);
                if (n.gravar())
                {
                    MessageBox.Show("Nota salva com sucesso");
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Você quer gerar um PDF da nota?", "Gerar nota", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Document doc = new Document(PageSize.A4);
                        doc.SetMargins(40, 40, 40, 80);
                        doc.AddCreationDate();
                        string caminho = @"C:\Users\leosc\Downloads" + "NOTAFISCAL.pdf";
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Desafios\Desafio2" + "\\NOTAFISCAL.PDF", FileMode.Create));
                        doc.Open();

                       
                        string dados = "";

                        Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 14);
                        Paragraph paragrafo = new Paragraph();
                        paragrafo.Font = fonte;
                       
                        
                        paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                        paragrafo.Add("O cliente de id " + n.idCliente + " comprou " + n.quantidade + " unidades do produto de id " + n.idProduto);
                       
                       
                        
                        doc.Add(paragrafo);
                        
                        
                        doc.Close();

                    }



                }
                else
                {
                    MessageBox.Show("Erro ao salvar a nota");
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


                int idNota = int.Parse(textBox_deletar.Text);
                string sqlTexto = "DELETE FROM nota WHERE idNota = @idNota";
                Banco b = new Banco();
                SqlCommand comando = new SqlCommand(sqlTexto, b.abrirConexao());

                comando.Parameters.AddWithValue("@idNota", idNota);
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
