namespace SegundoProblema
{
    public class Produto
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public override string ToString()
        {
            return Nome +
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
