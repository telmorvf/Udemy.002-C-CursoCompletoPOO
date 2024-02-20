using System;
using System.Collections.Generic;

namespace _215_GENERIC_T_Restrictions.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            T max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                // Com o Generic<T>, não posso fazer comparações, mesmo comparando inteiros
                // tenho de usar o IComparable
                // IComparable results; [-1, 0, 1]
                // -1 = menor
                // 0 são iguais
                // 1 = maior
                if (list[i].CompareTo(max) > 0) 
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
