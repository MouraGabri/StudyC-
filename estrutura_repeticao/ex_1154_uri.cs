using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_1154_uri
    {
        public static void Idades()
        {
            int idade = int.Parse(Console.ReadLine());
            int somaIdade = 0;
            int totalPessoas = 0;
            while (idade > 0)
            {
                somaIdade += idade;
                totalPessoas ++;
                idade = int.Parse(Console.ReadLine());

            }
            double mediaIdade = (double) somaIdade / totalPessoas;
            Console.WriteLine(mediaIdade.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
