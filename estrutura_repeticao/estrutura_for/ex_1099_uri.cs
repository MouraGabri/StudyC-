using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1099_uri
    {
        public static void SomaImparesConsecutivos()
        {
            Console.Write("Informe a quantidade de casos:");
            int qtdRepeticoesLinhas = int.Parse(Console.ReadLine());
            int maior, menor;


            for (int i = 0; i < qtdRepeticoesLinhas; i++)
            {
                Console.Write("Valor de X:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Valor de Y:");
                int y = int.Parse(Console.ReadLine());
                int j;

                if (x > y) { maior = x; menor = y; }
                else { maior = y; menor = x; }
                int soma = 0;

                for (j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                    Console.WriteLine(soma);
                




            }


        }



    }
}
