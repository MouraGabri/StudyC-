using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1050_uri
    {

        public static void DDD()
        {
            int entrada = int.Parse(Console.ReadLine());
            string awnser = " ";

            switch (entrada)
            {

                case 61:
                    {
                        awnser = "Brasilia";
                        break;
                    }
                case 71:
                    {
                        awnser = "Salvador";
                        break;
                    }
                case 11:
                    {
                        awnser = "Sao Paulo";
                        break;
                    }
                case 21:
                    {
                        awnser = "Rio de Janeiro";
                        break;
                    }
                case 32:
                    {
                        awnser = "Juiz de Fora";
                        break;
                    }
                case 19:
                    {
                        awnser = "Campinas";
                        break;
                    }
                case 27:
                    {
                        awnser = "Vitoria";
                        break;
                    }
                case 31:
                    {
                        awnser = "Belo Horizonte";
                        break;
                    }
                default:
                    {
                        awnser = "DDD nao cadastrado";
                        break;
                    }
            }
            Console.WriteLine(awnser);
        }
    }
}
