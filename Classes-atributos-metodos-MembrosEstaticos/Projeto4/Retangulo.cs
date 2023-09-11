using System;
using System.Globalization;

namespace Projeto4
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }
        public double Diagonal()
        {
            double larg = Math.Pow(Largura,2);
            double alt = Math.Pow(Altura, 2);
            double tot = larg + alt;
            return Math.Sqrt(tot);
        }

        public override string ToString()
        {
            return  $"Area = {Area().ToString("F2",CultureInfo.InvariantCulture)} \n" +
                    $"PERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)} \n" +
                    $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
