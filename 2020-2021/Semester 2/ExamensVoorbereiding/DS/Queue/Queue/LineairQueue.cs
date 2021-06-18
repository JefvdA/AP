using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class LineairQueue<T>
    {
        private const int MAX_ELEMENTS = 5;
        private T[] array = new T[MAX_ELEMENTS];

        private int tail = -1;

        public void EnQueue(T value)
        {
            if(tail == array.Length - 1)
            {
                T[] newArray = new T[array.Length * 2];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }

            array[++tail] = value;
        }

        public T DeQueue()
        {
            if(tail >= 0)
            {
                T result = array[0];
                for (int i = 0; i < tail; i++)
                    array[i] = array[i + 1];
                tail--;
                return result;
            }
            throw new Exception("The queue is empty, DeQueue is not allowed!");
        }
    }
}
