using System;
using System.Collections.Generic;

namespace Course.Services
{
    public class PrintService<T> 
    {
        private List<T> _valuesList = new List<T>();

        public void AddValue(T value)
        {
            _valuesList.Add(value);
        }

        public T First()
        {
            return _valuesList[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _valuesList.Count; i++)
            {
                if (i != _valuesList.Count-1)
                {
                    Console.Write(_valuesList[i] + ", ");
                }
                else {
                    Console.Write(_valuesList[i]);
                }
            }
            Console.Write("]");

        }
    }
}