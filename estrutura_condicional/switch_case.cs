using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class switch_case
    {
        public static void SwitchCase()
        {

            Console.WriteLine("Informe um número de 1-7:");
            int diaSemana = int.Parse(Console.ReadLine());
            string dia;

            switch (diaSemana)
            {
                case 1:
                    dia = "dominigo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabádo";
                    break;
                default:
                    dia = "Valor inválido";
                    break;
            }
            Console.WriteLine("Dia da Semana: " + diaSemana);
            Console.ReadLine();


        }
    }
}
