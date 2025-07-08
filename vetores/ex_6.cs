using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_6
    {
        public static void MediaAritmetica()
        {
            Console.Write("QTD de valores:");
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            int valor;
            int somaValores = 0;
            double media = 0.0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Valor:");
                valor = int.Parse(Console.ReadLine());
                vet[i] = valor;
                somaValores += valor;
                media = (double)somaValores / N;
            }

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    media = somaValores / N;
                }
            }
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}