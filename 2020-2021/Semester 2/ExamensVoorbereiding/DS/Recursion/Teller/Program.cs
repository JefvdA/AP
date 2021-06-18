using System;

namespace Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number for the counter:   >>>");
            int input = int.Parse(Console.ReadLine());

            UpCounter(input);
        }

        static void UpCounter(int number)
        {
            if (number != 0)
            {
                UpCounter(number - 1);
                Console.WriteLine(number);
            }
        }
    }
}
