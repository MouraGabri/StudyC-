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

            Console.Write("Valor de X:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Valor de Y:");
            int y = int.Parse(Console.ReadLine());
            int maior, menor;

            while (x > 0 && y > 0)
            {
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
                Console.WriteLine("====================================================:");
                Console.Write("Valor de X:");
                x = int.Parse(Console.ReadLine());

                Console.Write("Valor de Y:");
                y = int.Parse(Console.ReadLine());
               
            }
        }

    }
}
