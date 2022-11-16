using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeProdutos_winsForm
{
    internal class Banco
    {
        private string conec = "Data Source=localhost;Initial Catalog=controleProdutos_db; User ID=sa; password=Leo996701392; language=Portuguese";


        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand sqlCommand = new SqlCommand(sql, cn);
                sqlCommand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
        
    }
}
