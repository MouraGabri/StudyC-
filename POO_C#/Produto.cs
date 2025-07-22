using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void AdicionarProdutos(int quantidade)
        {

        }

        public static void RemoverProdutos(int quantidade)
        {

        }

    }



}

