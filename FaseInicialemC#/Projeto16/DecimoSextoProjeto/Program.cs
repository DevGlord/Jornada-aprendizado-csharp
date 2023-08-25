using System;

namespace DecimoSextoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para efetuar a soma:");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Valor #{i}:");
                int n1 = int.Parse(Console.ReadLine());
                soma += n1;
            }
            Console.WriteLine($"Soma = {soma}");
        }
    }
}