using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_6
    {
        public static void ContadorDeDigitos()
        {


            int entrada = int.Parse(Console.ReadLine());

            while (entrada > 0)
            {  
                int totalNUmber = entrada.ToString().Length;
                Console.WriteLine(totalNUmber);
                break;
            }
        }
    }
}
