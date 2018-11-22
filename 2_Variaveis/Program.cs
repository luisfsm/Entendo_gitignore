using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Variaveis");
            int idade;
            idade = 10;
            Console.WriteLine(idade);
            idade = 2018 - 1999;
            Console.WriteLine(idade);
            idade = 10 + 5 * 2;
            Console.WriteLine(idade+" Essa Idade");
            Console.WriteLine("Tecle qualquer coisa para finalizar");
            Console.ReadLine();
        }
    }
}
