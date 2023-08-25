using System;

namespace DecimoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool c1 = !(2 > 3) && (2 != 4);
            bool c2 = 4 == 5 || 4 < 3;
            bool c3 = !(4 < 1) && 1 > 10;

            bool c4 = c1 || c2 && c3;
            Console.WriteLine(c4);
        }
    }
}