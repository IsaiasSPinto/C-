using Encapsulamento;

Produto p = new Produto("TV",500,10);

p.SetNome("TV 4k");

Console.WriteLine(p.GetNome());

Console.WriteLine(p.GetPreco());

Console.WriteLine(p.GetQuantidade());


ProdutoPropreties p2 = new ProdutoPropreties("TV",500,10);

p2.Nome = "TV 4k";

Console.WriteLine(p2.Nome);
Console.WriteLine(p2.Preco);
Console.WriteLine(p2.Quantidade);

ProdutoAutoProprities p3 = new ProdutoAutoProprities("TV",500,10);

p2.Nome = "TV Oled";

Console.WriteLine(p3.Nome);
Console.WriteLine(p3.Preco);
Console.WriteLine(p3.Quantidade);