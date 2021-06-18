using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithms.SortAlgorithms;

namespace SearchAlgorithms.SearchAlgorithms
{
    class BinarySearch 
    {
        public static int SearchIndex<T>(T[] array, T value) where T : IComparable<T>
        {
            if (array == null || array.Length == 0) throw new ArgumentException("The list cannot be empty");
            BubbleSort.SortArray(array);

            return SearchIndex(array, value, 0, array.Length-1);
        }

        private static int SearchIndex<T>(T[] array, T value, int left, int right) where T : IComparable<T>
        {
            if (right < left) return -1;

            int mid = left + (right - left) / 2;
            if (array[mid].CompareTo(value) > 0)
                return SearchIndex(array, value, left, mid - 1);
            else if (array[mid].CompareTo(value) < 0)
                return SearchIndex(array, value, mid + 1, right);

            return mid;
        }
    }
}
