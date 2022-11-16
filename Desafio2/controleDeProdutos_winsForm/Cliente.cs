using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeProdutos_winsForm
{
    internal class Cliente
    {
        public int ID { get; set; }
        public string cpf { get; set; }
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
            cmd.CommandText = "insert into clientes values (@cpf,@nome);";
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);

            cmd.Parameters[0].Value = cpf;
            cmd.Parameters[1].Value = nome;



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
