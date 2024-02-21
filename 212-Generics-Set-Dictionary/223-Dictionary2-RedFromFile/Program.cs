using System;
using System.Collections.Generic;
using System.IO;

namespace _223_Dictionary2_RedFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file name and extention \"in.txt\": ");
            string path = "../../../" + Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            //dictionary[candidate] =+ votes; // só soma o último
                            dictionary[candidate] += votes; // só soma todos
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    Console.WriteLine();
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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
