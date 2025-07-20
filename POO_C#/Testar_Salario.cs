using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class Testar_Salario
    {

        public static void Executar()
        {
            Salario nome1, nome2;
            nome1 = new Salario();
            nome2 = new Salario();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            nome1.nome = Console.ReadLine();
            Console.Write("Salário:");
            nome1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            nome2.nome = Console.ReadLine();
            Console.Write("Salário:");
            nome2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(Salario.SalarioFuncionario(nome1, nome2));
        }
    }
}
