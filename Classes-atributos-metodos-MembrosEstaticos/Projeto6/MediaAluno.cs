

namespace Projeto6
{
     class MediaAluno
    {
        public string Nome;
        public double Nota; 

        public void Media(double n1,double n2, double n3)
        {
            double media_final = (n1 + n2 + n3);
            if (media_final >= 60)
            {
                Console.WriteLine("Aprovado");
            }
            else if (media_final < 0)
            {
                Console.WriteLine("Ocorreu um erro na nota digitada.");
            }
            else
            {
                Console.WriteLine("Reprovado");
                double tot = (60.0 + media_final) ;
                double tot1 = tot - media_final; 
                Console.WriteLine($"Precisava de {tot1} pontos para aprovar.");
            }
        }
    }
}
