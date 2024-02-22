using _234_Delegates5_Func_LINQ_Select.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _234_Delegates5_Func_LINQ_Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 100.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // 1. Por referência directa para o método
            // Reference Method
            List<string> result1 = list.Select(NameUpper).ToList();

            // 2. sem referência directa para o método
            // Variable to reference method
            Func<Product, string> func = NameUpper; // Declarar um Delegate 
            List<string> result2 = list.Select(func).ToList();

            // 3. Version with Lambda Expression
            Func<Product, string> func3 = p => p.Name.ToUpper();
            List<string> result3 = list.Select(func3).ToList();

            // 4. Version with Lambda Expression - In Line
            List<string> result4 = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result4) // Alterar o result 1, 2, 3, 4
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
