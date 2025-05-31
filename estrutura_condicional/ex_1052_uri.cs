using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.estrutura_condicional
{
    internal class ex_1052_uri
    {

        public static void Mes()
        {
            int entrada = int.Parse(Console.ReadLine());
            string awnser = " ";
            switch (entrada)
            {

                case 1:
                    {
                        awnser = "Janeiro";
                        break;
                    }
                case 2:
                    {
                        awnser = "Fevereiro";
                        break;
                    }
                case 3:
                    {
                        awnser = "Março";
                        break;
                    }
                case 4:
                    {
                        awnser = "Abril";
                        break;
                    }
                case 5:
                    {
                        awnser = "Maio";
                        break;
                    }
                case 6:
                    {
                        awnser = "Junho";
                        break;
                    }
                case 7:
                    {
                        awnser = "Julho";
                        break;
                    }
                case 8:
                    {
                        awnser = "Agosto";
                        break;
                    }

                case 9:
                    {
                        awnser = "Setembro";
                        break;
                    }
                case 10:
                    {
                        awnser = "Outubro";
                        break;
                    }
                case 11:
                    {
                        awnser = "Novembro";
                        break;
                    }
                case 12:
                    {
                        awnser = "Dezembro";
                        break;
                    }
                default:
                    {
                        awnser = "Mes nao cadastrado";
                        break;
                    }
            }

            Console.WriteLine(awnser);


        }
    }
}
