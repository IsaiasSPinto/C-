using System.Globalization;
using SegundoProblema;

Produto p = new Produto();

Console.WriteLine("Entre os Dados do produto");


Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preco: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + p);

Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("Dados atualizados: " + p);

Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine("Dados atualizados: " + p);




