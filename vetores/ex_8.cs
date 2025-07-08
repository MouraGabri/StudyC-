using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace estudosC_.vetores
{
    internal class ex_8
    {
        public static void AlunosAprovados()
        {
            Console.Write("QTD de Alunos:");
            int N = int.Parse(Console.ReadLine());
            string[] alunos = new string[N];
            double[] nota1Semestre = new double[N];
            double[] nota2Semestre = new double[N];
            double mediaFinal = 0.0;

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Write("Informe um Aluno:");
                string[] nomes = Console.ReadLine().Split(" ");
                string nome = nomes[0];
                double nota1 = double.Parse(nomes[1], CultureInfo.InvariantCulture);
                double nota2 = double.Parse(nomes[2], CultureInfo.InvariantCulture);

                alunos[i] = nome;
                nota1Semestre[i] = nota1;
                nota2Semestre[i] = nota2;

            }

            for (int i = 0; i < alunos.Length; i++)
            {
                mediaFinal = (nota1Semestre[i] + nota2Semestre[i]) / 2.0;
                mediaFinal = Math.Round(mediaFinal, 2);
                if (mediaFinal >= 6.0)
                {
                    //Console.WriteLine("Alunos Aprovados:");
                    Console.WriteLine(alunos[i]);
                }
            }
        }
    }
}






