using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1035_uri
    {
        public static void TesteSelecao1() {
            int a, b, c, d;

            string[] entrada = Console.ReadLine().Split();
            a = int.Parse(entrada[0]);
            b = int.Parse(entrada[1]);
            c = int.Parse(entrada[2]);
            d = int.Parse(entrada[3]);

            int somaCD = c + d;
            int somaAB = a + b;


            if (b > c && d > a && somaCD > somaAB && c > 0 && d > 0 && a%2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }

            else
            {
                Console.WriteLine("Valores nao aceitos");

            }

        }
    }
}
