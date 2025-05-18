using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1006_uri
    {
        public static void MediaPonderada()
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double somaProdutos = (double)(a * 2) + (b * 3) + (c * 5); ;
            double calcFinal = somaProdutos / 10;
            Console.WriteLine("MEDIA = " + calcFinal.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
