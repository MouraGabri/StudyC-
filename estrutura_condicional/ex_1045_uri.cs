using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1045_uri
    {
        public static void TiposDeTriangulo()
        {

            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0]);
            double b = double.Parse(entrada[1]);
            double c = double.Parse(entrada[2]);


            if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }

            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");

            }

            if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");

            }
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");

            }
            if (a == b && a == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");

            }

            if (a == b | b == c | c == a)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");

            }


        }

    }
}
