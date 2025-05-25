using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1046_uri
    {
        public static void TempoJogo()
        {
            string[] entrada = Console.ReadLine().Split();
            int horaInicio = int.Parse(entrada[0]);
            int horaFinal = int.Parse(entrada[1]);
            int duracao = 0;

            if (horaInicio >= horaFinal)
            {
                duracao = (24 + horaFinal) - horaInicio;
            }
            else
            {
                duracao = horaFinal - horaInicio;

            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
