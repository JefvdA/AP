using System;
using SearchAlgorithms.SearchAlgorithms;
using SearchAlgorithms.SortAlgorithms;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 5, 1, 3, 2, 4 };
            Console.WriteLine($"Normal array: {string.Join(", ", array)}");

            int index = LineairSearch.SearchIndex(array, 2);
            Console.WriteLine($"Index found with LineairSearch: {index}");

            HashTable<int> hashTable = new HashTable<int>(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                hashTable.AddItem(array[i]);
            }
            index = hashTable.SearchIndex(2);
            Console.WriteLine($"Index found with HashTable: {index}");


            BubbleSort.SortArray(array);
            Console.WriteLine($"Sorted array: {string.Join(", ", array)}");

            index = BinarySearch.SearchIndex(array, 2);
            Console.WriteLine($"Index found with BinarySearch: {index}");
        }
    }
}
