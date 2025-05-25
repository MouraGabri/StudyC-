using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1037_uri
    {
        public static void Intervalo()
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada >= 0 && entrada <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");

            }

            else if (entrada > 25 && entrada <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");

            }
            else if (entrada > 50 && entrada <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");

            }

            else
            {
                Console.WriteLine("Fora de Intervalo");
            }
        }
    }
}
