using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamar a função
            NotaFinal a1 = new NotaFinal();

            // Ler o nome e as notas de um aluno
            Console.Write("Nome do aluno:");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            double n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            a1.Calculo(n1, n2, n3);

            // Mostrar a nota final do aluno
            Console.WriteLine();
            Console.WriteLine($"NOTA FINAL = {a1.Calculo}");
            // Dizer se esta APROVADO OU REPROVADO
        }
    }
}