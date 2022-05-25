using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasContas.Model
{
    public class Relatorio
    {
        public double valorTransacao { get; set; }
        public string descricaoTransacao { get; set; }
        public DateTime dataTransacao { get; set; }
        public Receita receita { get; set; }
        public Despesa despesa { get; set; }
        public Relatorio()
        {
            this.receita = new Receita();
            this.despesa = new Despesa();
        }
    }
}
