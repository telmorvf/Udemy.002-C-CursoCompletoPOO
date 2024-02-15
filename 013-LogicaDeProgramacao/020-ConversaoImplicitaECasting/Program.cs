using System;

namespace _020_ConversaoImplicitaECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;
            Console.WriteLine("Conversão Implicita: double (8 Bytes) <= float (4 Bytes)");
            Console.WriteLine($"4 Bytes \t float x  = 4.5f \t {x} \t");
            Console.WriteLine($"8 Bytes \t double y = x \t\t {y} \t Implicita");
            Console.WriteLine();


            double a = 5.1;
            float b = (float)a;
            Console.WriteLine("Conversão Casting: float (4 Bytes) <= double (8 Bytes)");
            Console.WriteLine("Posso perder informação por passar de 8 Bytes para 4 Bytes");
            Console.WriteLine($"8 Bytes \t double a  = 5.1 \t {a}");
            Console.WriteLine($"4 Bytes \t float b = (float)a \t {b} \t Casting");
            Console.WriteLine();


            double r;
            int s;
            Console.WriteLine("Conversão explicita: double (8 Bytes) <= int (4 Bytes)");
            Console.WriteLine("Perco a casa decimal porque converto com Casting de double (8 Bytes) para int (4 Bytes) ");
            r = 5.1;
            s = (int)r;
            Console.WriteLine($"8 Bytes \t double r  = 5.1 \t {r} \t ");
            Console.WriteLine($"4 Bytes \t int s = (int)r \t {s} \t Casting");
            Console.WriteLine();


            int c = 5;
            int d = 2;
            Console.WriteLine("Divisão com dois inteiros: c = 5 int (4 Bytes) / d = 2 int (4 Bytes)");
            double resultado1 = (double)c / d;
            Console.WriteLine($"double resultado = (double)c / d = \t {resultado1} \t Casting");
            double resultado2 = c / d;
            Console.WriteLine($"double resultado =         c / d = \t {resultado2} \t Implicita");

        }
    }
}
