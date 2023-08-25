using System;
using System.Globalization;

namespace ExercicioEstruturalCondicional8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor decimal:");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.00)
            {
                imposto = 0.0;
                Console.WriteLine("Isento");
            }

            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.0) * 0.08;
                Console.WriteLine($"Imposto de 8%, valor final com o imposto: R${imposto.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else if(salario <= 4500)
            {
                imposto = salario * 0.18 + 1000 * 0.08;
                Console.WriteLine($"Imposto de 18%, valor final com o imposto: R${imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else
            {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000.0 * 0.08;
                Console.WriteLine($"Imposto de 28%, valor final com o imposto: R${imposto.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
