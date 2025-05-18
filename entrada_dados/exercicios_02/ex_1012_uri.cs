using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_02
{
    internal class ex_1012_uri
    {
        public static void area()
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area_triangulo = (double) (a * c) / 2;
            double area_circulo = pi * Math.Pow(c,2);
            double area_trapezio = ((a + b) * c) / 2;
            double area_quadrado = Math.Pow(b, 2);
            double area_retangulo = a * b;


            Console.WriteLine("TRIANGULO: " + area_triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + area_retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}
