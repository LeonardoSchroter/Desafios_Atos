using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeProdutos_winsForm
{
    internal class Produto
    {
        public int id { get; set; }
        public float preco { get; set; }
        public string tipo { get; set; }
        public int idFornecedor { get; set; }
        public string nome { get; set; }

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = transacao;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into produtos values (@preco,@tipo,@idFornecedor,@nome);";
            cmd.Parameters.Add("@preco", SqlDbType.Float);
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar);
            cmd.Parameters.Add("@idFornecedor", SqlDbType.Int);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);

            cmd.Parameters[0].Value = preco;
            cmd.Parameters[1].Value = tipo;
            cmd.Parameters[2].Value = idFornecedor;
            cmd.Parameters[3].Value = nome;


            try
            {
                cmd.ExecuteNonQuery();
                transacao.Commit();
                return true;
            }
            catch (Exception)
            {
                transacao.Rollback();
                return false;


            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
