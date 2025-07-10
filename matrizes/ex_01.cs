using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.matrizes
{
    internal class ex_01
    {

        public static void AprendendoMatriz()
        {
            Console.Write("Linhas Matriz:");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Colunas Matriz:");
            int colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];


            // Inserindo valores nas linhas e colunas em uma matriz quadrada:
            Console.WriteLine($"Gravando valores na matriz[{linhas},{colunas}]");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"linha {i}, valor para coluna {j}:");
                    int valor = int.Parse(Console.ReadLine());
                    mat[i, j] = valor;
                }

            }
            // Imprimindo valores matriz
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {

                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
