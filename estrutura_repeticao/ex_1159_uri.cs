using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_1159_uri
    {
        public static void ParesConsecutivos()
        {
            int x = int.Parse(Console.ReadLine());
            int resultado = 0;

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    resultado = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                    Console.WriteLine(resultado);

                }
                else
                {
                    x += 1; // força x a ser par
                    resultado = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                    Console.WriteLine(resultado);


                }
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
