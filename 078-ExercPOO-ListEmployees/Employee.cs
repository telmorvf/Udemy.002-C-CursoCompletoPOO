using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace _078_ExercicioPOO_ListFuncionarios
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double tax)
        {
            Salary += Salary * tax / 100;
        }

        public override string ToString()
        {
            return $"{Id}, "
                + $"{Name}, "
                + $"{Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
