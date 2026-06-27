using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int interA;
            int interB;

            do
            {
                Console.Write("Digite um número positivo (maior que 0): ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0)
                {
                    Console.WriteLine("Erro! Números negativos não são permitidos. Tente novamente.");
                }

            } while (num <= 0);
                Console.Write("Digite um o intervalo A: ");
                interA = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite um o intervalo B: ");
                interB = int.Parse(Console.ReadLine());

                if (interB < interA)
                {
                    Console.WriteLine("Erro! o intervalo B deve ser maior doque o intervalo A. Tente novamente.");
                }

            } while (interB < interA);

            for (int i = interB; i >= interA; i--)
            {
                int resultado = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, resultado);
            }
        }
    }
}
