using System.Globalization;
using Exercicio_2;

System.Console.WriteLine("How many employees will be registered?");

int numberOfEmployees = int.Parse(Console.ReadLine());

List<Emplyoee> employoees = new();

for (int i = 0; i < numberOfEmployees; i++)
{
    System.Console.WriteLine($"Employoee #{i + 1}");
    System.Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Emplyoee emplyoee = new Emplyoee(id, name, salary);

    employoees.Add(emplyoee);
}

System.Console.WriteLine("Enter the employee id that will have salary increase : ");
int selectedId = int.Parse(Console.ReadLine());

Emplyoee selectedEmployoee = employoees.Find(x => x.Id == selectedId);

if (selectedEmployoee == null)
{
    System.Console.WriteLine("This id does not exist!");
}
else
{
    System.Console.WriteLine("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    selectedEmployoee.increaseSalary(percentage);
}

System.Console.WriteLine("Updated list of employees: ");
foreach (Emplyoee employoee in employoees)
{
    System.Console.WriteLine(employoee);
}