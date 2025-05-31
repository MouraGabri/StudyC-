using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1070_uri
    {

        public static void SeisNumerosImpares()
        {
            int entrada = int.Parse(Console.ReadLine());
            int cont;

            if (entrada % 2 == 0)
            {
                entrada += 1;
                Console.WriteLine(entrada);




                Console.WriteLine(entrada + 2);
                Console.WriteLine(entrada + 4);
                Console.WriteLine(entrada + 6);
                Console.WriteLine(entrada + 8);
                Console.WriteLine(entrada + 10);




            }
        }
    }
}
