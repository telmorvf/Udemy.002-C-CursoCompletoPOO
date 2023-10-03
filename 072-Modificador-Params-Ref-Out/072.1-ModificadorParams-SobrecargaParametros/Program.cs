using System;

namespace _072_ModificadorParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma1 = Calculator1.Sum(2, 3);
            Console.WriteLine(soma1);

            int soma2 = Calculator1.Sum(2, 3, 4);
            Console.WriteLine(soma2);

            int soma4 = Calculator1.Sum(2, 3, 4, 5);
            Console.WriteLine(soma4);


        }
    }
}
