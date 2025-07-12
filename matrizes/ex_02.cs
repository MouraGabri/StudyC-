using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.matrizes
{
    internal class ex_02
    {

        public static void NumerosNegativos()
        {
            Console.Write("Linhas Matriz:");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Colunas Matriz:");
            int colunas = int.Parse(Console.ReadLine());
            int valorColunas = 0;

            int[,] mat = new int[linhas, colunas];

            Console.WriteLine("Inserindo valores na matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write("Valor Coluna:");
                    valorColunas = int.Parse(Console.ReadLine());
                    mat[i,j] = valorColunas;
                }
            }

            Console.WriteLine("Valores Negativos na Matriz");

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                  
                   if(mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                                    }
            }
        }
    }
}
