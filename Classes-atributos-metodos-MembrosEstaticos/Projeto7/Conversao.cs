using System.Globalization;

namespace Projeto7
{
    class Conversao
    {
        public static double Convertor(double cotacao, double total_pagar) {
            double total_pago = ((total_pagar * 0.06) + total_pagar) * cotacao;
            return total_pago;
        } 
    }
}
