using System;
using System.Diagnostics;
using System.IO;

namespace _195_DemoFileInfoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // c:\...\195-DemoFileInfoClass\bin\Debug\net5.0\
            string sourcePath = @"file1.txt";
            string targetPath = @"file2.txt";
            try
            {
                //#FileInfo Class - énecesário instaciar o FileInfo, aumenta a performance e é recomendado para grandes projetos/ profisionais

                //#File - Para ~um programa mais simples

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
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
