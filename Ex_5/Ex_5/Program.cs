using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezes;
            int multi;
            int num;

            vezes = 0;

            do
            {
                Console.Write("Digite um número positivo (maior que 0): ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("Erro! Números negativos não são permitidos. Tente novamente.");
                }

            } while (num <= 0);

            do
            {
                vezes = vezes + 1;
                multi = num * vezes;
                Console.WriteLine("{0} x {1} : {2}", num, vezes, multi);

            }
            while (vezes < 10);
        }
}
}
