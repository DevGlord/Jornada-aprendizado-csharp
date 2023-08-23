using System;

namespace ExercicioSequencial3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para 'A':");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para 'B':");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para 'C':");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para 'D':");
            int d = int.Parse(Console.ReadLine());

            int calculo = (a * b - c * d);
            Console.WriteLine($"Diferença = {calculo}");
        }
    }
}