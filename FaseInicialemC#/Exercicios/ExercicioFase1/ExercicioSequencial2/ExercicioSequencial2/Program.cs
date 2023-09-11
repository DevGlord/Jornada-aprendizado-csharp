using System;
using System.Globalization;

namespace ExercicioSequencial2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Digite um valor para 'Raio':");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = pi * (raio * raio);

            Console.WriteLine($"O resultado da área é {area.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}