using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oef1
{
    class StackInt
    {
        const int STACK_LENGTH = 5;
        int[] array = new int[STACK_LENGTH];
        public int Top { get; private set; } = -1;

        public void Push(int value)
        {
            // Check if stack is full
            if (Top == array.Length - 1)
                return;

            // Top++ -> Write value to index top
            Top++;
            array[Top] = value;
        }

        public int Pop()
        {
            // Check if stack is empty
            if (Top < 0)
                return -999999999;

            // Read value with index = top, top--, return value
            int value = array[Top];
            Top--;
            return value;
        }

        public void ShowStack()
        {
            Debug.WriteLine($"Array: {string.Join(", ", array)}");
        }
    }
}
