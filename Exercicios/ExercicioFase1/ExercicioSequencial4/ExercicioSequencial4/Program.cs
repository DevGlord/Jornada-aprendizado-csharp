using System;
using System.Globalization;

namespace ExercicioSequencial4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionário:");
            int numero_funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas do funcionário:");
            int horas_trabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quanto ele ganha por hora:");
            double salario_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas_trabalhadas * salario_hora;

            Console.WriteLine($"Número: {numero_funcionario}");
            Console.WriteLine($"Salário: U${salario.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}