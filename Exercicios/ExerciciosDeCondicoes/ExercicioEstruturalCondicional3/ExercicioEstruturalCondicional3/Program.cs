using System;

namespace ExercicioEstruturalCondicional3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor inteiro:");
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}