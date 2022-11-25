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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            try
            {
                ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                List<Client> lista = new List<Client>();
                listView1.Items.Clear();
                lista = (from Client p in contexto.Clients select p).ToList();
                int i = 0;
                foreach (Client p in lista)
                {
                    listView1.Items.Add(p.IdClientes.ToString());
                    listView1.Items[i].SubItems.Add(p.Nome.ToString());
                    listView1.Items[i].SubItems.Add(p.Cpf.ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar clientes");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_cpf.Text) || string.IsNullOrWhiteSpace(textBox_nome.Text))
            {
                MessageBox.Show("Preencha os campos para poder salvar os dados");
            }
            else
            {
                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    Client p = new Client();
                    p.Cpf = textBox_cpf.Text;
                    p.Nome = textBox_nome.Text;
                    contexto.Clients.Add(p);
                    contexto.SaveChanges();
                    textBox_cpf.Clear();
                    textBox_nome.Clear();
                    MessageBox.Show("Cliente salvo com sucesso");
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao salvar");

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
                try
                {
                    ControleProdutosDb2Context contexto = new ControleProdutosDb2Context();
                    int idCliente = int.Parse(textBox_filtrarCliente.Text);
                    Client p = contexto.Clients.Find(idCliente);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Você quer mesmo deletar o cliente " + p.Nome, "Deletando cliente", buttons);
                    if (result == DialogResult.Yes)
                    {
                        contexto.Clients.Remove(p);
                        contexto.SaveChanges();
                        textBox_deletar.Clear();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Cliente deletado");
                }


            }
        }

        private void button_filtrar_Click(object sender, EventArgs e)
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
    }
}
