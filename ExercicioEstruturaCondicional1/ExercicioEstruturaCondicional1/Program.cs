using System;

namespace ExercicioEstruturaCondicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                Console.WriteLine($"O número digitado {n1} é Positivo.");
            }

            else
            {
                Console.WriteLine($"O número digitado {n1} é Negativo.");
            }
        }
    }
}