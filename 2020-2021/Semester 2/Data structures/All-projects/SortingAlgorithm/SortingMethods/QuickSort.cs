using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithm.SortingMethods
{
    class QuickSort
    {
        public void SortList(List<int> list)
        {
            QS(list, 0, list.Count-1);
        }

        private void QS(List<int> list, int low, int high)
        {
            int mid = low + (high - low) / 2;
            int p = list[mid];
            int i = low;
            int j = high;

            while(i <= j)
            {
                while (list[i] < p)
                    i++;
                while (list[j] > p && j > i)
                    j--;
                if (i <= j)
                {
                    Switch(list, i, j);
                    i++;
                    j--;
                }
            }
            if (low < j)
                QS(list, low, j);
            if (i < high)
                QS(list, i, high);
        }

        private void Switch(List<int> list, int index1, int index2)
        {
            int temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
