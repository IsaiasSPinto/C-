namespace Encapsulamento
{
    public class ProdutoPropreties
    {
        private string _nome;

        private double _preco;

        private int _quantidade;

        public ProdutoPropreties()
        {
        }

        public ProdutoPropreties(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
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

        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }

        public override string ToString()
        {
            return _nome +
            ", $ " +
            _preco
                .ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture) +
            ", " +
            _quantidade +
            " unidades, Total: $ " +
            ValorTotalEmEstoque()
                .ToString("F2",
                System.Globalization.CultureInfo.InvariantCulture);
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}
