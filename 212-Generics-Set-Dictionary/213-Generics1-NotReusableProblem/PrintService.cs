﻿using System;
using System.Runtime.Serialization;

namespace _213_Generics1
{
    internal class PrintService
    {
        private int[] _values = new int[10];

        private int _count = 0;

        public void AddValue(int value)
        {
            if(_count == 10) 
            {
                throw new InvalidOperationException("PrintService is Full!");
            }
            _values[_count] = value;
            _count++;
        }

        public int First() 
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
            for (int i = 0; i < _count -1; i++)
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
