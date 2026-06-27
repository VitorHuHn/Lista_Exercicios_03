using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezes;
            int multi;
            string a;
            string b;

            vezes = 0;

            Console.Write("Aperte para Iniciar a tabuada!");
            a = (Console.ReadLine());

            do
            {
                vezes = vezes + 1;
                multi = 10 * vezes;
                Console.WriteLine("20 x {0} : {1}", vezes, multi);

            }
            while (vezes < 10);
            Console.Write("Aperte agora para ver a segunda parte!");
            b = (Console.ReadLine());
            do
            {
                vezes = vezes + 1;
                multi = 20 * vezes;
                Console.WriteLine("20 x {0} : {1}", vezes, multi);

            }
            while (vezes < 20);
        }
    }
}
