using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.matrizes
{
    internal class ex_05
    {
        public static void SomaDiagonal()
        {
            Console.Write("QTD Linhas x Colunas Matriz Quadrada:");
            int linhas = int.Parse(Console.ReadLine());
            int[,] mat = new int[linhas, linhas];
            int soma = 0;



            //Inserindo valores nas linhas e colunas em uma matriz quadrada:
            Console.WriteLine("Inserindo valores na matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    
                    int valor = int.Parse(Console.ReadLine());
                    mat[i, j] = valor;
                }

            }

            Console.WriteLine("Maiores elementos da linha da matriz:");

            for (int i = 0; i < linhas; i++)
            {
               
                for (int j = 1; j < linhas; j++)
                {
                    
                    if (j > i)
                    {
                        soma += mat[i, j];
                    }

                }
               
            }
            Console.WriteLine(soma);
        }
    }
}
