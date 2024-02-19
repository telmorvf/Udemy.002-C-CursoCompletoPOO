using System;
using System.Runtime.Serialization;

namespace _213_Generics1
{
    internal class PrintServiceString
    {
        private string[] _values = new string[10];

        private int _count = 0;

        public void AddValue(string value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is Full!");
            }
            _values[_count] = value;
            _count++;
        }

        public string First()
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
