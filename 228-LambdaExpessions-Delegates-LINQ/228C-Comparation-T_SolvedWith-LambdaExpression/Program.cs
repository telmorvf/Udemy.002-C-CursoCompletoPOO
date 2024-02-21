using _228C_Comparation_T_SolvedWith_LambdaExpression.Entities;
using System;
using System.Collections.Generic;

namespace _228C_Comparation_T_SolvedWith_LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //list.Sort(comp);

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            list.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}

