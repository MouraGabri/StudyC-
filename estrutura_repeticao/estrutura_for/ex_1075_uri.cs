using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1075_uri
    {
        public static void Resto()
        {
            Console.Write("Informe um número inteiro:");
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i < 1000; i++)
            {
                if (i % entrada == 2 )
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
