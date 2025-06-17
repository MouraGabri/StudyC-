using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.exercicios_gpt.ex_while
{
    internal class ex_while_9
    {
        

        public static void CaixaRegistradora()
        {
            Console.Write("Informe um valor:");
            double valor = double.Parse(Console.ReadLine());
            int qtdCompras = 0;
            double valorCompra = 0.0;


            while (valor != 0)
            {
                qtdCompras++;
                valorCompra += valor;
                Console.Write("Informe um valor:");
                valor = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Total de compras:" + qtdCompras);
            Console.WriteLine("Valor compras:" + valorCompra.ToString("F2"));



        }
    }
}
