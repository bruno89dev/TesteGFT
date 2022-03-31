using System;

namespace Questao3 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a quantidade de litros de suco: ");
            int qtdLitros = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sabor do suco: (L para limão ou T para Tamarindo)");
            char sabor = char.Parse(Console.ReadLine());
            int desconto = 0; ;

            if (qtdLitros <= 2 && sabor == 'L') {
                desconto = 3;
            } else if (qtdLitros > 5 && sabor == 'L') {
                desconto = 5;
            } else if (qtdLitros <= 2 && sabor == 'T') {
                desconto = 4;
            } else if (qtdLitros > 5 && sabor == 'T') {
                desconto = 6;
            } else {
                Console.WriteLine("Valores inválidos");
            }
            Console.WriteLine($"O desconto aplicado é de {desconto} %");
        }
    }
}
