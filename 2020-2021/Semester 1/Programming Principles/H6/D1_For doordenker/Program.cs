using System;

namespace D1_For_doordenker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max waarde:   >>>");
            int max = int.Parse(Console.ReadLine());

            for (int i = 1; i < max+1; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = max - 1; i > 0 ; i--)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
