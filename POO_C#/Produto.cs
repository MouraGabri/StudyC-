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


        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int qtd)
        {
            int valor = quantidade += qtd;
            Console.WriteLine($"Dados atualizados: {nome}, ${preco.ToString("F2", CultureInfo.InvariantCulture)},{quantidade} unidades, Total: ${valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void RemoverProdutos(int qtd)
        {
            int valor = quantidade -= qtd;
            Console.WriteLine($"Dados atualizados: {nome}, ${preco.ToString("F2", CultureInfo.InvariantCulture)},{quantidade} unidades, Total: ${valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }



}

