using System;

namespace DecimoSegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escopo e inicialização

            Console.WriteLine("Qual é o preço do produto que deseja comprar?");
            double preco = double.Parse(Console.ReadLine());
               
            // Em relação ao escopo, eu posso definir o desconto antes do if, como tbm posso definir dentro do if, so que 
            // irei perder algum tempo a escrever, mas não faz mal

            if (preco > 100)
            {
                double desconto = preco - (preco * 10 / 100); // Uma forma de desconto
                double desconto1 = preco * 0.1; // Outra forma de desconto
                Console.WriteLine(desconto1);
            }
        }
    }
}