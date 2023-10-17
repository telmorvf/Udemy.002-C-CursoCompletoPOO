using _146_Inheritance_Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _146_Inheritance_Contribuintes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write($"Individual or company (i/c)?: ");
                char type = char.Parse(Console.ReadLine());

                Console.Write($"Name: ");
                string name = (Console.ReadLine());

                Console.Write($"Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i' || type == 'I')
                {
                    Console.Write($"Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name,anualIncome,health));
                }
                else if (type == 'c' || type == 'C')
                {
                    Console.Write($"Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, employees));
                }
                else
                {
                    return;
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAYED");
            double taxTotal = 0;
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name
                    + ": $ "
                    + tax.Tax().ToString("F2", CultureInfo.InvariantCulture));

                taxTotal += tax.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {taxTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
