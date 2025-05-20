using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1044_uri
    {
        public static void Multiplos() {
            string[] entrada = Console.ReadLine().Split();
            int n1 = int.Parse(entrada[0]);
            int n2 = int.Parse(entrada[1]);


            if (n2 % n1 == 0 || n1 % n2 == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");

            }

        }
    }
}
