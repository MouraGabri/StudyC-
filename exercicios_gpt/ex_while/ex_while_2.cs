using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_2
    {
        public static void Soma100()
        {
            int contNumber = 0;
            int soma = 0;

            

            while (soma < 100)
            {
                Console.WriteLine("Infome um número");
                int entrada = int.Parse(Console.ReadLine());
                soma += entrada;
                contNumber++;
            }

            Console.WriteLine("Soma:" + soma);
            Console.WriteLine("Total de Números Informados:" + contNumber );
        }
    }
}
