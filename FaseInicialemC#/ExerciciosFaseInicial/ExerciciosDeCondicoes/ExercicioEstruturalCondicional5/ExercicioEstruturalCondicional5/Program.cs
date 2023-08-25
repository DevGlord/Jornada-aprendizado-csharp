using System;
using System.Globalization;

namespace ExercicioEstruturalCondicional5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o código do produto:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a quantidade que deseja comprar:");
            int quantidade = int.Parse(Console.ReadLine());

            double total;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
                Console.WriteLine($"O total a pagar é R${total.ToString("F2",CultureInfo.InvariantCulture)}");
            }

            else if (codigo == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine($"O total a pagar é R${total.ToString("F2",CultureInfo.InvariantCulture)}");
            }

            else if (codigo == 3)
            {
                total = quantidade * 5.00;
                Console.WriteLine($"O total a pagar é R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else if (codigo == 4) {
                total = quantidade * 2.00;
                Console.WriteLine($"O total a pagar é R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            else if (codigo == 5)
            {
                total = quantidade * 1.50;
                Console.WriteLine($"O total a pagar é R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro com o código digitado.");
            }
        }
    }
}