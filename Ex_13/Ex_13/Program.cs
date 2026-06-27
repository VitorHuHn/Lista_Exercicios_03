using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";

            do
            {
                int numero = -1;
                bool conversaoOk = false;

                while (!conversaoOk || numero < 0)
                {
                    Console.Write("Digite um número para calcular o fatorial: ");
                    string entrada = Console.ReadLine();

                    conversaoOk = int.TryParse(entrada, out numero);

                    if (!conversaoOk)
                    {
                        Console.WriteLine("ERRO: Digite apenas números inteiros!\n");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("ERRO: O número não pode ser negativo!\n");
                    }
                }

                long resultado = 1;

                for (int i = 2; i <= numero; i++)
                {
                    resultado = resultado * i;
                }

                Console.WriteLine($"\nO fatorial de {numero} é: {resultado}\n");

                while (continuar != "S" && continuar != "s" && continuar != "N" && continuar != "n")
                {
                    Console.Write("Deseja fazer um novo cálculo? (S/N): ");
                    continuar = Console.ReadLine().Trim();

                    if (continuar != "S" && continuar != "s" && continuar != "N" && continuar != "n")
                    {
                        Console.WriteLine("ERRO: Digite apenas S para Sim ou N para Não!\n");
                    }
                }

            } while (continuar == "S" || continuar == "s");
            Console.WriteLine("Programa encerrado. Até logo!");
        }

    }
}

