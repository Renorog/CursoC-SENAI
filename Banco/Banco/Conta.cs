using System;

namespace Banco {
    public abstract class Conta {

        public int Numero { get;  set; }

        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

       /* public int Tipo { get; set; } */ // 1 = poupança  2 = corrente

        public Conta() {
        }

        public abstract void Deposita(double valor);



        public abstract void Saca(double valor);
          
              
                    
        

        public void Transfere(double valor, Conta destino) {
            Saca(valor);
            destino.Deposita(valor);
        }
    }
}