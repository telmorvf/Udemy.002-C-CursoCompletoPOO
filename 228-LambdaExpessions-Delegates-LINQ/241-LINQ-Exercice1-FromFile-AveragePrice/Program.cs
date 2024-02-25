using System;
using System.IO;
using System.Globalization;
using _241_LINQ_Exercice1_FromFile_AveragePrice.Entities;
using System.Collections.Generic;
using System.Linq;

namespace _241_LINQ_Exercice1_FromFile_AveragePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = @"..\..\..\" + Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] file = sr.ReadLine().Split(",");

                    string name = file[0];
                    double price = double.Parse(file[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price : " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name) ;

            foreach (var line in names)
            {
                Console.WriteLine(line.Price + " = " + line.Name);
            }
        }
    }
}
