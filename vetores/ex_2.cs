using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_2
    {
        public static void NumeroMenor()
        {
            Console.Write("QTD de valores:");
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            int numeros = 0; 

            //Inserir valores no vetor

            for (int i = 0; i < vet.Length; i ++)
            {
                Console.Write("Digite um valor:");
                numeros = int.Parse(Console.ReadLine());
                vet[i] = numeros;
            }
            int menorNumero = vet[0];
            // For para encontrar o menor numero no vetor
            for (int i = 1; i < vet.Length;i++)
            {
                if (vet[i] < menorNumero)
                {
                    menorNumero = vet[i];
                }
            }
            Console.WriteLine("Menor número do vetor:" + menorNumero);

        }
    }
}
