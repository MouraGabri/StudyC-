using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1060_uri
    {

        public static void PositivoNegativo()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int n6 = int.Parse(Console.ReadLine());
            int cont = 0;

            if (n1 > 0)
            {
                cont += 1;
            }

            if (n2 > 0)
            {
                cont += 1;
            }
            if (n3 > 0)
            {
                cont += 1;
            }
            if (n4 > 0)
            {
                cont += 1;
            }
            if (n5 > 0)
            {
                cont += 1;
            }
            if (n6 > 0)
            {
                cont += 1;
            }

            Console.WriteLine(cont + " valores positivos");
        }
    }
}
