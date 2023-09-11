using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Posto de Combustível");
            Console.WriteLine("-----------");
            Console.WriteLine("1- Álcool");
            Console.WriteLine("2- Gasolina");
            Console.WriteLine("3- Diesel");
            Console.WriteLine("-----------");
            Console.Write("Digite um código:");

            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool += 1;
                }
                else if (codigo == 2)
                {
                    gasolina += 1;
                }
                else if (codigo == 3)
                {
                    diesel += 1;
                }
                codigo = int.Parse(Console.ReadLine());
            }                
            Console.WriteLine("Muito obrigado");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
