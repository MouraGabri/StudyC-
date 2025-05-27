using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1047_uri
    {
        public static void TempoDeJogoMinutos()
        {
            //inicial,minuto final,hora final,minuto final - jogo
            string[] entrada = Console.ReadLine().Split();
            int horaInicial = int.Parse(entrada[0]);
            int minutoInicial = int.Parse(entrada[1]);
            int horaFinal = int.Parse(entrada[2]);
            int minutoFinal = int.Parse(entrada[3]);

            int segundosInicio = (horaInicial * 3600) + (minutoInicial * 60);
            int segundosFinal = (horaFinal * 3600) + (minutoFinal * 60);
            int duracaoTotalSegundos;

            if (segundosFinal > segundosInicio)
            {
                duracaoTotalSegundos = segundosFinal - segundosInicio;
            }

            else
            {
                duracaoTotalSegundos = (86400 - segundosInicio) + segundosFinal;

            }

            int duracaoHoras = duracaoTotalSegundos / 3600;
            duracaoTotalSegundos %= 3600;

            int duraMinutos = duracaoTotalSegundos / 60;


            Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duraMinutos} MINUTO(S)");

        }





    }
}
