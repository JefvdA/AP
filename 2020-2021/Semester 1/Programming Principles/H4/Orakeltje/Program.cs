using System;

namespace Orakeltje
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int jaren = random.Next(5, 125);
            Console.WriteLine($"Je zal nog {jaren} jaren leven!");

            Console.ReadKey();
        }
    }
}
