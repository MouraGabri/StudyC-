using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_tabuada_gpt
    {
        public static void Tabuada()
        {
            Console.Write("Informe um número:");
            int x = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{x} X {i} = {x*i}");
            }
        }
    }
}
