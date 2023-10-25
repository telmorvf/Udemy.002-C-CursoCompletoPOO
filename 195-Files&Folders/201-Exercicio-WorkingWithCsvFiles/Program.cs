using _200_Exercicio_WorkingWithCsvFiles.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace _200_Exercicio_WorkingWithCsvFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"sourceFile.csv";
            string summaryPath = @"summaryFile.csv";

            OutputCSV lineCSV;
            List<string> listOut = new List<string>();

            // string product, double price, int quantity
            try
            {
                // Desta forma o recurso é automaticamente fechado
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] array = line.Split(";");

                        string product = array[0].ToString();
                        double price = double.Parse((array[1]),CultureInfo.InvariantCulture);
                        int quantity = int.Parse(array[2]);

                        lineCSV = new OutputCSV(product, price, quantity);
                        listOut.Add(Convert.ToString(lineCSV));
                    }
                }
                using (StreamWriter sw = new StreamWriter(summaryPath))
                {
                    foreach (string item in listOut)
                    {
                        sw.WriteLine(item);
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
