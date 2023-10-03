using System;
using System.Security.Cryptography;

namespace _073._1_Modificador_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usando o Modificador Out, para a saida de valores da função
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
    }
}
