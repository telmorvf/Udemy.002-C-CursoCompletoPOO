using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _073._1_Modificador_Ref
{
    internal class Calculator
    {
        internal static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
