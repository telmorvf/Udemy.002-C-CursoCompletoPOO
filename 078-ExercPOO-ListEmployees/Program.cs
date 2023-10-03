using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace _078_ExercicioPOO_ListFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}");
                
                Console.Write($"Id: ");
                int id = int.Parse(Console.ReadLine());
                
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                
                Console.Write($"Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

                Console.WriteLine();
                list.Add(new Employee(id, name, salary));
            }
            
            Console.Write("Enter the employee Id that will have salary increase, Id: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp == null)
            {
                Console.WriteLine($"This Id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double tax = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.IncreaseSalary(tax);
            }
            
            Console.WriteLine("\nUpdated list of employees:");
            foreach (Employee item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
