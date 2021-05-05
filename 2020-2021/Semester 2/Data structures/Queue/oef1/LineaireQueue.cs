using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace oef1
{
    class LineaireQueue
    {
        const int MAX_ELEMENTS = 5;
        int[] queue = new int[MAX_ELEMENTS];
        int tail = -1;

        public void EnQueue(int newElement)
        {
            if (tail >= queue.Length-1)
                return;

            tail++;
            queue[tail] = newElement;

            Debug.WriteLine($"Queue: {string.Join(", ", queue)}");
        }

        public int DeQueue()
        {
            if (tail < 0)
                return -999999999;

            Debug.WriteLine($"Queue: {string.Join(", ", queue)}");
            return queue[tail--];
        }
    }
}
