using System.Globalization;

namespace Exercicio_2
{
    public class Emplyoee
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public double Salary { get; private set; }

        public Emplyoee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }
    }
}
