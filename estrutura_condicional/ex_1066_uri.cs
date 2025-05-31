using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1066_uri
    {

        public static void TypesOfNumbers()
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int positivo = 0;
            int negativo = 0;
            int par = 0;
            int impar = 0;

            if (n1 == 0 | n2 == 0 | n3 == 0 | n4 == 0 | n5 == 0)
            {
                par += 1;
            }

            if (n1 > 0)
            {
                positivo += 1;

                if (n1 % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }

            else
            {
                if (n1 != 0)
                {
                    negativo += 1;
                    if (n1 % 2 == 0)
                    {
                        par += 1;
                    }
                    else
                    {
                        impar += 1;
                    }
                }
            }


            if (n2 > 0)
            {
                positivo += 1;

                if (n2 % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }

            else
            { if (n2 != 0) { 


                    negativo += 1;
                    if (n2 % 2 == 0)
                    {
                        par += 1;
                    }
                    else
                    {
                        impar += 1;


                    }
                }
            }


            if (n3 > 0)
            {
                positivo += 1;

                if (n3 % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }

            else
            {
                if (n3 != 0)
                {
                    negativo += 1;
                    if (n3 % 2 == 0)
                    {
                        par += 1;
                    }
                    else
                    {
                        impar += 1;
                    }
                }
            }



            if (n4 > 0)
            {
                positivo += 1;

                if (n4 % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }

            else
            {
                if (n4 != 0)
                {
                    negativo += 1;
                    if (n4 % 2 == 0)
                    {
                        par += 1;
                    }
                    else
                    {
                        impar += 1;
                    }
                }
            }


            if (n5 >= 0)
            {
                positivo += 1;

                if (n5 % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }

            else
            {
                if (n5 != 0)
                {
                    negativo += 1;
                    if (n5 % 2 == 0)
                    {
                        par += 1;
                    }
                    else
                    {
                        impar += 1;
                    }
                }
            }


            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");




        }
    }
}
