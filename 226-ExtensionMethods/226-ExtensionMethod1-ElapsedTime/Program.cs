using System;

namespace ExtensionMethod1_ElapsedTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 2, 21, 8, 10, 45);
            Console.WriteLine($"Elapsed Time, between {dt} and {DateTime.Now}.");
            Console.WriteLine("Equals = " + dt.ElapsedTime());
        }
    }
}
