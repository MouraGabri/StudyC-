using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados.exercicios
{
    internal class ex_1008_uri
    {
        public static void salario()
        {
            int numberFuncionario = int.Parse(Console.ReadLine());
            int hoursFuncionario = int.Parse(Console.ReadLine());
            double salarayWork = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double calcSallary = hoursFuncionario * salarayWork;
            Console.WriteLine("NUMBER = " + numberFuncionario);
            Console.WriteLine("SALARY = U$ " + calcSallary.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
    }

