using System;

namespace ExercicioEstruturalCondicional2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine($"O número inteiro digitado {n1} é Par.");
            }
            
            else
            {
                Console.WriteLine($"O número inteiro digitado {n1} é Impar.");
            }
        }
    }
}