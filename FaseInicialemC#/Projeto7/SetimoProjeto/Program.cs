using System;

namespace SetimoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vector = Console.ReadLine().Split(' ');
            string p1 = vector[0];
            string p2 = vector[1];
            string p3 = vector[2];


            Console.WriteLine($"O Senhor {p1} tem {p2} anos e vive no {p3}");
        }
    }
}