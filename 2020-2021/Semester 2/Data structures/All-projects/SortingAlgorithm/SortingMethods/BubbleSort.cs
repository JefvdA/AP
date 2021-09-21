using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithm.SortingMethods
{
    public class BubbleSort
    {
        public void SortList(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count-i; j++)
                {
                    if(list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
