using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        private const int MAX_ELEMENTS = 5;
        private T[] array = new T[MAX_ELEMENTS];

        private int top = -1;

        public void Push(T value)
        {
            if(top == array.Length - 1)
            {
                T[] newArray = new T[array.Length * 2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }

            array[++top] = value;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new Exception("The stack is empty, Pop is not allowed");

            return array[top--];
        }

        public bool IsEmpty()
        {
            if (top == -1)
                return true;

            return false;
        }
    }
}
