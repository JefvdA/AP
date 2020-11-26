using System;

namespace D3_Wiskundequiz
{
    class Oplossing_gameloop
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool gameloop = true;
            int level = 0;

            while (gameloop)
            {
                int x = random.Next(1, 11);
                int y = random.Next(1, 11);
                int product = x * y;

                Console.Write($"{x} * {y} = ");
                int input = int.Parse(Console.ReadLine());

                if (input == product)
                {
                    level++;
                    Console.WriteLine("Proficiat, juiste antwoord druk op een knop om verder te gaan!");
                }
                else
                {
                    Console.WriteLine($"Fout... het juiste antwoord was: {product}");
                    gameloop = false;
                }

                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"In totaal heb je {level} keer juist geantwoord!");
        }
    }
}