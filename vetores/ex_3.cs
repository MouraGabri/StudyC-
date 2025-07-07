using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_3
    {
        public static void NumerosPares()
        {
            Console.Write("QTD de valores:");
            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];
            int contadorNumerosPares = 0;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write("Informe um valor:");
                int valor = int.Parse(Console.ReadLine());
                vet[i] = valor;
            }

            for ( int i = 0; i < vet.Length; i ++)
            {
                if (vet[i] % 2 == 0) { 
                Console.Write(vet[i]+",");
                contadorNumerosPares++;


                }

            }
            Console.WriteLine();
            Console.WriteLine(contadorNumerosPares);







        }
    }
}
