using System;
using System.Globalization;

namespace ExercicioSequencial6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o segundo número:");
            double b = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o terceiro número:");
            double c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            double triangulo = a * (c / 2);
            double circulo = Math.PI * (c * c);
            double trapezio = (a + b) * (c / 2);
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine($"TRIANGULO:{triangulo.ToString("F2",CultureInfo.InvariantCulture)} ");
            Console.WriteLine($"Circulo:{circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3",CultureInfo.InvariantCulture)}");
        }
    }
}