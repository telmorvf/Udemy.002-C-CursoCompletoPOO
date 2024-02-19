using System;

namespace _214_Generics2_ReusableWithGENERIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema de Reuso, temos de andar a criar o print service para int, para strig, para produto, cliente, outras classes
            // Solução passar a usar o GENERIC MAS COM TYPE T

            // "Alterando de int na classe para TYPE T com Type Safety e Performance
            // ou instanciar e inicializar, tenho de escolher sempre o type <int>, <string>

            // IMPORTANT - Nos Métodos não esquecer o TYPE T
            //
            // Class: PrintService<T>
            // Método: public void AddValue(T value) { ... }

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                // call method AddValue from class PrintService
                printService.AddValue(x);
            }

            int a = printService.First();
            int b = a + 2;
            Console.Write ("First() + 2 = " + b + "\n");

            // call method Print from class PrintService
            printService.Print();

            // call method First from class PrintService
            Console.WriteLine("First: " + printService.First());
        }
    }
}
