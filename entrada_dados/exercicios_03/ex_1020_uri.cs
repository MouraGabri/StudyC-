using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_03
{
    internal class ex_1020_uri
    {
        public static void IdadeEmDias() {

            int ano = 365;
            int mes = 30;

            int entrada = int.Parse(Console.ReadLine());

            //Pegando a parte inteira do ano
            int anoSaida = entrada / ano;
            int restoAno = entrada % ano;

            int mesInteiro = restoAno / mes;
            int mesmod = restoAno % mes;
            int restoDia = mesmod;

            Console.WriteLine(anoSaida + " ano(s)");
            Console.WriteLine(mesInteiro + " mes(es)");
            Console.WriteLine(mesmod + " dia(s)");



        }
    }
}
