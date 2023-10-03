using System;
using System.IO;

namespace _068_StructNullable_NullCoalescingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Struct Nullable
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default
            // StructNullable();

            // 2. the null-coalescing operators
            NullCoalescing();

            void NullCoalescing()
            {
                int? a = null;
                if (a is null)
                    a = 5;
                Console.WriteLine($"Remove null with an if {a}\n");
                // Output: 5

                int? b = null;
                int? c = null;
                b ??= c ?? 55;
                Console.WriteLine($"Remove null: Coalescing Operator {b}");
                // Output: 55
            }

            void StructNullable()
            {
                // Nullable<double> x = null; 
                // OU
                double? x = null;
                double? y = 10.0;

                Console.WriteLine("x = null");
                Console.WriteLine("y = 10.0");
                // Nullable tem metodos básicos:
                //  GetValueOrDefault()
                //  HasValue()
                //  Value()

                // Se valor não existir, usa o valor por default
                Console.WriteLine();
                Console.WriteLine("GetValueOrDefault: Mostra Valor por defeito, se null mostra 0");
                Console.WriteLine(x.GetValueOrDefault()); // 0
                Console.WriteLine(y.GetValueOrDefault()); // 10.0

                Console.WriteLine();
                Console.WriteLine("HasValue: Mostra Valor lógico");
                Console.WriteLine(x.HasValue); // False
                Console.WriteLine(y.HasValue); // True

                Console.WriteLine();
                Console.WriteLine("Value: Mostra Valor da variável");
                if (x.HasValue)
                    Console.WriteLine(x.Value);
                else
                    Console.WriteLine("X is null");
                if (y.HasValue)
                    Console.WriteLine(y.Value);
                else
                    Console.WriteLine("Y is null");
            }
 
        }
    }
}
