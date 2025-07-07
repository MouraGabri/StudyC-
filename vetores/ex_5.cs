using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_5
    {
        public static void MediaAritmetica()
        {
            Console.Write("QTD de valores:");
            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];
            double valor;
            double somaValores = 0.0;
            int contadorValores;
            double media = 0.0;
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Valor:");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = valor;
                somaValores += valor;
                media = (double)somaValores / N;
            }
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }


        }
    }
}
