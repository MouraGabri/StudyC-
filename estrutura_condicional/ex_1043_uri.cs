using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1043_uri
    {

        public static void Triangulo()
        {
            string[] entrada = Console.ReadLine().Split();
            double n1 = double.Parse(entrada[0], CultureInfo.InvariantCulture); //6
            double n2 = double.Parse(entrada[1], CultureInfo.InvariantCulture); // 4
            double n3 = double.Parse(entrada[2], CultureInfo.InvariantCulture); // 2



            if (n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1)
            {
                double perimetro = n1 + n2 + n3;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }

            else
            {
                double areaTrapezio = ((n1 + n2) * n3) / 2;
                Console.WriteLine("Area = " + areaTrapezio.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
