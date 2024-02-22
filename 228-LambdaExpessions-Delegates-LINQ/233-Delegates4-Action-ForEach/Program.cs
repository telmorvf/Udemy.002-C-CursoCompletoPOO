using _233_Delegates4_Action_ForEach.Entities;
using System;
using System.Collections.Generic;

namespace _233_Delegates4_Action_ForEach
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

            // 1. Action representa um método void que recebe de 0 a 16 argumentos
            Action<Product> act1 = UpdatePrice;
            list.ForEach(act1);

            // 2. Action with Lambda Expression
            Action<Product> act2 = p => { p.Price += p.Price * 0.1; };
            list.ForEach(act2);

            // 3. Lambda Expression in line 
            list.ForEach(p => { p.Price += p.Price * 0.1; });

            // 4. Passar uma função como parâmetro de outra função "UpdatePrice" 
            list.ForEach(UpdatePrice);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        private static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
