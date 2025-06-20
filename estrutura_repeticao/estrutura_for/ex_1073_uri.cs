using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1073_uri
    {
        public static void QuadradoDePares()
        {
            int numberInteiro = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numberInteiro; i++)
            {
                if (i % 2 == 0)
                {
                    double quadradoPares = (Math.Pow(i,2));
                    Console.WriteLine(i + "^" + "2" + " = " + quadradoPares);
                }
            }
        }


    }
}
