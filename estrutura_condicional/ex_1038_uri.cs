using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1038_uri
    {
        public static void Lanche()
        {
            string[] entrada = Console.ReadLine().Split();
            int codigo = int.Parse(entrada[0]);
            int qtd = int.Parse(entrada[1]);
            double valorPagar = 0;

            switch (codigo)
            {

                case 1:
                    valorPagar = qtd * 4.00;
                    break;
                case 2:
                    valorPagar = qtd * 4.50;
                    break;
                case 3:
                    valorPagar = qtd * 5.00;
                    break;
                case 4:
                    valorPagar = qtd * 2.00;
                    break;
                case 5:
                    valorPagar = qtd * 1.50;
                    break;
                default:
                    Console.WriteLine("Valor nao existe");
                    break;
            }
            Console.WriteLine("Total: R$ " + valorPagar.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
