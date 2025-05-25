    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    namespace estudosC_.estrutura_condicional
    {
        internal class ex_1048_uri
        {

            public static void AumentoDeSalario()
            {
                double aumentoSalario, salario;
                string desconto = "";
                double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (entrada >= 0 && entrada <= 400.00)
                {
                    desconto = "15 %";
                    aumentoSalario = entrada * 0.15;
                    salario = entrada + aumentoSalario;
                }

                else if (entrada >= 400.01 && entrada <= 800.00)
                {
                    desconto = "12 %";
                    aumentoSalario = entrada * 0.12;
                    salario = entrada + aumentoSalario;
                }

                else if (entrada >= 800.01 && entrada <= 1200.00)
                {
                    desconto = "10 %";
                    aumentoSalario = entrada * 0.10;
                    salario = entrada + aumentoSalario;
                }
                else if (entrada >= 1200.01 && entrada <= 2000.00)
                {
                    desconto = "7 %";
                    aumentoSalario = entrada * 0.07;
                    salario = entrada + aumentoSalario;
                }

                else
                {
                    desconto = "4 %";
                    aumentoSalario = entrada * 0.04;
                    salario = entrada + aumentoSalario;
                }

                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste Ganho: " + aumentoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em Percentual: " + desconto);




            }
        }
    }
