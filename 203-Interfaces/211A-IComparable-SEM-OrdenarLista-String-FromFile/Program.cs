using System;
using System.Collections.Generic;
using System.IO;

namespace _211A_OrdenarLista_LerDeFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Projects\001-Udemy\002-C#CursoCompletoPOO\203-Interfaces\211A-IComparable-SEM-OrdenarLista-String-FromFile\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }

                    Console.WriteLine("1. Lista Original:");
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }

                    list.Sort();

                    Console.WriteLine("\n2. Lista Ordenada:");
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
