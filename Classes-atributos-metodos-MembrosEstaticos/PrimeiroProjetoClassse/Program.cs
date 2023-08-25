using System;

namespace PrimeiroProjetoClassse
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Dadospessoais primeiro, segundo;
            primeiro = new Dadospessoais();
            segundo = new Dadospessoais();


            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            primeiro.Nome = Console.ReadLine();

            Console.Write("Idade:");
            primeiro.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome:");
            segundo.Nome = Console.ReadLine();

            Console.Write("Idade:");
            segundo.Idade = int.Parse(Console.ReadLine());

            if (primeiro.Idade > segundo.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {primeiro.Nome}");
            }
            else if (primeiro.Idade == segundo.Idade)
            {
                Console.WriteLine("Têm a mesma idade");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {segundo.Nome}");
            }
            
        }
    }
}