using System;

namespace DecimoPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora  < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora >= 18 && hora <= 23)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("Ocorreu um erro na hora digitada!");
            }
        }

    }
}