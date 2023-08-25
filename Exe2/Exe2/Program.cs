using System;
using System.Globalization;

namespace Exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Console.WriteLine("1- Cachorro Quente");
            Console.WriteLine("2- X-Salada");
            Console.WriteLine("3- X-Bacon");
            Console.WriteLine("4- Torrada simples");
            Console.WriteLine("5- Refrigerante");
            Console.WriteLine();
            Console.WriteLine("Digite o codigo do produto desejado:");
            Console.WriteLine();

            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do produto que deseja comprar:");
            int quantidade = int.Parse(Console.ReadLine());

            
            double total;
            if (codigo < 1 || codigo > 5)
            {
                Console.WriteLine("Código inválido!");
            }
            else if (codigo == 1)
            {
                total = quantidade * 4.00;
                Console.WriteLine($"Total: R${total.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine($"Total: R${total.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
                Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}