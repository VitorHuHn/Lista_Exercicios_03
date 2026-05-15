using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double i;

            do
            {
                Console.Write("Entre com um valor positivo: ");
                i = double.Parse(Console.ReadLine());

            }
            while (i < 0);
            Console.WriteLine("Fim");
        }
    }
}
