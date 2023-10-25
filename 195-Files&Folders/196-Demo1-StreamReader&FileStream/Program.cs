using System;
using System.IO;

namespace _196_Demo1_StreamReader_FileStream
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
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                    sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
                Console.WriteLine();
            }

            void FormaSimples()
            {
                string path = @"file1.txt";

                StreamReader sr = null;
                try
                {
                    sr = File.OpenText(path);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                }
                Console.WriteLine();
            }
        }
    }
}
