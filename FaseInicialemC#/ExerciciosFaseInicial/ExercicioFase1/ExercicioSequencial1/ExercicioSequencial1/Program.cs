using System;

namespace ExercicioSequencial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva outro número:");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = n1 + n2;

            Console.WriteLine($"SOMA = {n3}");
        }
    }
}
