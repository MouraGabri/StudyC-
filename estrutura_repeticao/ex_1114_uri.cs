using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_1114_uri
    {



        public static void SenhaCorreta()
        {
            int senhaCorreta = 2002;
            int senha = int.Parse(Console.ReadLine());

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
