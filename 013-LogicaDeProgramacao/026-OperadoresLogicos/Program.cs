using System;

namespace _026_OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 || 4 != 5; // true
            bool c2 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine("c1 = 2 > 3 || 4 != 5;     " + c1);
            Console.WriteLine("c2 = !(2 > 3) && 4 != 5;  " + c2);
            
            Console.WriteLine("\n--------------------------------\n");
            
            bool c3 = 10 < 5; // false
            bool c4 = c1 || c2 && c3; // true
            Console.WriteLine("c3 = 10 < 5;               " + c3);
            Console.WriteLine("c4 = c1 || c2 && c3;       " + c4);
        }
    }
}
