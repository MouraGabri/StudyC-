using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_1117_uri
    {
        public static void ValidacaoNota()
        {
            int totalNotasValidas = 0;
            double somaNotas = 0.0;


            while (totalNotasValidas < 2)
            {
                double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (nota >= 0 && nota <= 10)
                {
                    totalNotasValidas += 1;
                    somaNotas += nota;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            double mediaFinal = somaNotas / totalNotasValidas;
            Console.WriteLine("media = " + mediaFinal.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
