//van der Avoirt Jef    1IT6

using System;

namespace van_der_Avoirt_Jef_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat wil je doen? Covidbeslissingshelper (c) of de covidquiz? (q)");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "q")
            {
                CovidQuiz();
            }
            else if (input == "c")
            {
                Covidblessingshelper();
            }
            else
            {
                Console.WriteLine("Verkeerde invoer");
            }
        }

        static void CovidQuiz()
        {
            Random random = new Random();
            int currentDays = random.Next(1, 6);

            Console.WriteLine($"Je zit momenteel al {currentDays} in quarantaine!");
            Console.Write("Hoeveel langer zal je dan nog in quarantaine moeten blijven voor het testen?   >>>");
            int answer = int.Parse(Console.ReadLine());

            if (answer == (5 - currentDays))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fout!");
                Console.ResetColor();
            }
        }

        static void Covidblessingshelper()
        {
            Console.WriteLine("Je koos voor covidbeslissingshelper, antwoord op volgende vragen met ja (y) of nee (n)");
            Console.Write("Vertoon je covid symptomen?   >>>");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "y")
            {
                Quarantaine();
            }
            else
            {
                Console.Write("In nauw contact gekomen met iemand die ziek is?");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "y")
                {
                    Quarantaine();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Je mag naar school blijven gaan!");
                    Console.ResetColor();
                }
            }
        }

        static void Quarantaine()
        {
            Console.WriteLine("Ga in quarantaine en laat je testen");
            Console.Write("Positieve test?   >>>");
            string input = Console.ReadLine();
            Console.Clear();

            if (input == "y")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("7 dagen quarantaine!");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Naar school wanneer genezen");
                Console.ResetColor();
            }
        }
    }
}
