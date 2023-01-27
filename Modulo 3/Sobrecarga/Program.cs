using System.Globalization;
using Sobrecarga;


Console.WriteLine("Entre os Dados do produto");

Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preco: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Produto p = new Produto(nome, preco);

Produto p1 = new Produto("TV", 500.00, 10);

Produto p2 = new Produto();

Produto p3 = new Produto {
    Nome = "TV", 
    Preco = 500.00, 
    Quantidade = 20 
};

Console.WriteLine("Dados do produto: " + p);

Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("Dados atualizados: " + p);

Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine("Dados atualizados: " + p);