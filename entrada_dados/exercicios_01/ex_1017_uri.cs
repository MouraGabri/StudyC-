using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1017_uri
    {
        public static void GastoCombustivel()
        {
            int horas = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double calculo =  (double) (horas * velocidade) / 12;
            Console.WriteLine(calculo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
