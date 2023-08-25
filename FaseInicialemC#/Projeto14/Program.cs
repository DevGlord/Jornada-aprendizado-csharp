using System;

namespace DecimoQuartoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double resultado = Maior(a, b, c);
            double resultado2 = Menor(a, b, c);

            Console.WriteLine($"Maior: {resultado}");
            Console.WriteLine($"Menor: {resultado2}");
        }

        static int Maior(int n1, int n2, int n3)
        {
            int m;
            if (n1 > n2 && n1 > n3)
            {
                m = n1;
                
            }
            else if (n2 > n3)
            {
                m = n2;
                
            }
            else
            {
                m = n3;
                ;
            }
            return m;
        }

        static int Menor(int a, int b , int c)
        {
            int v;

            if (a < b && a < c)
            {
                v = a;
            }
            else if (b < c)
            {
                v = b;
            }
            else
            {
                v = c;
            }
            return v;
        }
    }
}