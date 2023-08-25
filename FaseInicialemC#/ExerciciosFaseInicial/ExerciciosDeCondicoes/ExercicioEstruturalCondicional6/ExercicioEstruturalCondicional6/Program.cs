using System;
using System.Globalization;

namespace ExercicioEstruturalCondicional6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            double num = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (num < 0.0 || num > 100)
            {
                Console.WriteLine("Fora de alcance");
            }
            else if (num < 25.0){
                Console.WriteLine("Intervalo (0,25])");
            }
            else if (num < 50.0 )
            {
                Console.WriteLine("Intervalo (25,50])");
            }
            else if (num < 75.0)
            {
                Console.WriteLine("Intervalo (50,75])");
            }
            else 
            {
                Console.WriteLine("Intervalo (75,100])");
            }
            
        }
    }
}