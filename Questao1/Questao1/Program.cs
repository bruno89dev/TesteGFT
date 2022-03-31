using System;

namespace Questao1 {
    internal class Program {
        static void Main(string[] args) {
            
            Pessoa pessoaTeste = new Pessoa();
            pessoaTeste.Nome = "João";
            pessoaTeste.AnoNascimento = 1995;
            pessoaTeste.Altura = 1.75;
            pessoaTeste.Idade = pessoaTeste.calcularIdade();

            Pessoa pessoaTeste2 = new Pessoa();
            pessoaTeste2.Nome = "Maria";
            pessoaTeste2.AnoNascimento = 1999;
            pessoaTeste2.Altura = 1.64;
            pessoaTeste2.Idade = pessoaTeste2.calcularIdade();

            Console.WriteLine($"{pessoaTeste.Nome} tem {pessoaTeste.Altura}m de altura e {pessoaTeste.Idade} anos de idade");
            Console.WriteLine($"{pessoaTeste2.Nome} tem {pessoaTeste2.Altura}m de altura e {pessoaTeste2.Idade} anos de idade");
        }
    }
}
