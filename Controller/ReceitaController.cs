using MinhasContas.DAO;
using MinhasContas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.Controller
{
    public class ReceitaController
    {
        public Receita InserirReceita(double valorReceita, string descricaoReceita, DateTime dataReceita)
        {
            return new ReceitaDB().InserirReceita(valorReceita, descricaoReceita, dataReceita);
        }

        public List<Receita> EditarReceita(int idReceita, double valorReceita, string descricaoReceita, DateTime dataReceita)
        {
            return new ReceitaDB().EditarReceita(idReceita, valorReceita, descricaoReceita, dataReceita);
        }

        public List<Receita> ConsultarReceitaPorDescricao(string descricaoReceita)
        {
            return new ReceitaDB().ConsultarReceitaPorDescricao(descricaoReceita);
        }

        public List<Receita> ConsultarReceitaPorId(int idReceita)
        {
            return new ReceitaDB().ConsultarReceitaPorId(idReceita);
        }

        public List<Receita> ConsultarReceita(string dataReceitaMinima, string dataReceitaMaxima)
        {
            return new ReceitaDB().ConsultarReceita(dataReceitaMinima, dataReceitaMaxima);
        }

        public Receita ExcluirReceita(int idReceita)
        {
            return new ReceitaDB().ExcluirReceita(idReceita);
        }
    }
}
