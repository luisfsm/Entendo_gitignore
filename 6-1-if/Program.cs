using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_1_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16, Qtde_pessoas=2;
            bool Acompanhado = Qtde_pessoas >= 2;

            if (idade >= 18 || Acompanhado == false)
            {
                Console.WriteLine("Pode Entrar");
            }
            else
            {
                Console.WriteLine("Vá para Casa");
            }

            Console.WriteLine("Tecle qualquer coisa");
            Console.ReadLine();
        }
    }
}
