

using System.Xml;

namespace Projeto6
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaAluno Aluno = new MediaAluno();
            MediaAluno n1 = new MediaAluno();
            MediaAluno n2 = new MediaAluno();
            MediaAluno n3 = new MediaAluno();

            Console.Write("Digite o nome do aluno:");
            Aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            n1.Nota = double.Parse(Console.ReadLine());
            n2.Nota = double.Parse(Console.ReadLine());
            n3.Nota = double.Parse(Console.ReadLine());

            Aluno.Media(n1.Nota,n2.Nota,n3.Nota);
            Console.WriteLine($"{Aluno}");
            


        }
    }
}