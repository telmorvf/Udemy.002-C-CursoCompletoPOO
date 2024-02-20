using System;
using System.Collections.Generic;

namespace _218_SortedSet_Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            Console.Write("Collection a: ");
            printCollection(a);
            Console.Write("Collection b: ");
            printCollection(b);
            Console.WriteLine();

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("Collection c union:        ");
            printCollection(c);
            
            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Collection d intersection: ");
            printCollection(d);
            
            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Collection c difference:   ");
            printCollection(e);
        }

        static void printCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
