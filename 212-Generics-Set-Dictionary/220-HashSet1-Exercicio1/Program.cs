using System;
using System.Collections.Generic;
using System.IO;
using _220_HashSet1_Exercicio1.Entities;

namespace _220_HashSet1_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file name and extention \"in.txt\": ");
            string path = "../../../" + Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");

                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant });
                        Console.WriteLine(line[0] + "\t\t" + line[1]);
                    }
                    Console.WriteLine("\nTotal unique users: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
