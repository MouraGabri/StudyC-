using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_02
{
    internal class ex_1009_uri
    {

        public static void Salario()
        {
            string nome = Console.ReadLine().ToUpper();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendasFeitas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //Ganha 15% de comissao nas vendas feitas

            double calcComissao = (double)  (vendasFeitas * 0.15) + salario ;
            Console.WriteLine("TOTAL = R$ " + calcComissao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
