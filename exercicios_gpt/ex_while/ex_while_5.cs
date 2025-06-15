using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_5
    {
        public static void NumerosPares()
        {
            int N = int.Parse(Console.ReadLine());

            int numberPares = 0;

            while (numberPares <= N)
            {

                Console.WriteLine(numberPares);
                numberPares += 2;



            }
        }
    }
}
