using System;
using System.Globalization;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamar a classe
            // Criar as variaveis e fazer a instanciação

            InformacoesSalariais PrimeiroFuncionario, SegundoFuncionario;
            PrimeiroFuncionario = new InformacoesSalariais();
            SegundoFuncionario = new InformacoesSalariais();

            // Criar os dados do Primeiro Funcionário 

            Console.WriteLine("Dados do Primeiro funcionário:");

            Console.Write("Nome:");
            PrimeiroFuncionario.Nome = Console.ReadLine();

            Console.Write("Salário:");
            PrimeiroFuncionario.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Criar os dados do Segundo funcionário

            Console.WriteLine("Dados do Segundo funcionário:");

            Console.Write("Nome:");
            SegundoFuncionario.Nome = Console.ReadLine();
            
            Console.Write("Salário:");
            SegundoFuncionario.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Criar a média salárial dos dois funcionários

            double MediaSalarial = (PrimeiroFuncionario.Salario + SegundoFuncionario.Salario) / 2.0;
        
            //    | Média digital feita com sucesso |     -> FIM <-     | Obrigado por ver o código |
            Console.WriteLine($"Salário médio = {MediaSalarial.ToString("F2",CultureInfo.InvariantCulture)}");
        
        }
    }
}