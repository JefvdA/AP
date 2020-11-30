// van der Avoirt Jef 1IT6
using System;

namespace vanderAvoirt_Jef_VAARDIG1
{
    class Program
    {
        enum Keuze { Viewers = 1, Adspace, Niets }
        enum StreamerSoort { Beginner, Gevorderde, Faker, Onbekend }

        static void Main(string[] args)
        {
            // Variabelen
            Random random = new Random();

            // DEEL 1
            Console.WriteLine($"Welkom {Environment.UserName} op APstream");
            int viewers = random.Next(1, 6) * 1000;
            double credits = random.Next(100, 601);
            Console.WriteLine($"Volgens onze data kijken er momenteel {viewers} viewers. Je budget is {credits} credits");

            // DEEL 2
            Console.WriteLine("Wat wil je doen?");
            Console.WriteLine("     1. Koop 1000 viewers (200 credits)");
            Console.WriteLine("     2. Koop adspace viewers (300 credits)");
            Console.WriteLine("     3. Niets");
            int keuzeId = int.Parse(Console.ReadLine());
            Keuze keuze = (Keuze)keuzeId;

            bool aankoopGedaan = false;
            switch (keuze)
            {
                case Keuze.Viewers:
                    if (credits >= 200)
                    {
                        credits -= 200;
                        viewers += 1000;
                        aankoopGedaan = true;

                        Console.WriteLine($"Viewers gekocht. Je nieuwe statistieken zijn: {viewers} viewers en {credits} credits");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Je hebt niet genoeg credits!");
                    }
                    break;
                case Keuze.Adspace:
                    if (credits >= 300)
                    {
                        credits -= 200; // Ik vond het nogal raar dat je 300 nodig had, om vervolgens 200 credits af te nemen. Maar zo staat het in de opgave

                        if (viewers % 2000 == 0)
                            viewers += 1000;
                        else
                            viewers += 500;
                        aankoopGedaan = true;

                        Console.WriteLine($"Adspace gekocht. Je nieuwe statistieken zijn: {viewers} viewers en {credits} credits");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Je hebt niet genoeg credits!");
                    }
                    break;
                default:
                    Console.WriteLine("Dit is geen geldige keuze. Je verliest een kwart van je viewers (naar boven afgerond) en 10% van je budget");
                    viewers -= viewers / 4;
                    credits = Math.Floor(Math.Round(credits * 0.9, 2));
                    Console.WriteLine($"Je finale statistieken zijn: {viewers} viewers en {credits} credits");
                    break;
            }
            Console.ResetColor();

            // Deel 3
            StreamerSoort streamerSoort = StreamerSoort.Onbekend;
            if (credits <= 200 && viewers <= 4000)
            {
                streamerSoort = StreamerSoort.Beginner;
            }
            else if (viewers >= 5000 && aankoopGedaan)
            {
                streamerSoort = StreamerSoort.Gevorderde;
            }
            else if (viewers <= 4000 && keuze == Keuze.Adspace)
            {
                streamerSoort = StreamerSoort.Faker;
            }

            Console.WriteLine($"Jouw streamertype is {streamerSoort}");
            if (streamerSoort == StreamerSoort.Faker)
            {
                Console.WriteLine("Wil je voor 100credits dit profiel omzetten naar gevorderde? (ja/nee)");
                string input = Console.ReadLine().ToLower();

                if (input == "ja")
                    Console.WriteLine("Wordt beter!");
            }
        }
    }
}
