using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.matrizes
{
    internal class ex_03
    {
        public static void SomaElementos()
        {
            Console.Write("QTD Linhas x Colunas Matriz Quadrada:");
            int linhas = int.Parse(Console.ReadLine());
            int[,] mat = new int[linhas, linhas];
            int somaLinhas = 0;


            //Inserindo valores nas linhas e colunas em uma matriz quadrada:
            Console.WriteLine("Inserindo valores na matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write($"linha {i}, valor para coluna {j}:");
                    int valor = int.Parse(Console.ReadLine());
                    mat[i, j] = valor;
                }

            }
            Console.WriteLine("Soma Elementos Matriz");

            for (int i = 0; i < linhas; i++)
            {
                somaLinhas = 0;
                for (int j = 0; j < linhas; j++)
                {


                    somaLinhas += mat[i, j];
                }
                Console.WriteLine(somaLinhas);
            }
        }
    }
}
