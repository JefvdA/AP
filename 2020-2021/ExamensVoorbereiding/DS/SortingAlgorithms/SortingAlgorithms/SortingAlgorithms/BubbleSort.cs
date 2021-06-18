using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.JefvdA;

namespace SortingAlgorithms.SortingAlgorithms
{
    class BubbleSort
    {
        public static void SortArray(int[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                bool hasSwapped = false;
                for (int j = 0; j < i; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        Tools.SwitchElements(array, j, j + 1);
                        hasSwapped = true;
                    }
                }
                if (!hasSwapped)
                    return;
            }
        }
    }
}
