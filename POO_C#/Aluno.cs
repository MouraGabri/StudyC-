using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class Aluno
    {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public void AlunoAprovado()
        {
            double notaAprovado = 60.00;
            double somaNotas = Nota1 + Nota2 + Nota3;
            if (somaNotas >= notaAprovado)
            {
                Console.WriteLine($"Nota Final: {somaNotas.ToString("F2", CultureInfo.InvariantCulture)}\nAprovado");
            }
            else
            {
                double pontosFaltam = notaAprovado - somaNotas;
                Console.WriteLine($"Nota Final: {somaNotas.ToString("F2", CultureInfo.InvariantCulture)}\nReprovado\nFaltaram {pontosFaltam.ToString("F2", CultureInfo.InvariantCulture)} Pontos");

            }
        }

    }
}
