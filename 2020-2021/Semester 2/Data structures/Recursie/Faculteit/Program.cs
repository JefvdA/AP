using System;

namespace Faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Faculteit(3));
        }

        static int Faculteit(int number)
        {
            // Stop at 0
            if (number == 0)
                return 1;

            return number * Faculteit(number - 1);
        }
    }
}
