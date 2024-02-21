using System;
using System.Collections.Generic;
using _228B_Comparation_T_ProblemSolved.Entities;

namespace _228B_Comparation_T_ProblemSolved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // DELEGATE - Referência para a função com type Safety
            // list.Sort(CompareProducts);

            // ou
            Comparison<Product> comp = CompareProducts;
            list.Sort(comp);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Recebe 2 objetos do tipo product e retorna um inteiro
        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
