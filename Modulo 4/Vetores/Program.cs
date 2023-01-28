using System.Globalization;
using Vetores;

//Parte 1
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

double sum = 0;
for(int i = 0; i < n; i++) {
    vect[i] =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    sum += vect[0];
}

double media = sum / n;

System.Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

//Parte 2
System.Console.WriteLine("Quantos produtos serão cadastrados: ");
int productQuantity = int.Parse(Console.ReadLine());

Product[] products = new Product[productQuantity];

double totalPrice = 0;

for(int i = 0;i < productQuantity;i++) {
    System.Console.WriteLine("Entre com o nome do produto: ");
    string nome = Console.ReadLine();
    System.Console.WriteLine("Entre com o preço do produto: ");
    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    products[i] = new Product {
        Nome = nome,
        Valor = valor
    };

    totalPrice += products[i].Valor;
};

double avaragePrice = totalPrice / productQuantity;

System.Console.WriteLine("Average price = " + avaragePrice.ToString("F2", CultureInfo.InvariantCulture));

