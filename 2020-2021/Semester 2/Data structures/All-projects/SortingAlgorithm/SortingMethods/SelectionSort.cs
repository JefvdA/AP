using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithm.SortingMethods
{
    class SelectionSort
    {
        public List<int> SortList(List<int> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[j] < list[minIndex])
                        minIndex = j;
                }

                if(minIndex != i)
                {
                    int temp = list[i];
                    list[i] = list[minIndex];
                    list[minIndex] = temp;
                }
            }

            return list;
        }
    }
}
;