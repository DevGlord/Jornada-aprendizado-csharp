using System;
using System.Globalization;

namespace Exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número com casa decimal:");
            double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (numero < 0 || numero > 100)
            {
                Console.WriteLine("Fora do Intervalo");
            }
            else if (numero > 0.0 && numero <= 25.0)
            {
                Console.WriteLine("Intervalo ([0,25])");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo ([25,50])");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo ([50,75])");
            }
            else if (numero <= 100.0)
            {
                Console.WriteLine("Intervalo ([75,100])");
            }
        }
    }
}
