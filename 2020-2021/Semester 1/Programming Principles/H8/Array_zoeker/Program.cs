using System;

namespace Array_zoeker
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10;

            int[] getallen = leesGetallen(MAX);

            Console.Write("Welke waarde moet verwijdert worden?   >>>");
            int waarde = int.Parse(Console.ReadLine());

            int[] newGetallen = removeItemFromArray(getallen, waarde);
            writeArray(newGetallen);
        }
        static int[] removeItemFromArray(int[] array, int item)
        {
            int[] newArray = new int[array.Length];

            int x = Array.IndexOf(array, item);

            for (int i = 0; i < x; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = x + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            if (x != -1)
                newArray[newArray.Length - 1] = -1;

            return newArray;
        }

        static void writeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.Write("\n");
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
    }
}
