using MinhasContas.DAO;
using MinhasContas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.Controller
{
    public class DespesaController
    {
        public Despesa InserirDespesa(double valorDespesa, string descricaoDespesa, string tipoDespesa, DateTime dataDespesa, string despesaPaga)
        {
            return new DespesaDB().InserirDespesa(valorDespesa, descricaoDespesa, tipoDespesa, dataDespesa, despesaPaga);
        }

        public List<Despesa> EditarDespesa(int idDespesa, double valorDespesa, string descricaoDespesa, string tipoDespesa, DateTime dataDespesa, string despesaPaga)
        {
            return new DespesaDB().EditarDespesa(idDespesa, valorDespesa, descricaoDespesa, tipoDespesa, dataDespesa, despesaPaga);
        }

        public List<Despesa> ConsultarDespesaPorDescricao(string descricaoDespesa, string filtro)
        {
            return new DespesaDB().ConsultarDespesaPorDescricao(descricaoDespesa, filtro);
        }

        public List<Despesa> ConsultarDespesaPorTipo(string tipoDespesa, string filtro)
        {
            return new DespesaDB().ConsultarDespesaPorTipo(tipoDespesa, filtro);
        }

        public List<Despesa> ConsultarDespesa(string dataDespesaMinima, string dataDespesaMaxima, string filtro)
        {
            return new DespesaDB().ConsultarDespesa(dataDespesaMinima, dataDespesaMaxima, filtro);
        }

        public List<Despesa> ConsultarDespesaPorId(int idDespesa)
        {
            return new DespesaDB().ConsultarDespesaPorId(idDespesa);
        }

        public Despesa ExcluirDespesa(int idDespesa)
        {
            return new DespesaDB().ExcluirDespesa(idDespesa);
        }
    }
}
