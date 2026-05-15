using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vezes;
            int multi;

            vezes = 0;

            do
            {
                vezes = vezes + 1;
                multi = 5 * vezes;
                Console.WriteLine("5 x {0} : {1}", vezes, multi);
     
            }
            while (vezes < 10);
        }
    }
}
