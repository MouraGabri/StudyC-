using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.matrizes
{
    internal class ex_06
    {
        public static void NovaMatriz()
        {
            Console.Write("Linhas Matriz:");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Colunas Matriz:");
            int colunas = int.Parse(Console.ReadLine());
            int[,] A = new int[linhas, colunas];
            int[,] B = new int[linhas, colunas];
            int[,] C = new int[linhas, colunas];


            Console.WriteLine("Inserindo valores na matriz A:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    int valor = int.Parse(Console.ReadLine());
                    A[i, j] = valor;
                }
            }
            Console.WriteLine("=============================================");

            Console.WriteLine("Inserindo valores na matriz B:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    int valor = int.Parse(Console.ReadLine());
                    B[i, j] = valor;
                }
            }
            Console.WriteLine("=============================================");

            Console.WriteLine("Imprimindo a matriz C:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=============================================");
        }


    }
}
