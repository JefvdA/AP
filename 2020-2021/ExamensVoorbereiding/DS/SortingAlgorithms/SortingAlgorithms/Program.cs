using System;
using SortingAlgorithms.SortingAlgorithms;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unSortedArray = RandomGenerator.Generate(20, 0, 100, true);
            Console.WriteLine("Unsorted array:");
            PrintArray(unSortedArray);

            // BubbleSort
            int[] array = unSortedArray;
            BubbleSort.SortArray(array);
            Console.WriteLine("BubbleSorted array:");
            PrintArray(array);

            // SelectionSort
            array = unSortedArray;
            SelectionSort.SortArray(array);
            Console.WriteLine("SelectionSorted array:");
            PrintArray(array);

            // InsertionSort
            array = unSortedArray;
            InsertionSort.SortArray(array);
            Console.WriteLine("InsertionSorted array:");
            PrintArray(array);

            // QuickSort
            array = unSortedArray;
            QuickSorter.SortArray(array);
            Console.WriteLine("QuickSorted array:");
            PrintArray(array);

            // MergeSort
            array = unSortedArray;
            MergeSorter.SortArray(array);
            Console.WriteLine("MergeSorted array:");
            PrintArray(array);
        }

        static void PrintArray<T>(T[] array)
        {
            Console.WriteLine($"Array: {string.Join(", ", array)}");
        }
    }
}
