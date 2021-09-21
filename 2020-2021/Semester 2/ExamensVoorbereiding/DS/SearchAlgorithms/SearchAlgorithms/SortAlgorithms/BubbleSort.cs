using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms.SortAlgorithms
{
    class BubbleSort
    {
        public static void SortArray<T>(T[] array) where T : IComparable<T>
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                bool hasSwapped = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        hasSwapped = true;
                    }
                }
                if (!hasSwapped)
                    return;
            }
        }
    }
}
