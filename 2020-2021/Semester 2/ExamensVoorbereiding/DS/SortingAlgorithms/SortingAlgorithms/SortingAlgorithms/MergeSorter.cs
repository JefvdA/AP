using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortingAlgorithms
{
    class MergeSorter
    {
        public static void SortArray(int[] array)
        {
            array = MergeSort(array);
        }

        private static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int[] A1 = new int[array.Length/ 2];
            int[] A2 = new int[array.Length - A1.Length];

            Array.Copy(array, A1, A1.Length);
            Array.Copy(array, A2, A2.Length);

            A1 = MergeSort(A1);
            A2 = MergeSort(A2);

            return Merge(A1, A2);
        }

        private static int[] Merge(int[] A, int[] B)
        {
            int[] C = new int[A.Length + B.Length];

            int aIndex = 0;
            int bIndex = 0;
            int cIndex = 0;
            while(aIndex < A.Length && bIndex < B.Length)
            {
                if (A[aIndex] > B[bIndex])
                    C[cIndex++] = A[aIndex++];
                else
                    C[cIndex++] = B[bIndex++];
            }

            // A or B are now empty

            while (aIndex < A.Length)
                C[cIndex++] = A[aIndex++];
            while (bIndex < B.Length)
                C[cIndex++] = B[bIndex++];

            return C;
        }
    }
}
