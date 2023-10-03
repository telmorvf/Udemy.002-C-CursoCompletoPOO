using System;
using System.Globalization;

namespace _070_ClasseVetores_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique o valor de posições do Array: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Indique o {i + 1}º Nome: ");
                string name = Console.ReadLine();
                Console.Write($"Indique o {i + 1}º Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
