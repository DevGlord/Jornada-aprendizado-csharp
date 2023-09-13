using System.Globalization;

namespace Projeto7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar?");
            double total_comprar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double conversao = Conversao.Convertor(cotacao, total_comprar);

            Console.WriteLine($"Valor a ser pago em real: {conversao.ToString("F2",CultureInfo.InvariantCulture)}R$");
        }
    }
}