using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1116_uri
    {
        public static void DividindoXPorY()
        {
            Console.Write("Informe a quantidade de pares:");
            int qtdRepeticoesLinhas = int.Parse(Console.ReadLine());


            for (int i = 0; i < qtdRepeticoesLinhas; i++)
            {
                Console.Write("Valor de X:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Valor de Y:");
                int y = int.Parse(Console.ReadLine());

                double resposta = 0.0 ;


                if(y == 0)
                {
                    Console.WriteLine("divisao impossivel");

                }
                else
                {
                    resposta = (double)x / y;
                    Console.WriteLine(resposta.ToString("F1", CultureInfo.InvariantCulture));
                }

                
                
            }



        }
    }
}
