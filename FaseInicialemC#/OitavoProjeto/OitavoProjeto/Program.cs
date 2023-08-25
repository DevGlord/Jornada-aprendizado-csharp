using System;
using System.Globalization;

namespace OitavoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char n1 = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vec = Console.ReadLine().Split(' ');

            string nome = vec[0];
            char sexo = char.Parse(vec[1]);
            int idade = int.Parse(vec[2]);
            double altura = double.Parse(vec[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine();
            Console.WriteLine(n);
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} tem {idade} anos, sexo {sexo} com altura {altura.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}