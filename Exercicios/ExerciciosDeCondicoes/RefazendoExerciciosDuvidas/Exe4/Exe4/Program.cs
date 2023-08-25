using System;
using System.Globalization;

namespace Exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lisarb Country");

            Console.WriteLine("Digite o valor do seu salário para calcular o imposto:");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double taxa;

            if (salario > 0.0 && salario <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.0)
            {
                taxa = (salario - 2000) * 0.08;
                Console.WriteLine($"Imposto: R${taxa.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else if (salario <= 4500.0)
            {
                taxa = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"Imposto: R${taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salario > 4500.0)
            {
                taxa = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine($"Imposto: R${taxa.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}