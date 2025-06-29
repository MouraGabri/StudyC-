using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1080_uri
    {

        public static void MaiorEPosicao()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int maior,menor;

            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {

                maior = y;
                menor = x;
            }

            for (int i = menor + 1; i < maior; i++)
            {
               
                    if ( i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                

            }




        }
    }
}
