using System;

namespace _013_LogicaDeProgramacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; 
            float n5 = 4.5f;
            double n6 = 4.5;
            String nome = "Maria Green";
            Object obj1 = "Alex Brown";
            Object obj2 = 4.5f;

            int n11 = int.MinValue;
            int n12 = int.MaxValue;
            int n13 = sbyte.MinValue;
            int n14 = sbyte.MaxValue;
            decimal n15 = decimal.MinValue;
            decimal n16 = decimal.MaxValue;

            Console.WriteLine($"{completo.GetType()} \t {completo}");
            Console.WriteLine($"{genero.GetType()} \t {genero}");
            Console.WriteLine($"{letra.GetType()} \t {letra}");
            Console.WriteLine($"{n1.GetType()} \t {n1}");
            Console.WriteLine($"{n2.GetType()} \t {n2}");
            Console.WriteLine($"{n3.GetType()} \t {n3}");
            Console.WriteLine($"{n4.GetType()} \t {n4}");
            Console.WriteLine($"{n5.GetType()} \t {n5}");
            Console.WriteLine($"{n6.GetType()} \t {n6}");
            Console.WriteLine($"{nome.GetType()} \t {nome}");
            Console.WriteLine($"{obj1.GetType()} \t {obj1}");
            Console.WriteLine($"{obj2.GetType()} \t {obj2}");

            Console.WriteLine();
            Console.WriteLine($"{n11.GetType()} \t MinValue \t {n11}");
            Console.WriteLine($"{n12.GetType()} \t MaxValue \t {n12}");
            Console.WriteLine($"{n13.GetType()} \t MinValue \t {n13}");
            Console.WriteLine($"{n14.GetType()} \t MaxValue \t {n14}");
            Console.WriteLine($"{n15.GetType()} \t MinValue \t {n15}");
            Console.WriteLine($"{n16.GetType()} \t MaxValue \t {n16}");
        }
    }
}
