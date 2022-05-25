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
    class RelatorioDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal List<Relatorio> GerarRelatorio(string dataMinima, string dataMaxima)
        {
            List<Relatorio> lstRelatorio = new List<Relatorio>();
            SqlConnection conn = new SqlConnection(conecta);
            string sqlstring = "SELECT ValorReceita AS Valor, ('Receita - ' + DescricaoReceita) AS Transacao," +
                                " DataReceita AS DataTransacao FROM Receita" +
                                " WHERE(CAST(DataReceita AS DATE) >= '" + dataMinima + "'" +
                                " AND CAST(DataReceita AS DATE) <= '" + dataMaxima + "')" +
                                " UNION SELECT ValorDespesa AS Valor, " +
                                " ('Despesa - ' + DescricaoDespesa) AS Transacao," +
                                " DataDespesa AS DataTransacao FROM Despesa" +
                                " WHERE(CAST(DataDespesa AS DATE) >= '" + dataMinima + "'" +
                                " AND CAST(DataDespesa AS DATE) <= '" + dataMaxima + "')" +
                                " ORDER BY DataTransacao";
            SqlCommand cmd = new SqlCommand(sqlstring, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Relatorio relatorio = new Relatorio();
                relatorio.valorTransacao = Convert.ToDouble(dr["Valor"].ToString());
                relatorio.descricaoTransacao = dr["Transacao"].ToString();
                relatorio.dataTransacao = Convert.ToDateTime(dr["DataTransacao"].ToString());

                lstRelatorio.Add(relatorio);
            }
            conn.Close();

            return lstRelatorio;
        }
    }
}
