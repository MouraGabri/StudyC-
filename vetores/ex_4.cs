using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_4
    {
        public static void SomaVetores()
        {
            Console.Write("QTD de valores:");
            int N = int.Parse(Console.ReadLine());
            int[] vetA = new int[N];
            int[] vetB = new int[N];
            int[] vetC = new int[N];

            int valor;

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.Write("Valor vetor A:");
                valor = int.Parse(Console.ReadLine());
                vetA[i] = valor;

                Console.Write("Valor vetor B:");
                valor = int.Parse(Console.ReadLine());
                vetB[i] = valor;

                vetC[i] = vetA[i] + vetB[i];
            }

           foreach(int numeros in vetC)
            {
                Console.WriteLine(numeros);
            }



        }
    }
}
