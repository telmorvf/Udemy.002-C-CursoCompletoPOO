﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_Generics2_ReusableWithOBJECT_Problem_TypeSafety_Performance
{
    internal class PrintService
    {
        private object[] _values = new object[10];

        private int _count = 0;

        public void AddValue(object value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is Full!");
            }
            _values[_count] = value;
            _count++;
        }

        public object First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is Empty!");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.WriteLine(_values[_count - 1] + "]");
            }

        }
    }
}
