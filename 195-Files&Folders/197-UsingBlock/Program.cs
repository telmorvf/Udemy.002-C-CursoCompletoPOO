using System;
using System.IO;

namespace _197_UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormaCompleta();

            FormaSimples();

            void FormaCompleta()
            {
                string path = @"file1.txt";
                try
                {
                    // Desta forma o recurso é automaticamente fechado
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            while (!sr.EndOfStream)
                            {
                                string line = sr.ReadLine();
                                Console.WriteLine(line);
                            }
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
            }

            void FormaSimples()
            {
                string path = @"file1.txt";
                try
                {
                    // Desta forma o recurso é automaticamente fechado
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
            }
        }
    }
}
