using System;
using System.Globalization;

namespace Projeto
{
    class projeto
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 35.10392;
            string nome = "Manuel";

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");
        }
    }
}