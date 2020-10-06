using System;

namespace Kill_Death
{
    class Program
    {
        static void Main(string[] args)
        {
            double kills = 25;
            double deaths = 10;

            double k_d = kills / deaths;
            Console.WriteLine($"Je k/d is {k_d}");
        }
    }
}
