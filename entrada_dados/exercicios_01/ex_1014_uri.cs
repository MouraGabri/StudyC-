using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1014_uri
    {
        public static void Consumo()
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double calculo = x / y;
            Console.WriteLine(calculo.ToString("F3", CultureInfo.InvariantCulture)+ " km/l");
        }
    }
}
