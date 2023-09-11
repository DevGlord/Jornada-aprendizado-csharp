using System.Globalization;

namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {
            AjusteSalarial p1;
            p1 = new AjusteSalarial();

            Console.Write("Nome:");
            p1.Nome = Console.ReadLine();

            Console.Write("Salário bruto:");
            p1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto:");

            p1.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Proxima fase

            Console.WriteLine($"Funcionário: {p1}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem:");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            p1.AumentarSalario(porcentagem);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {p1}");

        }
    }
}