using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double maior = 0;
            double soma = 0;
            int conta = 0;

            while (conta < 10)
            {
                Console.Write($"Digite o {conta + 1}º valor (positivo): ");
                string entrada = Console.ReadLine();

                if (!double.TryParse(entrada, out valor))
                {
                    Console.WriteLine("Erro: entrada inválida. Digite um número.\n");
                    continue;
                }

                if (valor <= 0)
                {
                    Console.WriteLine("Erro: o valor deve ser positivo (maior que zero).\n");
                    continue;
                }

                soma += valor;
                conta += 1;

                if (conta == 1 || valor > maior)
                    maior = valor;
            }

            double media = soma / 10;

            Console.WriteLine($"  Maior valor : {maior}\n  Soma : {soma}\n  Média : {media:F2}");

        }
    }
}
