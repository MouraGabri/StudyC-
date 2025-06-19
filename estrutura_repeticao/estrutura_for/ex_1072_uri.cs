using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1072_uri
    {
        public static void Intervalos()
        {
            Console.Write("Informe a quantidade de repetições:");
            int qtdRepeticoes = int.Parse(Console.ReadLine());
            int noIntervalo = 0; 
            int foraIntervalo = 0;

            for (int i = 0; i < qtdRepeticoes; i++)
            {
                Console.Write("Informe um número:");
                int number = int.Parse(Console.ReadLine());

                if (number >= 10 && number <= 20)
                {
                    noIntervalo ++;
                }

                else
                {
                    foraIntervalo++;
                }

            }
            Console.WriteLine(noIntervalo + " in");
            Console.WriteLine(foraIntervalo + " out");



        }
    }
}
