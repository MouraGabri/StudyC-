using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1051_uri
    {

        public static void ImpostoDeRenda()
        {
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valor1 ;
            double valor2 ;


            if (renda >= 0.00 && renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            else if (renda > 2000.00 && renda <= 3000.00)
            {
                //valor = (double)3000.00 - renda;
                //valor = valor * 0.08;
            }

            else if (renda > 3000.00 && renda <= 4500.00)
            {
                
                valor1 = 1000 * 0.18;
            }

            else
            {
                valor2 = 2.00 * 0.18;

            }
        }
    }
}
