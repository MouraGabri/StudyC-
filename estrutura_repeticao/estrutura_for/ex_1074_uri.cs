using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao.estrutura_for
{
    internal class ex_1074_uri
    {

        public static void ParImpar()
        {
            Console.Write("Informe a quantidade de repetições:");
            int qtdRepeticoes = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdRepeticoes; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    Console.WriteLine("NULL");
                }

                else
                {

                    if (valor % 2 == 0)
                    {
                        if (valor > 0)
                        {
                            Console.WriteLine("EVEN POSITIVE");

                        }
                        else { Console.WriteLine("ODD NEGATIVE"); }
                    }

                    if (valor % 2 != 0)
                    {
                        if (valor > 0)
                        {
                            Console.WriteLine("ODD POSITIVE");

                        }
                        else { Console.WriteLine("ODD NEGATIVE"); }

                    }

                }





            }
        }
    }
}
