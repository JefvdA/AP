using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CircularQueue<T>
    {
        private const int MAX_ELEMENTS = 5;
        private T[] array = new T[MAX_ELEMENTS];

        private int head = int.MinValue;
        private int tail = MAX_ELEMENTS - 1;

        public void EnQueue(T value)
        {
            if(!isFull())
            {
                if (++tail == array.Length)
                    tail = 0;
                if (head == int.MinValue)
                    head = tail;
                array[tail] = value;
            }
        }

        public T DeQueue()
        {
            if (!isEmpty())
            {
                T result = array[head];
                if (head == tail) // only 1 item in queue
                    head = int.MinValue; // queue in now empty
                else if (++head == array.Length)
                    head = 0;
                return result;
            }
            throw new Exception("The queue is empty, Dequeue is not allowed!");
        }

        public bool isFull()
        {
            return !(tail + 1 != head && tail - (array.Length - 1) != head);
        }

        public bool isEmpty()
        {
            return head == int.MinValue;
        }

        public void ShowQueue()
        {
            Debug.WriteLine($"Array: {string.Join(", ", array)}");
        }
    }
}
