using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_02
{
    internal class ex_1015_uri
    {
        public static void DistanciaPontos() {


            string[] p1 = Console.ReadLine().Split();
            string[] p2 = Console.ReadLine().Split();

            //Valores do P1
            double x1 = double.Parse(p1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(p1[1], CultureInfo.InvariantCulture);

            //Valores do P2
            double x2 = double.Parse(p2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(p2[1], CultureInfo.InvariantCulture);

            double calculoFinal = (double )Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2);
            double calcFinal = (double) Math.Sqrt(calculoFinal);


            Console.WriteLine(calcFinal.ToString("F4", CultureInfo.InvariantCulture));




        }
    }
}

