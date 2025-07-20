using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public static string PessoaMaisVelha(Pessoa p1 ,Pessoa p2)
        {
            if (p1.idade > p2.idade)
            {
                return ($"Pessoa mais velha é {p1.nome}");
            }

            else
            {
                return ($"Pessoa mais velha é {p2.nome}");
            }


        }


    }
}
