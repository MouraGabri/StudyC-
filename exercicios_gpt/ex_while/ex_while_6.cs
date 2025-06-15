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

   
            while (true)
            {
                ulong entrada = ulong.Parse(Console.ReadLine());

                if (entrada > 0)
                {
                    int totalNUmber = entrada.ToString().Length;
                    Console.WriteLine("total de caracteres:");
                    Console.WriteLine(totalNUmber);
                    break;
                }

                else
                {
                    Console.WriteLine("Informe um valor Positivo");
                   
                }

            }
        }
    }
}
