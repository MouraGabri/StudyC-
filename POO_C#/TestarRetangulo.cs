using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class TestarRetangulo
    {
        public static void Executar()
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retangulo:");
            Console.Write("Largura:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura:");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");


        }

    }
}
