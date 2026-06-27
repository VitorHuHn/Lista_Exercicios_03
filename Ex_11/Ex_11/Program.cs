using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int n = 0;
         bool nValido = false;

            while (nValido == false)
             {
               Console.Write("Quantos números deseja digitar? (1 a 19): ");
               string entradaN = Console.ReadLine();

                 if (!int.TryParse(entradaN, out n))
                  {
                    Console.WriteLine("ERRO: Digite um número inteiro válido.");
                  }
                    else if (n <= 0 || n >= 20)
                    {
                        Console.WriteLine("ERRO: O valor deve ser entre 1 e 19.");
                    }
                    else
                    {
                        nValido = true;
                    }
             }

                double maior = 0;
                double menor = 0;
                double soma = 0;
                int qtdPositivos = 0;
                int qtdNegativos = 0;
                bool primeiro = true;

                for (int i = 1; i <= n; i++)
                {
                    double valor = 0;
                    bool valido = false;

                    while (valido == false)
                    {
                        Console.Write("Digite o " + i + "º valor: ");
                        string entradaV = Console.ReadLine();

                        if (!double.TryParse(entradaV, out valor))
                        {
                            Console.WriteLine("ERRO: Digite um número válido.");
                        }
                        else
                        {
                            valido = true;
                        }
                    }

                    if (primeiro == true)
                    {
                        maior = valor;
                        menor = valor;
                        primeiro = false;
                    }
                    else
                    {
                        if (valor > maior)
                        {
                            maior = valor;
                        }

                        if (valor < menor)
                        {
                            menor = valor;
                        }
                    }

                    soma = soma + valor;

                    if (valor > 0)
                    {
                        qtdPositivos = qtdPositivos + 1;
                    }
                    else if (valor < 0)
                    {
                        qtdNegativos = qtdNegativos + 1;
                    }
                }

            double media = soma / n;
            double pctPositivos = (qtdPositivos * 100.0) / n;
            double pctNegativos = (qtdNegativos * 100.0) / n;

            Console.WriteLine($"RESULTADOS:\n Maior valor : + {maior} \nMenor valor : + {menor}\nSoma: {soma}\nMedia: {media}\n% Positivos: {pctPositivos}%\n% Negativos: {pctNegativos}%");
            Console.WriteLine("Programa encerrado. Ate mais!");
        }
    }
}
