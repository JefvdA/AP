using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace oef4
{
    class StackString
    {
        const int STACK_LENGTH = 5;
        string[] array = new string[STACK_LENGTH];
        public int Top { get; private set; } = -1;

        public void Push(string value)
        {
            // Check if stack is full
            if (Top == array.Length - 1)
            {
                // Make backup of array
                string[] arrayBackup = array;

                // Make length of array twice as long
                array = new string[arrayBackup.Length * 2];

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

        public string Pop()
        {
            // Check if stack is empty
            if (Top < 0)
                return "empty";

            // Read value with index = top, top--, return value
            string value = array[Top];
            Top--;
            return value;
        }

        public void ShowStack(string[] array)
        {
            Debug.WriteLine($"Array: {string.Join(", ", array)}");
        }
    }
}