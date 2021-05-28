using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace oef2
{
    class CirculaireQueue
    {
        const int MAX_ELEMENTS = 5;
        int[] queue = new int[MAX_ELEMENTS];
        int head = int.MinValue;
        int tail = MAX_ELEMENTS - 1;

        public void EnQueue(int newElement)
        {
            if(tail+1 != head && tail - (MAX_ELEMENTS - 1) != head)
            {
                if (++tail == MAX_ELEMENTS)
                    tail = 0;
                queue[tail] = newElement;
                if (head == int.MinValue)
                    head = tail;
            }
            Debug.WriteLine($"Queue: {string.Join(", ", queue)}");
        }

        public int DeQueue()
        {
            if(head != int.MinValue)
            {
                int result = queue[head];

                if (head == tail) // check of er maar 1 element is
                    head = int.MinValue; // nu leeg
                else if (++head == MAX_ELEMENTS)
                    head = 0;

                Debug.WriteLine($"Queue: {string.Join(", ", queue)}");
                return result;
            }
            return -999999999;
        }
    }
}
