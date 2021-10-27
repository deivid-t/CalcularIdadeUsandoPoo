using System;

namespace saberIdade
{
    public class Pessoa
    {
        private int anoNascimento;
        public int AnoNascimento
        {
          get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }

        public void exibirDados()
        {
            Console.WriteLine("O seu nome é: " + this.Nome);
            Console.WriteLine("Sua data de nascimento: " + this.AnoNascimento);
            int idade = this.calcularIdade();       
            Console.WriteLine("A sua idade é: " + idade);
        }

        private int calcularIdade()
        {
            int anoAtual = 2021;
            int idade = anoAtual - this.AnoNascimento;
            return idade;
        
        }

        
        
        
        
        
    }
    
}
