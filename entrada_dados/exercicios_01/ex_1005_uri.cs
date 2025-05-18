using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1005_uri
    {
        public static void Media()
        {
            double a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double somaProdutos = (double)(a * 3.5) + (b * 7.5);
            double calcFinal = somaProdutos / 11;
            Console.WriteLine("MEDIA = " + calcFinal.ToString("F5", CultureInfo.InvariantCulture));



        }
    }
}
