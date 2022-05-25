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
    class DespesaDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Despesa InserirDespesa(double valorDespesa, string descricaoDespesa, string tipoDespesa, DateTime dataDespesa, string despesaPaga)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlQuery = "INSERT INTO Despesa(ValorDespesa, DescricaoDespesa, TipoDespesa, DataDespesa, DespesaPaga)" +
                              " VALUES (@valorDespesa, @descricaoDespesa, @tipoDespesa, @dataDespesa, @despesaPaga)";
            SqlCommand comando = new SqlCommand(sqlQuery, conn);
            comando.Parameters.Add(new SqlParameter("@valorDespesa", valorDespesa));
            comando.Parameters.Add(new SqlParameter("@descricaoDespesa", descricaoDespesa));
            comando.Parameters.Add(new SqlParameter("@tipoDespesa", tipoDespesa));
            comando.Parameters.Add(new SqlParameter("@dataDespesa", dataDespesa));
            comando.Parameters.Add(new SqlParameter("@despesaPaga", despesaPaga));

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


        internal List<Despesa> EditarDespesa(int idDespesa, double valorDespesa, string descricaoDespesa, string tipoDespesa, DateTime dataDespesa, string despesaPaga)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "UPDATE Despesa SET ValorDespesa = @valorDespesa, DescricaoDespesa = @descricaoDespesa, TipoDespesa = @tipoDespesa, DataDespesa = @dataDespesa, DespesaPaga = @despesaPaga" +
                               " WHERE IDDespesa = " + idDespesa;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            cmd.Parameters.Add(new SqlParameter("@valorDespesa", valorDespesa));
            cmd.Parameters.Add(new SqlParameter("@descricaoDespesa", descricaoDespesa));
            cmd.Parameters.Add(new SqlParameter("@tipoDespesa", tipoDespesa));
            cmd.Parameters.Add(new SqlParameter("@dataDespesa", dataDespesa));
            cmd.Parameters.Add(new SqlParameter("@despesaPaga", despesaPaga));

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
        internal List<Despesa> ConsultarDespesaPorDescricao(string descricaoDespesa, string filtro)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring;
            if (filtro == "sf")
            {
                sqlstring = "SELECT * FROM Despesa" +
                            " WHERE DescricaoDespesa LIKE '%" + descricaoDespesa + "%'";
            }
            else if(filtro == "fdp")
            {
                sqlstring = "SELECT * FROM Despesa" +
                            " WHERE DescricaoDespesa LIKE '%" + descricaoDespesa + "%'" +
                            " AND DespesaPaga = 'S'";
            }
            else
            {
                sqlstring = "SELECT * FROM Despesa" +
                            " WHERE DescricaoDespesa LIKE '%" + descricaoDespesa + "%'" +
                            " AND DespesaPaga = 'N'";
            }
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["IDDespesa"].ToString());
                despesa.valorDespesa = Convert.ToDouble(dr["ValorDespesa"].ToString());
                despesa.descricaoDespesa = dr["DescricaoDespesa"].ToString();
                despesa.tipoDespesa = dr["TipoDespesa"].ToString();
                despesa.dataDespesa = Convert.ToDateTime(dr["DataDespesa"].ToString());
                despesa.despesaPaga = dr["DespesaPaga"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesaPorTipo(string tipoDespesa, string filtro)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring;
            if (filtro == "sf")
            {
                sqlstring = "SELECT * FROM Despesa" +
                            " WHERE TipoDespesa LIKE '%" + tipoDespesa + "%'";
            }
            else if (filtro == "fdp")
            {
                sqlstring = "SELECT * FROM Despesa" +
                            " WHERE TipoDespesa LIKE '%" + tipoDespesa + "%'" +
                            " AND DespesaPaga = 'S'";
            }
            else
            {
                sqlstring = "SELECT * FROM Despesa" +
                            " WHERE TipoDespesa LIKE '%" + tipoDespesa + "%'" +
                            " AND DespesaPaga = 'N'";
            }
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["IDDespesa"].ToString());
                despesa.valorDespesa = Convert.ToDouble(dr["ValorDespesa"].ToString());
                despesa.descricaoDespesa = dr["DescricaoDespesa"].ToString();
                despesa.tipoDespesa = dr["TipoDespesa"].ToString();
                despesa.dataDespesa = Convert.ToDateTime(dr["DataDespesa"].ToString());
                despesa.despesaPaga = dr["DespesaPaga"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesaPorId(int idDespesa)
        {
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT * FROM Despesa" +
                               " WHERE IDDespesa = " + idDespesa;
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["IDDespesa"].ToString());
                despesa.valorDespesa = Convert.ToDouble(dr["ValorDespesa"].ToString());
                despesa.descricaoDespesa = dr["DescricaoDespesa"].ToString();
                despesa.tipoDespesa = dr["TipoDespesa"].ToString();
                despesa.dataDespesa = Convert.ToDateTime(dr["DataDespesa"].ToString());
                despesa.despesaPaga = dr["DespesaPaga"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal List<Despesa> ConsultarDespesa(string dataDespesaMinima, string dataDespesaMaxima, string filtro)
        {
            string sqlstring;
            List<Despesa> lstDespesa = new List<Despesa>();
            SqlConnection conn = new SqlConnection(conecta);
            if (filtro == "sf")
            {
                sqlstring = "SELECT * FROM Despesa" +
                               " WHERE cast(DataDespesa AS DATE) >= '" + dataDespesaMinima +
                               "' AND cast(DataDespesa AS DATE) <= '" + dataDespesaMaxima +
                               "' ORDER BY DataDespesa";
            }
            else if (filtro == "fdp")
            {
                sqlstring = "SELECT * FROM Despesa" +
                               " WHERE cast(DataDespesa AS DATE) >= '" + dataDespesaMinima +
                               "' AND cast(DataDespesa AS DATE) <= '" + dataDespesaMaxima +
                               "' AND DespesaPaga = 'S'" +
                               " ORDER BY DataDespesa";
            }
            else 
            {
                sqlstring = "SELECT * FROM Despesa" +
                                  " WHERE cast(DataDespesa AS DATE) >= '" + dataDespesaMinima +
                                  "' AND cast(DataDespesa AS DATE) <= '" + dataDespesaMaxima +
                                  "' AND DespesaPaga = 'N'" +
                                  " ORDER BY DataDespesa";
            }
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Despesa despesa = new Despesa();
                despesa.idDespesa = Convert.ToInt32(dr["IDDespesa"].ToString());
                despesa.valorDespesa = Convert.ToDouble(dr["ValorDespesa"].ToString());
                despesa.descricaoDespesa = dr["DescricaoDespesa"].ToString();
                despesa.tipoDespesa = dr["TipoDespesa"].ToString();
                despesa.dataDespesa = Convert.ToDateTime(dr["DataDespesa"].ToString());
                despesa.despesaPaga = dr["DespesaPaga"].ToString();

                lstDespesa.Add(despesa);
            }
            conn.Close();

            return lstDespesa;
        }

        internal Despesa ExcluirDespesa(int idDespesa)
        {
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "DELETE FROM Despesa" +
                               " WHERE IDDespesa = " + idDespesa;
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
