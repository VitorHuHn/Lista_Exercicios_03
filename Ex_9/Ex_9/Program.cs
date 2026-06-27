using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termos = 30;
            int anterior = 0;
            int atual = 1;

            Console.Write("{0} {1}", anterior, atual);

            for (int i = 2; i < termos; i++)
            {
                int proximo = anterior + atual;
                Console.Write(" {0}", proximo);

                anterior = atual;
                atual = proximo;
            }
        }
    }
}
