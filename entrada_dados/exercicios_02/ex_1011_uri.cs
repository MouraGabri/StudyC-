using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_02
{
    internal class ex_1011_uri
    {
        public static void Esfera() {

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = (double) 3.14159;
            double raioCubo = Math.Pow(raio, 3);
            double calcVolume = (double) (4 / 3.0) * (pi * raioCubo);
            Console.WriteLine("VOLUME = " + calcVolume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
