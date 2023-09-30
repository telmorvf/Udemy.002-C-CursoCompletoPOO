using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace _048_Exercicios_StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais = " 
                + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
