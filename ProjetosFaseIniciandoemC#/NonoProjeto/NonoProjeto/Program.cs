using System;

namespace NonoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            bool c = n < 10;
            bool c1 = n < 20;
            bool c2 = n == 10;
            bool c3 = n > 5;

            Console.WriteLine(c);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);

            Console.WriteLine("-----------------------------");

            bool c4 = n <= 10;
            bool c5 = n >= 10;
            bool c6 = n == 10;
            bool c7 = n != 10;

            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);

        }
    }
}