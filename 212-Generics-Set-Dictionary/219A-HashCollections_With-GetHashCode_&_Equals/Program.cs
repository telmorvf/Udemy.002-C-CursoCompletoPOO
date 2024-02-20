using System;
using System.Collections.Generic;

namespace _219_HashCollections_With_GetHashCode___Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primeiro GetHashCode() e depois com Equals()
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Maria"));
        }
    }
}
