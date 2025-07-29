using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.POO_C_
{
    internal class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public override string ToString()
        {
            return $"Dados do Produto: {nome}, ${preco.ToString("F2", CultureInfo.InvariantCulture)},{quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public double ValorTotalEmEstoque()
        {
            double result = preco * quantidade;
            return result;
        }

        public void AdicionarProdutos(int qtd)
        {
            quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            quantidade -= qtd;
            Console.WriteLine($"Dados atualizados: {nome}, ${preco.ToString("F2", CultureInfo.InvariantCulture)},{quantidade} unidades, Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }



}

