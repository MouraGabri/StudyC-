using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class TestarProduto
    {

        public static void ExecutarProduto()
        {
            Produto pdt;
            pdt = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome:");
            pdt.nome = Console.ReadLine();
            Console.Write("Preço:");
            pdt.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque:");
            pdt.quantidade = int.Parse(Console.ReadLine());
        }


    }
}
