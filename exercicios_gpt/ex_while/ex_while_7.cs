using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_7
    {
        public static void IntervalosMedia()
        {
            int totalMedias = 0;
            int valoresNotas = 0;


            while (totalMedias < 5)
            {
                int entrada = int.Parse(Console.ReadLine());

                if (entrada >= 0 || entrada <= 10)
                {
                    valoresNotas += entrada;
                    totalMedias++;
                }

                else
                {
                    Console.WriteLine("Informe uma nova nota entre [0-10]");
                }
            }
            int media = valoresNotas / totalMedias;
            Console.WriteLine("Média: " + media);


        }
    }
}
