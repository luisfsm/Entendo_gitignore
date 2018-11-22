using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_Converssões_e_outros_tipos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 Aula Conversão");
            double salario;
            salario = 1200.70;
            int salarioEmInteiro; //int Uma variavel de 32 bits
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            long idade = 1300000000000 ; //Long e uma variavel de 64 bits
            

            short qtd_produto = 151 ; // short uma variavel de 16 bits
            

            float altura; 
            altura = 1.67f;
            Console.WriteLine(idade);
            Console.WriteLine(qtd_produto);
            Console.WriteLine(altura);

            double v1 = 0.1, v2 = 0.2;
            Console.WriteLine("Somando "+ (v1 + v2));
            Console.WriteLine("Tecle Qualquer Coisa");
            Console.ReadLine();

        }
    }
}
