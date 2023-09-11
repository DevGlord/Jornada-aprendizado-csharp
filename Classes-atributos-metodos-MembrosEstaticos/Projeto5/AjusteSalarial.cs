using System.Globalization;


namespace Projeto5
{
    class AjusteSalarial
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            double tot = (Salario * porcentagem / 100.0) + Salario;     
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}\n";
                 
        }
    }
}
