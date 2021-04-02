using System;

namespace Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            UpCounter(3);
        }

        static void UpCounter(int number)
        {
            // Stop at 0
            if (number == 0)
                return;
            UpCounter(number - 1);

            Console.WriteLine(number);
        }
    }
}
