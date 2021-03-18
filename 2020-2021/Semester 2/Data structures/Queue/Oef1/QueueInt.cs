using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oef1
{
    class QueueInt
    {
        const int QUEUE_LENGTH = 5;
        int[] array = new int[QUEUE_LENGTH];
        int front = -1;
        int rear = -1;

        public void EnQueue(int value)
        {
            if (front == -1)
                front++;

            rear++;
            array[rear] = value;
            Debug.Write(array);
        }
    }
}
