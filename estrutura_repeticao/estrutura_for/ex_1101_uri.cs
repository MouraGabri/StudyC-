using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1101_uri
    {
        public static void SequenciaNumerosESoma()
        {

            int x = 1;
            int y = 1;
            int maior, menor;

            while (x > 0 && y > 0)
            {

                Console.Write("Valor de X:");
                x = int.Parse(Console.ReadLine());

                Console.Write("Valor de Y:");
                y = int.Parse(Console.ReadLine());

                if (x > y) { maior = x; menor = y; }
                else { maior = y; menor = x; }
                int soma = 0;
                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + ",");
                    soma += i;

                    if (i == maior)
                    {
                        Console.WriteLine($"Sum=  {soma} ");
                    }
                }
            }
        }

    }
}
