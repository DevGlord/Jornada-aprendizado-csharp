using System;
using System.Globalization;

namespace ExercicioWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salário:");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double ajuste_salarial;

            if (salario <= 1700.0)
            {
                ajuste_salarial = salario + 300.0;
            }
            else
            {
                ajuste_salarial = salario + 200.0;
            }
            Console.WriteLine($"Novo salário: R${ajuste_salarial.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}