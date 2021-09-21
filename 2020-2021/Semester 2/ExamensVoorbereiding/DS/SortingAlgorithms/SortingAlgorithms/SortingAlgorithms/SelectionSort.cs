using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.JefvdA;

namespace SortingAlgorithms.SortingAlgorithms
{
    class SelectionSort
    {
        public static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                if (i != minIndex)
                    Tools.SwitchElements(array, i, minIndex);
            }
        }
    }
}
