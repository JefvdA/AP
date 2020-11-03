using System;

namespace Casino3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int getal = random.Next(1, 7);

            Console.Write("Raad het eerste getal! (1-6)     >>");
            int input = int.Parse(Console.ReadLine());

            if (input == getal)
            {
                Console.WriteLine("Proficiat! (1/3) je gaat verder naar ronde 2!");

                getal = random.Next(1, 7);

                Console.Write("Raad het tweede getal! (1-6)     >>");
                input = int.Parse(Console.ReadLine());

                if(input == getal)
                {
                    Console.WriteLine("Proficiat! (2/3) je gaat verder naar de laatste ronde");

                    getal = random.Next(1, 7);

                    Console.Write("Raad het laatste getal om te winnen! (1-6)     >>");
                    input = int.Parse(Console.ReadLine());

                    if(input == getal)
                    {
                        Console.WriteLine("Proficiat je hebt gewonnen!");
                    } else
                    {
                        Console.WriteLine("You lose!");
                    }
                } else
                {
                    Console.WriteLine("You lose!");
                }
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadKey();
        }
    }
}
