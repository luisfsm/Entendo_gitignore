using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_Variaveis_flutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 Criando variaveis flutuantes");
            double salario,idade;
            salario = 1200.70;

            Console.WriteLine("Seu Sálario e "+salario);
            salario = (salario * 0.10) + salario;
            Console.WriteLine("Seu salario Com 10 % de aumento : "+salario);
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);
            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);
            Console.WriteLine("A Execução Terminou Tecla qualquer coisa ....");
            Console.ReadLine();
        }
    }
}
