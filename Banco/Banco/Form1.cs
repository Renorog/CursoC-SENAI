using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco {
    public partial class Form1 : Form {

        private Conta[] contas;

        // guarda o número de contas que já foram cadastradas 
        private int numeroDeContas;


        public void AdicionaConta(Conta conta) {
            // implementação do método adiciona conta
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);

        }

        
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //criando o array para guardar as contas
            this.contas = new Conta[10];
            //inicializando instâncias
            Conta c1 = new ContaCorrente();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            //foreach (Conta conta in contas) {
            //    comboContas.Items.Add(conta.Titular.Nome);
            //}


            ContaPoupanca c = new ContaPoupanca();
            c.Deposita(100.0);



        }

        private void textoSaldo_TextChanged(object sender, EventArgs e) {

        }

        private void botaoDeposito_Click(object sender, EventArgs e) {
            //recuperando o índice da conta selecionada
            int indice = comboContas.SelectedIndex;
            //lendo a posição do array
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                      
        }

        private void botaoSaque_Click(object sender, EventArgs e) {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
         
     

        private void button1_Click(object sender, EventArgs e) {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Transfere(valor,this.contas[indice]);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
      

    private void comboContas_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        }

        private void botaoNovaConta_Click(object sender, EventArgs e) {
            // this representa a instância de Form1 que está sendo utilizada pelo 
            // widndown Form
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void botaoImpostos_Click(object sender, EventArgs e) {
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            MessageBox.Show("imposto da conta corrente = " + conta.CalculaTributos());
            ITributavel t = conta;

            MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributos());
        }

        //private void comboDestinoTranferencia_SelectedIndexChanged(object sender, EventArgs e) {
        //    //int indice1 = comboDestinoTranferencia.SelectedIndex;
        //    //int indice2 = 
        //}
    }
}
