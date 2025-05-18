using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1010_uri
    {
        public static void Calcular()
        {
            string[] peca1 = Console.ReadLine().Split();
            string[] peca2 = Console.ReadLine().Split();

            double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
            double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
            int qtdTotalPecas1 = int.Parse(peca1[1]);
            int qtdTotalPecas2 = int.Parse(peca2[1]);
            double calculoFinal = (qtdTotalPecas1 * valorPeca1) + (qtdTotalPecas2 * valorPeca2);
            Console.WriteLine("VALOR A PAGAR: R$ " + calculoFinal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
