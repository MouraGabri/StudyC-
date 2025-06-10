using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_GPT_1
    {

        public static void Multiplos()
        {
            int number = int.Parse(Console.ReadLine());
            int mult7 = 0;
            int mult3 = 0;
            int multAmbos = 0;


            while (number != 0)
            {
                if(number % 3 == 0)
                {
                    mult3++;
                }

                if(number % 7 == 0)
                {
                    mult7++;
                }

                if(number % 7 == 0 && number % 3 == 0)
                {
                    multAmbos++;
                }

                Console.WriteLine("Informe outro número");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Múltiplos de 3: " + mult3);
            Console.WriteLine("Múltiplos de 7: " + mult7);
            Console.WriteLine("Múltiplos de ambos: " + multAmbos);

        }
    }
}
