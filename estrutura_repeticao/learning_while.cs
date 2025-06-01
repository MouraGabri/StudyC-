using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class learning_while
    {

        public static void While()
        {
            int x = int.Parse(Console.ReadLine());
            int soma = 0;

            while (x != 0)
            {
                soma += x;
                x = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(soma);
            Console.WriteLine();
        }
    }
}
