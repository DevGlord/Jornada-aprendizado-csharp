using System;
using System.Globalization;

namespace Projeto3
{
     class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        

        public double ValorTotalemEstoque()
        {
           return Preco * Quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}, " +
                $"$ {Preco.ToString("F2",CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} Unidades, " +
                $"Total: {ValorTotalemEstoque()}"; 
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
