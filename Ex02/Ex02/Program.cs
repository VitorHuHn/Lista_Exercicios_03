using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;

            Console.Write("Entre com o 1° valor: ");
            a = int.Parse(Console.ReadLine());

            do
            {

                Console.Write("Entre com o 2º valor (deve ser maior que o 1º): ");
                b = int.Parse(Console.ReadLine());

                    if (b <= a)
                        {
                            Console.WriteLine("Digite um número válido!");
                        }
            }
            while (b <= a);
            Console.WriteLine("Fim");

        }
    }
}
