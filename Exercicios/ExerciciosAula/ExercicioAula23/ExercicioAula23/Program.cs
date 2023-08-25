using System;
using System.Globalization;

namespace NonoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome_completo = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numero_quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco_produtos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimo_nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"Nome completo: {nome_completo}");
            Console.WriteLine($"Número de Quartos: {numero_quartos}");
            Console.WriteLine($"Preço de um produto: R${preco_produtos.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Último nome: {ultimo_nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
