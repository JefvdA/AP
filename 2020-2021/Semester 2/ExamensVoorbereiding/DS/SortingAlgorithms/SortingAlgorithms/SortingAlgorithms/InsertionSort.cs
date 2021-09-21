using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.JefvdA;

namespace SortingAlgorithms.SortingAlgorithms
{
    class InsertionSort
    {
        public static void SortArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] < array[j])
                        Tools.SwitchElements(array, i, j);
                }
            }
        }
    }
}
