using System;
using System.Collections.Generic;
using _232_Delegates3_Predicate_RemoveAll.Entities;

namespace _232_Delegates3_Predicate_RemoveAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Lambda Exprecion
            // list.RemoveAll(p => p.Price >= 100); // Ou ...

            // Predicate Delegate, nome da função no parametro do RemoveAll()
            list.RemoveAll(ProductTeste);
            foreach (Product p in list) 
            {
                Console.WriteLine(p);
            }
        }

        private static bool ProductTeste(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}
