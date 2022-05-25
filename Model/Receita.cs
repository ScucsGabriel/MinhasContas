using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.Model
{
    public class Receita
    {
        public int idReceita { get; set; }
        public double valorReceita { get; set; }
        public string descricaoReceita { get; set; }
        public DateTime dataReceita { get; set; }
    }
}
