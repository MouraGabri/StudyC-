using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class exercicio
    {
        public static void NotasAlunos()
        {
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("MENOR = " + x);
            }

            else if (y < x && y < z)
            {
                Console.WriteLine("MENOR = " + y);

            }

            else
            {

                Console.WriteLine("MENOR = " + z);

            }

        }




    }
}

