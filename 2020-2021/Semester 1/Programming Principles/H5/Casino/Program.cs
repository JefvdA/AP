using System;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int getal = random.Next(1, 7);

            Console.Write("Raad het getal! (1-6)     >>");
            int input = int.Parse(Console.ReadLine());

            if(input == getal)
            {
                Console.WriteLine("Proficiat!");
            } else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadKey();
        }
    }
}
