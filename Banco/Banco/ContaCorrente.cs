namespace Banco {
    public class ContaCorrente : Conta, ITributavel {

        private static int totalDeContas = 0;

        int proxima = ContaCorrente.ProximaConta();
        public ContaCorrente() {
            ContaCorrente.totalDeContas++;
        }

        public static int ProximaConta() {
            return ContaCorrente.totalDeContas + 1;
        }

       public double CalculaTributos() {
            return (this.Saldo * 0.05);
        }

        public override void Deposita(double valor) {
            this.Saldo += valor;
        }

        public override void Saca(double valor) {
            this.Saldo -= (valor + 0.10);
        }
    }
}