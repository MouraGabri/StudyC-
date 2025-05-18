using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_02
{
    internal class ex_1013_uri
    {
        public static void Maior()
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int numberMaio2 = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(numberMaio2 + " eh o maior");

        }
    }
}
