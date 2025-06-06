using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_repeticao
{
    internal class ex_1134_uri
    {
        public static void Combustivel()
        {
            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool += 1;
                    codigo = int.Parse(Console.ReadLine());
                }
                else if (codigo == 2)
                {
                    gasolina += 1;
                    codigo = int.Parse(Console.ReadLine());
                }
                else if (codigo == 3)
                {
                    diesel += 1;
                    codigo = int.Parse(Console.ReadLine());
                }
                else
                {
                    codigo = int.Parse(Console.ReadLine());
                }



            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);


        }
    }
}
