using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_1
    {
        public static void NumeroMenor()
        {
            ;
            Console.Write("QTD de valores:");
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            int numeroMaior = vet[0];

            //Armazenando no vetor os valores
            for (int i = 0; i < N; i++)
            {
                Console.Write("Informe um valor:");
                int valores = int.Parse(Console.ReadLine());
                vet[i] = valores;
            }

            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > numeroMaior)
                {
                    numeroMaior += vet[i];
                }
                
            }
            Console.WriteLine(numeroMaior);


        }

    }
}
