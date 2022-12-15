using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class ContaInvestimento : Conta, ITributavel {

        public double CalculaTributos() {
            return this.Saldo * 0.03;
        }
        public override void Deposita(double valor) {
            throw new NotImplementedException();
        }

        public override void Saca(double valor) {
            throw new NotImplementedException();
        }
    }
}
