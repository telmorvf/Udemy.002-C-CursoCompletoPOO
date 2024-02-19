using System;
using System.IO;

namespace _195_DemoFileClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // c:\...\195-DemoFileInfoClass\bin\Debug\net5.0\
            string sourcePath = @"..\..\..\file1.txt";
            string targetPath = @"..\..\..\file2.txt";
            try
            {
                //#File Class
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
