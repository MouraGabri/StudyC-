using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_03
{
    internal class ex_1018_uri
    {
        public static void Cedulas() { 
           int entrada = int.Parse(Console.ReadLine());
            //100
           int qtdNotas100 = entrada / 100;
           int mod100 = entrada % 100;
            //50
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
            int mod2 = mod5 % 2;
            //2
            int qtdNotas1 = mod2 / 1;
            int mod1 = mod2 % 1;

            Console.WriteLine(entrada);
            Console.WriteLine(qtdNotas100 + " nota(s) de R$ 100,00");
           Console.WriteLine(qtdNotas50 + " nota(s) de R$ 50,00");
           Console.WriteLine(qtdNotas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(qtdNotas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(qtdNotas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(qtdNotas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(qtdNotas1 + " nota(s) de R$ 1,00");





        }
    }
}
