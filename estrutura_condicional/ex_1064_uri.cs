using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1064_uri
    {

        public static void PositivoNegativoMedia()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n6 = double.Parse(Console.ReadLine());
            int cont = 0;
            double media = 0.0;
            media += n1;
            cont += 1;


            

            if (n2 > 0)
            {
                media += n2;
                cont += 1;
            }
            if (n3 > 0)
            {
                media += n3;
                cont += 1;
            }
            if (n4 > 0)
            {
                media += n4;
                cont += 1;
            }
            if (n5 > 0)
            {
                media += n5;
                cont += 1;
            }
            if (n6 > 0)
            {
                media += n6;
                cont += 1;
            }

            double mediaFinal = (double)media / cont;
            Console.WriteLine(cont + " valores positivos");
            Console.WriteLine(mediaFinal.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
