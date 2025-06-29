using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1142_uri
    {

        public static void PUM()
        {
            int qtdLinhas = int.Parse(Console.ReadLine());
            int contador = 1;

            for (int i = 1; i <= qtdLinhas; i++)
            {
                Console.WriteLine($"{contador} {contador += 1} {contador += +1} PUM ");
                contador = contador + 2;


            }
        }
    }
}
