using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados
{
    internal class m02_entrada_dados
    {
        public static void Executar()
        {
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = (largura * comprimento);
            double preco = (area * valorMetroQuadrado);

            Console.WriteLine("Area:" + area.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Preço:" + preco.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
