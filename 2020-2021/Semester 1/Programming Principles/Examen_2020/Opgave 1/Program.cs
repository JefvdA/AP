
using System;

namespace Opgave_1
{
    class Program
    {
        const int maxX = 10;
        const int maxY = 12;

        static void Main(string[] args)
        {
            // OORSPRONKELIJKE MATRIX
            Console.WriteLine("Oorspronkelijke matrix");
            for (int i = 0; i < maxY; i++)
            {
                for (int j = 0; j < maxX; j++)
                {
                    int sum = i + j;
                    Console.Write($"{sum}");

                    int spaces = 5 - sum.ToString().Length;
                    for (int x = 0; x < spaces; x++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            // GEWIJZIGDE MATRIX
            Console.WriteLine("GEWIJZIGDE MATRIX:");
            for (int i = 0; i < maxY - 1; i++)
            {
                for (int j = 1; j < maxX + 1; j++)
                {
                    int sum = i + j;
                    Console.Write($"{sum}");

                    int spaces = 5 - sum.ToString().Length;
                    for (int x = 0; x < spaces; x++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            for (int j = 0; j < maxX; j++)
            {
                int sum = j;
                Console.Write($"{sum}");

                int spaces = 5 - sum.ToString().Length;
                for (int x = 0; x < spaces; x++)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
