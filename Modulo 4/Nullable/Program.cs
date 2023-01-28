double? x = null;
double? y = 10;

//se null retorna o valor padrao do tipo
Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(y.GetValueOrDefault());

//retorna true or false
System.Console.WriteLine(x.HasValue);
System.Console.WriteLine(y.HasValue);

if(x.HasValue) {
    System.Console.WriteLine(x.Value);
} else {
    System.Console.WriteLine("X is null");
}

if(y.HasValue) {
    System.Console.WriteLine(y.Value);
} else {
    System.Console.WriteLine("Y is null");
}

double a = x ?? 5;
double b = y ?? 5;

System.Console.WriteLine(a);
System.Console.WriteLine(b);







