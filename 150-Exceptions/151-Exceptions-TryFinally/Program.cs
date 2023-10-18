using System;
using System.IO;

namespace _151_Exceptions_TryFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch  (Exception e) // if path not found
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
