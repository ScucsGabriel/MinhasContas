using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.Model
{
    public class Despesa
    {
        public int idDespesa { get; set; }
        public double valorDespesa { get; set; }
        public string descricaoDespesa { get; set; }
        public string tipoDespesa { get; set; }
        public DateTime dataDespesa { get; set; }
        public string despesaPaga { get; set; }        
    }
}
