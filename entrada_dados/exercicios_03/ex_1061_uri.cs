using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios_03
{
    internal class ex_1061_uri
    {
        public static void TempoVento() {

            string[] linha1DiaComeca = Console.ReadLine().Split();     // "Dia 5"
            string[] horaComeca = Console.ReadLine().Split(':');       // "08 : 12 : 23"
            string[] linha3DiaAcaba = Console.ReadLine().Split();      // "Dia 9"
            string[] horaTermina = Console.ReadLine().Split(':');

            int diaComecaEvento = int.Parse(linha1DiaComeca[1]);
            int diaTerminaEvento = int.Parse(linha3DiaAcaba[1]);

            // Hora|Minuto|Segundo começa evento
            int horaComecaEvento = int.Parse(horaComeca[0]);
            int minutoComecaEvento = int.Parse(horaComeca[1]);
            int segundoComecaEvento = int.Parse(horaComeca[2]);

            // Hora|Minuto|Segundo Termina evento
            int horaTerminaEvento = int.Parse(horaTermina[0]);
            int minutoTerminaEvento = int.Parse(horaTermina[1]);
            int segundoTerminaEvento = int.Parse(horaTermina[2]);


            int segundosInicio = segundoComecaEvento + minutoComecaEvento * 60 + horaComecaEvento * 3600 + diaComecaEvento * 86400;
            int segundosFim = segundoTerminaEvento + minutoTerminaEvento * 60 + horaTerminaEvento * 3600 + diaTerminaEvento * 86400;
            int duracaoTotal = segundosFim - segundosInicio;
            int duracaoDias = duracaoTotal / 86400;
            duracaoTotal %= 86400;

            int duracaoHoras = duracaoTotal / 3600;
            duracaoTotal %= 3600;

            int duraMinutos = duracaoTotal / 60;
            int duracaoSegundos = duracaoTotal % 60;

            Console.WriteLine(duracaoDias + " dia(s)");
            Console.WriteLine(duracaoHoras+ " hora(s)");
            Console.WriteLine(duraMinutos + " minuto(s)");
            Console.WriteLine(duracaoSegundos + " segundo(s)");



        }
    }
}
