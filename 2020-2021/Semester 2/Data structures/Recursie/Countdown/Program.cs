using System;

namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown(10);
        }

        static void Countdown(int number)
        {
            // Takeoff on 0
            if(number <= 0)
            {
                Console.WriteLine("Takeoff!");
                return;
            }

            Console.WriteLine(number);
            Countdown(number - 1);
        }
    }
}
