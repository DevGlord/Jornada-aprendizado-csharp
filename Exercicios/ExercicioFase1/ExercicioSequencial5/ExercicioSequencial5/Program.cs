using System;
using System.Globalization;

namespace ExercicioSequencial5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código 1:");
            int c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças que quer:");
            int numero_pecas1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário da peça 1:");
            double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite o código 2:");
            int c2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças que quer:");
            int numero_pecas2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário da peça 2:");
            double preco2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double total1 = numero_pecas1 * preco1;
            double total2 = numero_pecas2 * preco2;
            double total = total1 + total2;

            Console.WriteLine();
            Console.WriteLine($"VALOR A PAGAR R${total.ToString("F2",CultureInfo.InvariantCulture)}");
            
        } 
    }
}