using System;
using System.Globalization;
using Modulo_2;
// sem OOP
double xA, xB, xC, yA, yB, yC;

Console.WriteLine("Entre com as medidas do triângulo X");
xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y");
yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (xA + xB + xC) / 2.0;
double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2.0;
double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if(areaX > areaY) {
    Console.WriteLine("Maior área: X");
} else {
    Console.WriteLine("Maior área: Y");
}
// com OOP

Triangulo xT, yT;

xT = new Triangulo();
yT = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X");
xT.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xT.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
xT.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y");
yT.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yT.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
yT.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaTX = xT.Area();
double areaTY = yT.Area();

Console.WriteLine("Área de X = " + areaTX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaTY.ToString("F4", CultureInfo.InvariantCulture));

if(areaTX > areaTY) {
    Console.WriteLine("Maior área: X");
} else {
    Console.WriteLine("Maior área: Y");
}


