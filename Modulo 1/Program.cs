using System.Globalization;

namespace curso;

class Program
{
    static void Main(string[] args)
    {
        // Exercicios 1 - 1

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("SOMA = " + (n1 + n2));


        // Exercicios 1 - 2
        double pi = 3.14159;

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double area = pi * Math.Pow(raio, 2.0);

        Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

        // Exercicios 1 - 3

        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());

        int diferenca = (A * B - C * D);

        Console.WriteLine("DIFERENCA = " + diferenca);

        // Exercicios 1 - 4
        int numeroFuncionario = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salario = horasTrabalhadas * valorHora;

        Console.WriteLine("NUMBER = " + numeroFuncionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        // Exercicios 1 - 5
        Console.WriteLine("Digite o codigo da peca 1, quantidade de pecas 1 e valor unitario da peca 1");
        var peca1 = Console.ReadLine().Split(" ");
        Console.WriteLine("Digite o codigo da peca 1, quantidade de pecas 1 e valor unitario da peca 1");
        var peca2 = Console.ReadLine().Split(" ");

        double valorPeca1 = double.Parse(peca1[1], CultureInfo.InvariantCulture) * int.Parse(peca1[2]);
        double valorPeca2 = double.Parse(peca2[1], CultureInfo.InvariantCulture) * int.Parse(peca2[2]);

        double valorTotal = valorPeca1 + valorPeca2;

        Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        //Execicios 1 - 6
        double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double valor3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaTriangulo = valor1 * valor3 / 2.0;
        double areaCirculo = 3.14159 * Math.Pow(valor3, 2.0);
        double areaTrapezio = (valor1 + valor2) / 2.0 * valor3;
        double areaQuadrado = Math.Pow(valor2, 2.0);
        double areaRetangulo = valor1 * valor2;

        Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

    }

}

