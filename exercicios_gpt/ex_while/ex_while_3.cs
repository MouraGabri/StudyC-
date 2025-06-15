using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_3
    {

        public static void Senha()
        {
            int senhaCorreta = 1234;
            int tentativas = 0;

            while(tentativas < 3)
            {
                int senha = int.Parse(Console.ReadLine());

                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Senha correta");
                    break;
                }
                else
                {
                    tentativas++;
                    Console.WriteLine("Tentativas:" + tentativas + " de 3");
                }




            }
        }
    }
}
