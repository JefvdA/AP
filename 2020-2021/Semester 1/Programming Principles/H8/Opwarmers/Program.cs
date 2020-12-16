using System;

namespace Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 20;
            const int SHIFT = 5;
            int[] getallen = leesGetallen(MAX);

            //// 1. Er worden 20 getallen ingelezen. De getallen worden in omgekeerde volgorde afgedrukt.
            int[] reverseGetallen = reverseArray(getallen);
            writeArray(reverseGetallen);

            // 2. Er worden 20 getallen ingelezen. De getallen worden 1 plaats naar voor verschoven afgedrukt.
            int[] shiftedGetallen = shiftArray(getallen, SHIFT);
            writeArray(shiftedGetallen);
        }

        static int[] leesGetallen(int max)
        {
            int[] input = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("Geef een nummer:   >>>");
                input[i] = int.Parse(Console.ReadLine());
            }

            return input;
        }

        static void writeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.Write("\n");
        }
    
        static int[] reverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];

            for (int i = array.Length - 1; i > -1; i--)
            {
                reverseArray[array.Length - i - 1] = array[i];
            }
            return reverseArray;
        }
    
        static int[] shiftArray(int[] array, int x)
        {
            int[] shiftedArray = new int[array.Length];

            for (int i = x; i < array.Length; i++)
            {
                shiftedArray[i - x] = array[i];
            }
            for (int i = 0; i < x; i++)
            {
                shiftedArray[array.Length - x + i] = array[i];
            }
            return shiftedArray;
        }
    }
}
