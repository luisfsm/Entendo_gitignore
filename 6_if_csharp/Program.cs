using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_if_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Condicionais");
            int idade = 30;
            int qtde_acompanhado = 2;

            if (idade >= 18)
            {
                Console.WriteLine(" João já e maior que 18 :" + idade);
            }
            else
            {
                if (qtde_acompanhado >= 2)
                {
                    Console.WriteLine("O maldito não pode Porém esta Acompanhado " + qtde_acompanhado);
                }
                else
                {
                    Console.WriteLine("Volte pra casa");
                }
            }



            Console.WriteLine("Tecle Qualquer Coisa");
            Console.ReadLine();
        }
    }
}
