using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1041_uri
    {
        public static void PlanoCartesiano()
        {

            string[] entrada = Console.ReadLine().Split(" ");
            double x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }

            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }

            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");

            }






        }
    }
}
