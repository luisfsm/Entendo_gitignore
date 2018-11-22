using System;

namespace Impar_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int ini = 1, fim = 100;

            while (ini <= fim)
            {
                if (ini % 2 == 0)
                {
                    Console.WriteLine("Numero par : " + ini);
                    ini++;
                }
                else
                {
                    Console.WriteLine("Numero impar : " + ini);
                    ini++;
                }
            }
            Console.ReadLine();
        }
    }
}
