using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_4
    {

        public static void Tabuada()
        {
            int entrada = 0;
            while (entrada < 1 || entrada > 10)
            {
                Console.Write("Informe um número entre [1 - 10]:");
               entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(entrada + " X 1 = " + entrada * 1);
            Console.WriteLine(entrada + " X 2 = " + entrada * 2);
            Console.WriteLine(entrada + " X 3 = " + entrada * 3);
            Console.WriteLine(entrada + " X 4 = " + entrada * 4);
            Console.WriteLine(entrada + " X 5 = " + entrada * 5);
            Console.WriteLine(entrada + " X 6 = " + entrada * 6);
            Console.WriteLine(entrada + " X 7 = " + entrada * 7);
            Console.WriteLine(entrada + " X 8 = " + entrada * 8);
            Console.WriteLine(entrada + " X 9 = " + entrada * 9);
            Console.WriteLine(entrada + " X 10 = " + entrada * 10);

        }
    }
}
