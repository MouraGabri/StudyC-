using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_03
{
    internal class ex_1021_uri
    {
        public static void CedulasMoedas()
        {
            string[] entrada = Console.ReadLine().Split('.');
            int numberInteiro = int.Parse(entrada[0]);
            int numberResto = int.Parse(entrada[1]);

           int qtdNotas100 = numberInteiro / 100;
           int mod100 = numberInteiro % 100;

            int qtdNotas50 = mod100 / 50;
            int mod50 = mod100 % 50;
            //20
            int qtdNotas20 = mod50 / 20;
            int mod20 = mod50 % 20;
            //10
            int qtdNotas10 = mod20 / 10;
            int mod10 = mod20 % 10;
            //5
            int qtdNotas5 = mod10 / 5;
            int mod5 = mod10 % 5;
            //2
            int qtdNotas2 = mod5 / 2;
            int mod2 = mod5 % 2 * (100);

            ///MOEDAS
            int soma = numberResto + mod2;
           int qtdMoedas100 = soma / 100;
           int moeda100 = soma % 100;

            int qtdMoedas50 = moeda100 / 50;
            int moedas50 = moeda100 % 50;
            //20
            int qtdMoedas20 = moedas50 / 25;
            int moedas20 = moedas50 % 25;
            ////10
            int qtdMoedas10 = moedas20 / 10;
            int moedas10 = moedas20 % 10;
            ////5
            int qtdMoedas5 = moedas10 / 5;
            int moedas5 = moedas10 % 5;
            ////2
            int qtdMoedas1 = moedas5 / 1;
            int moedas2 = moedas5 % 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(qtdNotas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(qtdNotas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(qtdNotas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(qtdNotas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(qtdNotas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(qtdNotas2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");

            Console.WriteLine(qtdMoedas100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(qtdMoedas50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(qtdMoedas20 + " moeda(s) de R$ 0.25");
            Console.WriteLine(qtdMoedas10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(qtdMoedas5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(qtdMoedas1 + " moeda(s) de R$ 0.01");


        }
    }
}
