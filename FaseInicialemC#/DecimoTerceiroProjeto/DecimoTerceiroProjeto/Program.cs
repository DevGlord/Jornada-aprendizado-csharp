using System;

namespace DecimoTerceiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n n3)
            {
                Console.WriteLine("N1 é maior");
            }
            else if (n2 > n1 > n3)
            {
                Console.WriteLine("N2 é maior");
            }
            else if (n3 > n2 > n1)
            {
                Console.WriteLine("N3 é maior");
            }
        }
    }
}