using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1002_uri
    {
        public static void CalculoArea()
        {
            double n = (double) 3.14159;
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = n * Math.Pow(raio,2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }

    }
}
