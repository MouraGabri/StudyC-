using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_1115_uri
    {

        public static void Quadrante()
        {
            string[] entrada = Console.ReadLine().Split();
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                entrada = Console.ReadLine().Split();
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }

        }
    }
}
