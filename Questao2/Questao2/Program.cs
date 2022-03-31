using System;

namespace Questao2 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Em que turno você trabalha? ");
            Console.WriteLine("Digite M para Matutino, V para Vespertino e N para Noturno: ");
            char turno = char.Parse(Console.ReadLine());

            if (turno == 'M' || turno == 'm') {
                Console.WriteLine("Bom Dia!");
            } else if (turno == 'V' || turno == 'v') {
                Console.WriteLine("Boa Tarde!");
            } else if (turno == 'N' || turno == 'n') {
                Console.WriteLine("Boa Noite!");
            } else {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}
