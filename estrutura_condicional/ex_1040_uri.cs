using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1040_uri
    {

        public static void Media3()
        {
            string[] entrada = Console.ReadLine().Split();
            float n1 = float.Parse(entrada[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(entrada[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(entrada[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(entrada[3], CultureInfo.InvariantCulture);

            float mediaFinal = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);
            Console.WriteLine("Media: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            if (mediaFinal >= 7.0)
            {
                Console.WriteLine("Aluno aprovado");

            }

            else if (mediaFinal < 5.0)
            {
                Console.WriteLine("Aluno reprovado");

            }
            else if (mediaFinal >= 5.0 && mediaFinal <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                notaExame = (notaExame + mediaFinal) / 2;

                if (notaExame >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado");
                    Console.WriteLine("Media final: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));


                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                    Console.WriteLine("Media final: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));


                }




            }




        }


    }
}

