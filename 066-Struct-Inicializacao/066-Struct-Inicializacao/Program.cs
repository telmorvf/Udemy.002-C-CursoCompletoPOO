using System;

namespace _066_Struct_Inicializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);    
        }
    }
}
