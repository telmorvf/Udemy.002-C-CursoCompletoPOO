using _142_ExercicioProdutos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _142_ExercicioProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> prodList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op  = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Convert.ToString(Console.ReadLine());

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'C' || op == 'c')
                {
                    prodList.Add(new Product(name, price));
                }
                else if (op == 'U' || op == 'u') // used
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    prodList.Add(new UsedProduct(name, price, dateTime));
                }
                else if (op == 'I' || op == 'i') // 
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //double price1 = ImportedProduct.TotalPrice();
                    prodList.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.WriteLine("Common, used or imported (c/u/i)? ");
                }
            }
            Console.WriteLine($"\nPRICE TAGS:");

            foreach (Product prod in prodList)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
