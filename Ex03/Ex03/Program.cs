using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sexo;


            do
            {
                Console.Write("Digite o seu Sexo, sendo 'F' Feminino e 'M' Masculino: ");
                sexo = (Console.ReadLine());
                if (sexo != "f" && sexo != "m")
                {

                    Console.WriteLine("Digite novamente!");

                }
            }
            while (sexo != "f" && sexo != "m");
            Console.WriteLine("Seu sexo é {0}", sexo);

        }
    }
}
