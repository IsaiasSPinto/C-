using System.Globalization;
using Exercicio;

Console.Write("Entre o número da conta: ");
int numeroDaConta = int.Parse(Console.ReadLine());

Console.Write("Entre o titular da conta: ");
string nomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
Boolean depositoInicial = Console.ReadLine().ToLower() == "s" ? true : false;

double saldoInicial = 0;

if(depositoInicial) {
    Console.Write("Entre o valor de depósito inicial: ");
    saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.WriteLine("\n");

Conta novaConta = new Conta(numeroDaConta,nomeTitular,saldoInicial);

Console.WriteLine("Dados da conta: ");
Console.WriteLine(novaConta + "\n");

Console.Write("Entre um valor para deposito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

novaConta.Depositar(deposito);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(novaConta + "\n");

Console.Write("Entre um valor para saque: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

novaConta.Sacar(saque);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(novaConta);



