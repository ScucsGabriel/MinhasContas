using MinhasContas.DAO;
using MinhasContas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.Controller
{
    public class RelatorioController
    {
        public List<Relatorio> GerarRelatorio(string dataMinima, string dataMaxima)
        {
            return new RelatorioDB().GerarRelatorio(dataMinima, dataMaxima);
        }
    }
}
