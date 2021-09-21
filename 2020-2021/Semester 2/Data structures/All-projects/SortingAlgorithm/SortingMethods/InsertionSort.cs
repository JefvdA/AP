using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithm.SortingMethods
{
    class InsertionSort
    {
        public void SortList(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                int current = i;
                for (int j = i-1; j > -1; j--)
                {
                    if(list[j] > list[current])
                    {
                        int temp = list[j];
                        list[j] = list[current];
                        list[current] = temp;

                        current = j;
                    }
                }
            }
        }
    }
}
