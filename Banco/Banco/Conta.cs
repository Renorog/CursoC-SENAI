using System;

namespace Banco {
    public class Conta {

        public int Numero { get;  set; }

        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

       /* public int Tipo { get; set; } */ // 1 = poupança  2 = corrente

        public Conta() {
        }

        public void Deposita(double valor) {
            this.Saldo += valor;
        }

        public virtual void Saca(double valor) {
          
                this.Saldo -= valor ;
                    
        }

        public void Transfere(double valor, Conta destino) {
            Saca(valor);
            destino.Deposita(valor);
        }
    }
}