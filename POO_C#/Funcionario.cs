using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class Funcionario
    {

        public string Nome = "";
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto +=  SalarioBruto / (porcentagem / 10);
            Console.WriteLine($"Dados Atualizados: {Nome}, R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public override string ToString()
        {
            double salarioLiquido = SalarioLiquido();
            return $"Funcionário: {Nome}, R$ {salarioLiquido}";
        }


    }
}

