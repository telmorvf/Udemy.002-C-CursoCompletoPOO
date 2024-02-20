using System;
using System.Collections.Generic;

namespace _217_HashSet_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            
            Console.WriteLine(set.Contains("Notebook") + "\n");
            
            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
