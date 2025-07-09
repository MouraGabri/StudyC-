using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace estudosC_.vetores
{
    internal class ex_9
    {
        public static void Alturas()
        {
            Console.Write("QTD de pessoas:");
            int nomes = int.Parse(Console.ReadLine());
            double[] pessoasAltura = new double[nomes];
            string[] sexo = new string[nomes];
            double altura = 0.0;
            string sexoPessoa = "";
            int contadorHomens = 0;
            int contadorMulheres = 0;


            double media = 0.0;
            double somaElementosMedia = 0.0;

            for (int i = 0; i < pessoasAltura.Length; i++)
            {
                Console.Write("Altura:");
                altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Sexo:");
                sexoPessoa = Console.ReadLine();
                pessoasAltura[i] = altura;
                sexo[i] = sexoPessoa.ToUpper();

            }
            double menorAltura = pessoasAltura[0];
            double maiorAltura = pessoasAltura[0];

            for (int i = 0; i < pessoasAltura.Length; i++)
            {
                if (pessoasAltura[i] > maiorAltura)
                {
                    maiorAltura = pessoasAltura[i];
                }
                if (pessoasAltura[i] < menorAltura)
                {

                    menorAltura = pessoasAltura[i];
                }

                if (sexo[i].ToString() == "F".ToString())
                {

                    somaElementosMedia += pessoasAltura[i];
                    contadorMulheres++;

                }
                else
                {
                    
                    contadorHomens++;
                }
            }
            //somaElementosMedia = Math.Round(somaElementosMedia, 2);
            if (contadorMulheres > 0)
            {
                media = somaElementosMedia / contadorMulheres;
            }
            else
            {
                media = 0.0;
            }

                Console.WriteLine("Menor altura:" + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura:" + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres:" + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens:" + contadorHomens);




        }
    }
}
