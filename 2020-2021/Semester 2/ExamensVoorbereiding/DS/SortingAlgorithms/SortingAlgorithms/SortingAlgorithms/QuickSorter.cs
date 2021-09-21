using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms.JefvdA;

namespace SortingAlgorithms.SortingAlgorithms
{
    class QuickSorter
    {
        public static void SortArray(int[] array)
        {
            QuickSort(array, 0, array.Length-1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left > right) return;

            int p = array[right];
            int i = left;
            int j = right - 1;

            while (i <= j)
            {
                while (array[i] < p)
                    i++;
                while (array[j] > p)
                    j--;
                if (i < j)
                {
                    Tools.SwitchElements(array, i, j);
                    i++;
                    j--;
                }
                if (i == j)
                    Tools.SwitchElements(array, j, right);
                QuickSort(array, 0, j - 1);
                QuickSort(array, j+1, right);
            }
        }
    }
}
