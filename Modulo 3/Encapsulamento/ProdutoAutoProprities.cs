using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ProdutoAutoProprities
    {
        private string _nome;

        public double Preco { get; private set; }

        public int Quantidade { get; private set; }

        public ProdutoAutoProprities()
        {
        }

        public ProdutoAutoProprities(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nome = value;
                }
            }
        }

        public override string ToString()
        {
            return _nome +
            ", $ " +
            Preco
                .ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture) +
            ", " +
            Quantidade +
            " unidades, Total: $ " +
            ValorTotalEmEstoque()
                .ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
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
