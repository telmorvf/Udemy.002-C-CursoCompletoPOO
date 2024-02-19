using System;

namespace _213_Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema de Reuso, temos de andar a criar o print service para int, para strig, para produto, cliente, outras classes
            // Solução passar a usar o GENERIC
            
            // Int
            // PrintService printService = new PrintService();
            
            // String
            PrintServiceString printService = new PrintServiceString();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // Int
                // int x = int.Parse(Console.ReadLine());
                
                // String
                string x = Console.ReadLine();

                // call method AddValue from class PrintService
                printService.AddValue(x);
            }

            // call method Print from class PrintService
            printService.Print();

            // call method First from class PrintService
            Console.WriteLine("First: " + printService.First());

        }
    }
}
