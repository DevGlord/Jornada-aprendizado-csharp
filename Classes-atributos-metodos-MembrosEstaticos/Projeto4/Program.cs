using System.Globalization;

namespace Projeto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo v1;
            v1 = new Retangulo();
            

            Console.WriteLine("Entre a largura e altura do rêtangulo:");
            v1.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            v1.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"{v1}");

        }
    }
}