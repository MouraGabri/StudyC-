using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.entrada_dados
{
    internal class m01_entrada_dados
    {
        public static void Executar()
        {
            Console.WriteLine("Digite uma palavra com espaços entre cada uma:");
            string texto1 = Console.ReadLine();

            string p1 = texto1.Split(" ")[0];
            string p2 = texto1.Split(" ")[1];
            string p3 = texto1.Split(" ")[2];

            Console.WriteLine("Texto 1: " + p1 + "\nTexto 2: " + p2 + "\nTexto 3: " + p3);
        }

    }
}
