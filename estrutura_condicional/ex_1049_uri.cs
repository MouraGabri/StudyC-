using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1049_uri
    {

        public static void Animal()
        {
            string texto01 = Console.ReadLine();
            string texto2 = Console.ReadLine();
            string texto3 = Console.ReadLine();



            if (texto01 == "vertebrado")
            {
                if (texto2 == "ave")
                {
                    if (texto3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }

                    else if (texto3 == "onivoro")
                    {
                        Console.WriteLine("pomba");

                    }
                }


                else if (texto2 == "mamifero")
                {
                    if (texto3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }

                    else if (texto3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");

                    }
                }
            }

            else if (texto01 == "invertebrado")
            {
                if (texto2 == "inseto")
                {
                    if (texto3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }

                    else if (texto3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");

                    }
                }

                else if (texto2 == "anelideo")
                {
                    if (texto3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }

                    else if (texto3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");

                    }
                }




            }


        }
    }
}
