using System;
using System.Globalization;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();


            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome:");
            p.Nome =  Console.ReadLine();

            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque:");
            p.Quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Dados do produto: {p} ");
            Console.WriteLine();
            
            Console.Write("Digite o número de Produtos a ser adicionado no estoque:");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();

            Console.WriteLine($"Digite o número de produtos a ser removido do estoque:");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
            
        }
    }
}