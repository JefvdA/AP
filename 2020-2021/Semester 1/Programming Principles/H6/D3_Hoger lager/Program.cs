using System;

namespace D3_Hoger_lager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool gameloop = true;

            const int MAX_BEURTEN = 10;

            while(gameloop)
            {
                int getal = random.Next(1, 101);
                int beurten = 0;

                int input;
                do
                {
                    Console.Write("Gok:   >>>");
                    input = int.Parse(Console.ReadLine());
                    beurten++;

                    if (input > getal)
                        Console.WriteLine("Lager!");
                    else if (input < getal)
                        Console.WriteLine("Hoger!");
                } while (input != getal && beurten < MAX_BEURTEN);

                if (beurten != MAX_BEURTEN)
                    Console.WriteLine($"Je hebt in {beurten} beurten het getal geraden. Getal: {getal}");
                else
                    Console.WriteLine($"Je hebt het maximaal aantal beurten bereikt ({MAX_BEURTEN}), GAME OVER!");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Play again? (Y, N)   >>>");
                string playAgain = Console.ReadLine().ToLower();

                if (playAgain != "y")
                    gameloop = false;

                Console.Clear();
            }
        }
    }
}
