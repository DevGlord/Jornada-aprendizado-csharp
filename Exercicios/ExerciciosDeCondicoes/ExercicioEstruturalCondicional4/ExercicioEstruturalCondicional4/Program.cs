using System;

namespace ExercicioEstruturalCondicional4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial:");
            int hora_inicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora final do jogo:");
            int hora_final = int.Parse(Console.ReadLine());

            int hora_total;

            if (hora_inicial < hora_final)
            {
                hora_total = hora_final - hora_inicial;
                Console.WriteLine($"O JOGO DUROU {hora_total} HORA(S)");
            }
            else
            {
                hora_total = 24 - hora_inicial + hora_final; 
                Console.WriteLine($"O JOGO DUROU {hora_total} HORA(S)");
            }
        }
    }
}