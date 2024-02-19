using System;
using System.Collections.Generic;
using System.IO;
using _211A_OrdenarLista_LerDeFile.CSV.Entities;

namespace _211A_OrdenarLista_LerDeFile.CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Projects\001-Udemy\002-C#CursoCompletoPOO\203-Interfaces\211B-IComparable-COM-OrdenarLista-LerDeFile.CSV\in.csv";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    Console.WriteLine("1. Lista Original:");
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }

                   list.Sort();

                    Console.WriteLine("\n2. Lista Ordenada:");
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }

                   Console.ReadLine();
                    Console.ReadLine();
                    Console.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
