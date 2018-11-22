using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5 Aula Trativa De String");
            char PrimeiraLetra = 'a';
            Console.WriteLine(PrimeiraLetra);

            PrimeiraLetra =(char)65;
            Console.WriteLine(PrimeiraLetra);
            PrimeiraLetra =(char)(PrimeiraLetra + 1);
            Console.WriteLine(PrimeiraLetra);
            string titulo = "Alura Escola de tecnologia " + 2018;
            string CursoProgramacao = @" 
                                        - .NET  
                                        - JAVA  
                                        - JAVASCRIPT
                                        ";
            Console.WriteLine(CursoProgramacao);

            string vazia = "";
            Console.WriteLine("Tecle Enter Nesse bagaça");
            Console.ReadLine();
        }
    }
}
