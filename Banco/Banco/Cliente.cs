namespace Banco {
    public class Cliente {

        //private string v; // foi criada automaticamente

        public string Nome { get; private set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Documentos { get; set; }

        

        public Cliente(string nome) {
            this.Nome = nome;
        }
        public bool PodeAbrirContaSozinho {
            get {
                var mariorDeIdade = this.Idade >= 18;
                var emancipado = this.Documentos.Contains("emancipacao");
                var possuiCPF = !string.IsNullOrEmpty(this.Cpf);
                return (mariorDeIdade || emancipado) && possuiCPF;
            }



        }

  


  
    }
}