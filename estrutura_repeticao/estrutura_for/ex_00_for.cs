using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_00_for
    {
        public static void AprendizadoFor()
        {
            int n, x, soma = 0;

            n = int.Parse(Console.ReadLine  ());

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                soma += x;
            }
            Console.WriteLine(soma);



        }
    }
}
