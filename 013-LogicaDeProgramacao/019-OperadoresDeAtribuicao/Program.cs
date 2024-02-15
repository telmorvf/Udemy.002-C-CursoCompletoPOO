using System;
using System.Security.Principal;

namespace _019_OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);
            
            a *= 3;
            Console.WriteLine(a);

            Console.WriteLine("--------------------");
            Console.WriteLine("-- Também funciona com string");

            int c = 'A';
            int i = (int)c;
            i = i + 3;
            Console.WriteLine("A + 3 = " + (char)i);


            Console.WriteLine("--------------------");

            string s = "ABC";
            Console.WriteLine(s);
            
            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("--------------------");

            a = 10;
            a++;
            Console.WriteLine("a=10");
            Console.WriteLine("a++");
            Console.WriteLine("A = " + a);
            Console.WriteLine();

            a = 10;
            int b = a++;
            Console.WriteLine("a=10 and b=a++");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine();

            a = 10;
            b = ++a;
            Console.WriteLine("a=10 and b=++a");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);

        }
    }
}
