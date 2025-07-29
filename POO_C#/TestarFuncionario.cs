using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class TestarFuncionario
    {
        public static void Executar()
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome:");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto:");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(func.ToString());

            Console.Write("Digite a porcentagem para aumentar o salário:");
            func.AumentarSalario(double.Parse(Console.ReadLine()));


        }
    }
}
