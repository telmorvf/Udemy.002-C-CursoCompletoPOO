using System;

namespace _073._1_Modificador_Ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // forma de forçar por referencia de memoria as
            // variáveis não complexas
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
