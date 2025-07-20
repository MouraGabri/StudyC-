using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class Salario
    {

        public string nome;
        public double salario;

        public static string SalarioFuncionario(Salario func1, Salario func2)
        {
            double salarioMedio = (func1.salario + func2.salario) / 2;
            return $"Salário médio {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}";

        }





    }
}
