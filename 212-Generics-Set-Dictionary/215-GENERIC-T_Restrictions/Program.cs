using System;
using System.Globalization;
using System.Collections.Generic;
using _215_GENERIC_T_Restrictions.Entities;
using _215_GENERIC_T_Restrictions.Services;

namespace _215_GENERIC_T_Restrictions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Indique o \"produto, preço\": ");
                string[] vect = Console.ReadLine().Split(',');
                
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list); // <Product> is optional

            Console.Write("\nMax Price: ");
            Console.WriteLine(max);
        }
    }
}
