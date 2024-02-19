using System;

namespace _214_Generics2_ReusableWithOBJECT_Problem_TypeSafety_Performance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problema de Reuso, temos de andar a criar o print service para int, para strig, para produto, cliente, outras classes
            // Solução passar a usar o GENERIC 

            // "Alterando de int na classe para OBJECT" - atenção que deixamos de ter Type safety
            // por exemplo começar a somar strings, porque o utilizador introduziu strings em vez de´inteiros

            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                // call method AddValue from class PrintService
                printService.AddValue(x);
            }

            // fazer downCasting
            // se introduzir Inteiros no método First não há problema
            // e se introduzir strings, tenho um pproblema "TYPE SAFETY" DÁ ERRO DE COMPILAÇÃO
            // Mais os problemas de PERFORMANCE por causa do boxing e unboxing
            int a = (int)printService.First();
            int b = a + 2;
            Console.Write("First() + 2 = " + b + "\n");

            // call method Print from class PrintService
            printService.Print();

            // call method First from class PrintService
            Console.WriteLine("First: " + printService.First());
        }
    }
}
