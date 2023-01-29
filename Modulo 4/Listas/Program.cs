List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");

list.Insert(2,"Marco");

foreach(string name in list) {
    System.Console.WriteLine(name);
}

System.Console.WriteLine("List count: " + list.Count);

string s1 = list.Find(x => x[0] == 'A');

System.Console.WriteLine("First 'A': " + s1);

string s2 = list.FindLast(x => x[0] == 'A');

System.Console.WriteLine("First 'A': " + s2);

int i1 = list.FindIndex(x => x[0] == 'A');

System.Console.WriteLine("First 'A': " + i1);

int i2 = list.FindLastIndex(x => x[0] == 'A');

System.Console.WriteLine("First 'A': " + i2);

System.Console.WriteLine("------------------------------------------");

List<string> list2 = list.FindAll(x => x.Length == 5);

foreach(string name in list2) {
    System.Console.WriteLine(name);
}

list.Remove("Alex");
System.Console.WriteLine("------------------------------------------");
foreach(string name in list) {
    System.Console.WriteLine(name);
}

list.RemoveAll(x => x[0] == 'M');
System.Console.WriteLine("------------------------------------------");
foreach(string name in list) {
    System.Console.WriteLine(name);
}



