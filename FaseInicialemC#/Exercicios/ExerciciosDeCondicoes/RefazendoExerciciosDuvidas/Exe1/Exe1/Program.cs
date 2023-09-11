using System;

namespace Exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial:");
            int hora_inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora final:");
            int hora_final = int.Parse(Console.ReadLine());

            int total;

            if (hora_inicial < 0 || hora_final < 0) {
                
                Console.WriteLine("Ocorreu um erro na hora digitada");
            } 

            else if (hora_final > hora_inicial)
            {
                total = hora_final - hora_inicial;
                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }

             else if (hora_inicial > 0 && hora_final < 24)
            {
                total = hora_final - hora_inicial + 24;
                 Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
             }

            else if (hora_inicial == 0 && hora_final == 0)
            {
                total = (hora_final + hora_inicial) + 24;
                Console.WriteLine($"O JOGO DUROU {total} HORA(S)");
            }


        }
    }
}