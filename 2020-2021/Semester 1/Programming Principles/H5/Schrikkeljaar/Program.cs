using System;

namespace Schrikkeljaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een jaar in, het programma controleert of het een schrikkeljaar is!");
            Console.Write(">>");
            int jaar = int.Parse(Console.ReadLine());

            if(jaar % 4 == 0)
            {
                if(jaar % 100 != 0)
                {
                    Console.WriteLine($"{jaar} is een schrikkeljaar!");
                } else
                {
                    if(jaar % 400 == 0)
                    {
                        Console.WriteLine($"{jaar} is een schrikkeljaar!");
                    } else
                    {
                        Console.WriteLine($"{jaar} is geen schrikkeljaar!");
                    }
                }
            } else
            {
                Console.WriteLine($"{jaar} is geen schrikkeljaar!");
            }

            Console.ReadKey();
        }
    }
}
