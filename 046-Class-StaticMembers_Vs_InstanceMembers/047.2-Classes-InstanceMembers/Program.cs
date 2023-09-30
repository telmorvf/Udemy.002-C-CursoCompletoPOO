using System;
using System.Globalization;

namespace _047._2_Classe_MembrosInstancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}