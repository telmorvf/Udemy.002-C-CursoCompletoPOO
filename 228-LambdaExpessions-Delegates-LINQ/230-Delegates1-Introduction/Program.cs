using System;
using _330_Delegates1_Introduction.Services;

namespace Course
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // BinaryNumericOperation op = CalculationService.Sum; //  ou
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            
            // double result = op(a, b); //  ou
            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
