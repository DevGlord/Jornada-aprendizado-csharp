using System.Globalization;

namespace ConsoleApp2
{
    class NotaFinal
    {
        // Criar atributos para ajudar
        public string Nome;
        
        // Criar as funções
        public void Calculo(double n1, double n2, double n3)
        {
            double nota = n1 + n2 + n3;

            if (nota >= 60.00 && nota <= 100.00)
            {
                Console.WriteLine($"NOTA FINAL = {nota.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
            
            else if (nota < 60.00 && nota >= 0.00)
            {
                double notas = 60 - nota;
                Console.WriteLine($"NOTA FINAL = {nota.ToString("F2",CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {notas.ToString("F2",CultureInfo.InvariantCulture)} PONTOS PARA PASSAR DE ANO");
            }
            else
            {
                Console.WriteLine("OCORREU UM ERRO, A NOTA NÃO PODE SER MAIOR QUE 100.00");
            }
        }
        

    }
}
