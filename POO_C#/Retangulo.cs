﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace estudosC_.POO_C_
{
    internal class Retangulo
    {

        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }


    }
}
