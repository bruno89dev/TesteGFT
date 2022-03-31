using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1 {
    public class Pessoa {

        private string _nome;
        private int _anoNascimento;
        private double _altura;
        private int _idade;

        public string Nome { get; set; }
        public int AnoNascimento { get; set; }
        public double Altura { get; set; }
        public int Idade { get; set; }

        public int calcularIdade() {
            int idade = 2022 - AnoNascimento;
            return idade;
        }
    }
}
