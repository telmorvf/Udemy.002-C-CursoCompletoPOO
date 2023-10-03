using System;
using System.Globalization;

namespace _069_Vetores_Part1_Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indique o valor de posições do Array: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Indique o {i+1}º valor: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
