using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oef3
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
            {
                // Make backup of array
                int[] arrayBackup = array;

                // Make length of array twice as long
                array = new int[arrayBackup.Length * 2];

                // Restore previous values to array (from arrayBackup)
                for (int i = 0; i < arrayBackup.Length; i++)
                {
                    array[i] = arrayBackup[i];
                }
            }

            // Top++ -> Write value to index top
            Top++;
            array[Top] = value;
            ShowStack(array);
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

        public void ShowStack(int[] array)
        {
            Debug.WriteLine($"Array: {string.Join(", ", array)}");
        }
    }
}