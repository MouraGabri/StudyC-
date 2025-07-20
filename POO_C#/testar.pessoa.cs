using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudosC_.POO_C_;


namespace estudosC_.POO_C_
{
    internal class testar
    {
        public static void Executar()
        {
            Pessoa nome1, nome2;
            nome1 = new Pessoa();
            nome2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            nome1.nome = Console.ReadLine();
            Console.Write("Idade:");
            nome1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            nome2.nome = Console.ReadLine();
            Console.Write("Idade:");
            nome2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine(Pessoa.PessoaMaisVelha(nome1, nome2));
        }
    }
}