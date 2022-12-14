namespace Banco {
    public class ContaCorrente : Conta {
        public override void Deposita(double valor) {
            this.Saldo += valor;
        }

        public override void Saca(double valor) {
            this.Saldo -= (valor + 0.10);
        }
    }
}