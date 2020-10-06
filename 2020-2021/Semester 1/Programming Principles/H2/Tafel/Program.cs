using System;

namespace Tafel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 411;

            for(int i = 0; i < 10; i++)
            {
                Console.Clear();

                int y = x * (i + 1);
                Console.WriteLine($"{i + 1} x {x} = {y}");
                Console.WriteLine("Druk op enter voor de volgende lijn.");
                Console.ReadLine();
            }
        }
    }
}
