using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeProdutos_winsForm
{
    internal class Nota
    {
        public int idNota { get; set; }
        public int idCliente { get; set; }
        public int idProduto { get; set; }
        public float valor { get; set; }
        public int quantidade { get; set; }
        public string codigo { get; set; }

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn;
            cmd.Transaction = transacao;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into nota values (@idCliente,@idProduto,@quantidade,@valor,@codigo);";
            cmd.Parameters.Add("@idCliente", SqlDbType.Int);
            cmd.Parameters.Add("@idProduto", SqlDbType.Int);
            cmd.Parameters.Add("@quantidade", SqlDbType.Int);
            cmd.Parameters.Add("@valor", SqlDbType.Float);
            cmd.Parameters.Add("@codigo", SqlDbType.VarChar);

            cmd.Parameters[0].Value = idCliente;
            cmd.Parameters[1].Value = idProduto;
            cmd.Parameters[2].Value = quantidade;
            cmd.Parameters[3].Value = valor;
            cmd.Parameters[4].Value = codigo;



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
