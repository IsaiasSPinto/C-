using System.Globalization;

namespace Exercicio;

public class Conta
{
    public int NumeroDaConta { get; private set; }

    public string NomeTitular { get; set; }

    public double Saldo { get; private set; }

    public Conta(int numeroDaConta, string nomeTitular, double depositoInicial) {
        NumeroDaConta = numeroDaConta;
        NomeTitular = nomeTitular;
        Depositar(depositoInicial);
    }

    public override string ToString()
    {
        return $"Conta {NumeroDaConta}, Titular: {NomeTitular}, Saldo: $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}";
    }

 
    public void Depositar(double valor) {
        if(valor > 0) {
            Saldo += valor;
        }
    }

    public void Sacar (double valor) {
        double taxa = 5;
        if(valor > 0) {
            Saldo -= valor + taxa;
        }
    }

}

