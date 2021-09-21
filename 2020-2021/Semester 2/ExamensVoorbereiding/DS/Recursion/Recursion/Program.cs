using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number for the countdown:   >>>");
            int input = int.Parse(Console.ReadLine());

            CountDown(input);
        }

        static void CountDown(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number}..");
                CountDown(number - 1);
            }
            else if (number < 0)
                throw new Exception("Can't do a countdown of a number smaller then 0");
            else
                Console.WriteLine("Take-off !");
        }
    }
}
