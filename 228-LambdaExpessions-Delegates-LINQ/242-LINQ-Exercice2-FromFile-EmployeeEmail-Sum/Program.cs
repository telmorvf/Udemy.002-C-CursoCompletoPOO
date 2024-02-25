using System;
using System.IO;
using System.Numerics;
using System.Globalization;
using System.Collections.Generic;
using EmployeeEmail_Sum.Entities;
using System.Linq;


namespace EmployeeEmail_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file name with extension \"in.txt\": ");
            string path = @"..\..\..\" + Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream) 
                {
                    string[] line = sr.ReadLine().Split(",");

                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            var names = list.Where(p => p.Salary > minSalary).OrderBy(p => p.Email).ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name.Email);
            }

            var sumSalary = list.Where(p => p.Name.StartsWith("M")).Sum(p => p.Salary);
            Console.Write("\nSum of salary of people whose name starts with 'M': " + sumSalary.ToString(("F2"), CultureInfo.InvariantCulture));
        }
    }
}
