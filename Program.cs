using System;

namespace saberIdade
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Programa que calcula a idade da pessoa: "); 
           Pessoa p = new Pessoa();
           Console.WriteLine("Nome da pessoa?: ");
           p.Nome = Console.ReadLine();
           Console.WriteLine("Ano de nascimento?: ");
           p.AnoNascimento = Convert.ToInt32( Console.ReadLine());
           p.exibirDados();
        }
    }
}
