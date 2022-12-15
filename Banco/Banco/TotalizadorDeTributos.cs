using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    internal class TotalizadorDeTributos {
        public double Total { get; private set; }

        public void Acumula(ITributavel t)  {
            Total += t.CalculaTributos();
        }

        public void Acumula(ContaInvestimento ci) {
            Total += ci.CalculaTributos();
        }
    }
}
