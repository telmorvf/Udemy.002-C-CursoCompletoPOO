using System;
using System.IO;

namespace _199_Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"myfolder\";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(@"myfolder\newfolder\");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
