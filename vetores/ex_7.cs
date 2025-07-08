using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_7
    {
        public static void PessoaMaisVelha()
        {
            Console.Write("QTD de Nomes:");
            int nomes = int.Parse(Console.ReadLine());
            string[] pessoas = new string[nomes];
            int[] idadePessoas = new int[nomes];
            string nome = "";
            int idade = 0;
            int pessoaMaisVelha = idadePessoas[0];
            

            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.Write("Informe um nome:");
                nome = Console.ReadLine();
                Console.Write("Informe a idade:");
                idade = int.Parse(Console.ReadLine());
                pessoas[i] = nome;
                idadePessoas[i] = idade;
            }

            for (int i = 1; i < idadePessoas.Length; i++)
            {
                if (idadePessoas[i] > pessoaMaisVelha)
                {
                    pessoaMaisVelha = idadePessoas[i];
                    nome = pessoas[i];
                }
            }

            Console.WriteLine("Pessoa mais velha:" + nome);



        }
    }
}
