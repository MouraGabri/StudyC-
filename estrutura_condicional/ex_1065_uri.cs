using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1065_uri
    {

        public static void Par()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int cont = 0;

            if (n1 % 2 == 0)
            {
            
                cont += 1;
            }

            if (n2 % 2 == 0)
            {
                cont += 1;
            }
            if (n3 % 2 == 0)
            {
                cont += 1;
            }
            if (n4 % 2 == 0)
            {
           
                cont += 1;
            }
            if (n5 % 2 == 0)
            {
                cont += 1;
            }
           

            Console.WriteLine(cont + " valores pares");

        }
    }
}
