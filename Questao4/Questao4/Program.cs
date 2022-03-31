using System;

namespace Questao4 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <=67) {
                Console.WriteLine("Parabéns! Você pode ser doador! ");
            } else {
                Console.WriteLine("Infelizmente você não pode ser doador, a idade permitida é entre 18 e 67 anos.");
            }
        }
    }
}
