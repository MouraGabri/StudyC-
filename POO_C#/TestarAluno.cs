using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class TestarAluno
    {

        public static void ExecutarAluno()
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.AlunoAprovado();
        }
    }
}
