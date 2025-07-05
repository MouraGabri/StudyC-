using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1158_uri
    {
        public static void SequenciaLogica2()
        {
            Console.Write("N(Qtd de casos de teste):");
            int n = int.Parse(Console.ReadLine());

            Console.Write("X(Número incial da sequência):");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Valor de Y(Qtd de números impares que deve somar):");
            int y = int.Parse(Console.ReadLine());
            int inicio = x;

            for (int i = 1; i <= n; i++)
            {
                if (x % 2 == 0)
                {
                    inicio = x + 1;
                }
                else
                {
                    inicio = x;
                }
                int soma = 0;
                for (int j = 0; j < y; j++)
                {
                    soma += inicio;
                    inicio += 2;
                }
                Console.WriteLine(soma);

                Console.Write("X(Número incial da sequência):");
                x = int.Parse(Console.ReadLine());

                Console.Write("Valor de Y(Qtd de números impares que deve somar):");
                y = int.Parse(Console.ReadLine());

            }


        }
    }
}
