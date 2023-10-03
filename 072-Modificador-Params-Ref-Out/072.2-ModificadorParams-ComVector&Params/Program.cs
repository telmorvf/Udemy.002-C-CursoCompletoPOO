using System;

namespace _072_ModificadorParams_ComVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Com Vector e SEM o Modificador Params           
            int result1 = Calculator2.Sum(new int[] { 10, 20, 30, 40 });     
            Console.WriteLine(result1);


            // Com Vector e COM o Modificador Params
            int result2 = Calculator2.SumParams( 1, 2, 3, 4, 5, 6, 7, 8 );
            Console.WriteLine(result2);
        }
    }
}
