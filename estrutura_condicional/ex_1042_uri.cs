using System;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1042_uri
    {
        public static void SortSimples()
        {
            string[] entrada = Console.ReadLine().Split();
            int n1 = int.Parse(entrada[0]);
            int n2 = int.Parse(entrada[1]);
            int n3 = int.Parse(entrada[2]);

            if (n1 < n2 && n1 < n3)
            {
                if (n2 < n3)
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                }
            }
            else if (n2 < n1 && n2 < n3)
            {
                if (n1 < n3)
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                    Console.WriteLine(n3);
                }
                else
                {
                    Console.WriteLine(n2);
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                }
            }
            else // n3 é o menor
            {
                if (n1 < n2)
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n1);
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n3);
                    Console.WriteLine(n2);
                    Console.WriteLine(n1);
                }
            }

            // Linha em branco
            Console.WriteLine();

            // Ordem original
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
        }
    }
}
