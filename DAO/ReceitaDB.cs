using MinhasContas.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.DAO
{
    class ReceitaDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Receita InserirReceita(double valorReceita, string descricaoReceita, DateTime dataReceita)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Receita(ValorReceita, DescricaoReceita, DataReceita)" +
                              " VALUES (@valorReceita, @descricaoReceita, @dataReceita)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@valorReceita", valorReceita));
            comando.Parameters.Add(new SqlParameter("@descricaoReceita", descricaoReceita));
            comando.Parameters.Add(new SqlParameter("@dataReceita", dataReceita));

            try
            {
                conn.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na gravação de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        internal List<Receita> EditarReceita(int idReceita, double valorReceita, string descricaoReceita, DateTime dataReceita)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Receita SET ValorReceita = @valorReceita, DescricaoReceita = @descricaoReceita, DataReceita = @dataReceita" +
                               " WHERE IDReceita = " + idReceita;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@valorReceita", valorReceita));
            cmd.Parameters.Add(new SqlParameter("@descricaoReceita", descricaoReceita));
            cmd.Parameters.Add(new SqlParameter("@dataReceita", dataReceita));

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal List<Receita> ConsultarReceitaPorDescricao(string descricaoReceita)
        {
            List<Receita> lstReceita = new List<Receita>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Receita" +
                               " WHERE DescricaoReceita LIKE '%" + descricaoReceita + "%'";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Receita receita = new Receita();
                receita.idReceita = Convert.ToInt32(dr["IDReceita"].ToString());
                receita.valorReceita = Convert.ToDouble(dr["ValorReceita"].ToString());
                receita.descricaoReceita = dr["DescricaoReceita"].ToString();
                receita.dataReceita = Convert.ToDateTime(dr["DataReceita"].ToString());

                lstReceita.Add(receita);
            }
            conn.Close();

            return lstReceita;
        }

        internal List<Receita> ConsultarReceitaPorId(int idReceita)
        {
            List<Receita> lstReceita = new List<Receita>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Receita" +
                               " WHERE IDReceita = " + idReceita;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Receita receita = new Receita();
                receita.idReceita = Convert.ToInt32(dr["IDReceita"].ToString());
                receita.valorReceita = Convert.ToDouble(dr["ValorReceita"].ToString());
                receita.descricaoReceita = dr["DescricaoReceita"].ToString();
                receita.dataReceita = Convert.ToDateTime(dr["DataReceita"].ToString());

                lstReceita.Add(receita);
            }
            conn.Close();

            return lstReceita;
        }

        internal List<Receita> ConsultarReceita(string dataReceitaMinima, string dataReceitaMaxima)
        {
            List<Receita> lstReceita = new List<Receita>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Receita" +
                               " WHERE cast(DataReceita AS DATE) >= '" + dataReceitaMinima +
                               "' AND cast(DataReceita AS DATE) <= '" + dataReceitaMaxima +
                               "' ORDER BY DataReceita";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Receita receita = new Receita();
                receita.idReceita = Convert.ToInt32(dr["IDReceita"].ToString());
                receita.valorReceita = Convert.ToDouble(dr["ValorReceita"].ToString());
                receita.descricaoReceita = dr["DescricaoReceita"].ToString();
                receita.dataReceita = Convert.ToDateTime(dr["DataReceita"].ToString());

                lstReceita.Add(receita);
            }
            conn.Close();

            return lstReceita;
        }

        internal Receita ExcluirReceita(int idReceita)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "DELETE FROM Receita" +
                               " WHERE IDReceita = " + idReceita;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Houve um problema na exclusão: " + e);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
