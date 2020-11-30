using System;

namespace Opgave2
{
    class Program
    {
        enum Fasen { A, B, C, Onbekend }

        static void Main(string[] args)
        {
            //Declare "Fase" variable
            Fasen fase = Fasen.Onbekend;

            //Flowchart
            Console.WriteLine("Zet de computer aan. (Antwoord op volgende vragen met y of n)");
            Console.Write("Gaat de computer aan?   >>>");
            string input = Console.ReadLine();
            Console.Clear();

            if(input == "y")
            {
                Console.Write("Zijn er fout boodschappen?   >>>");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "y")
                {
                    fase = Fasen.A;
                }
                else
                {
                    fase = Fasen.B;
                }
            }
            else
            {
                Console.Write("Gaat het power light aan?   >>>");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "y")
                {
                    Console.WriteLine("Zet het computerscherm aan");
                }
                else
                {
                    Console.WriteLine("Controleer de voedingskabel");
                }

                Console.Write("Probleem opgelost?   >>>");
                input = Console.ReadLine();
                Console.Clear();

                if (input == "y")
                {
                    fase = Fasen.B;
                }
                else
                {
                    fase = Fasen.C;
                }
            }

            switch (fase)
            {
                case Fasen.A:
                    //Fase A
                    Console.Write("Geef de foutcode als geheel getal in (0-9)");
                    int foutcode = int.Parse(Console.ReadLine());

                    if(foutcode < 0 || foutcode > 10)
                    {
                        Console.WriteLine("Los het dan zelf op he!");
                    }
                    else
                    {
                        double x = Math.Round(Math.Cbrt(foutcode * 3), 1);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Gelieve je computer gedurende {x} minuten af te zetten");
                        Console.ResetColor();
                    }
                    break;
                case Fasen.B:
                    //Fase B
                    Random random = new Random();
                    int percentage = random.Next(1, 101);

                    Console.WriteLine("Mooi zo alles werkt!");

                    if(percentage <= 25)
                        Console.WriteLine("En u wint ook nog eens 1 jaar gratis IT support!");
                    break;
                case Fasen.C:
                    //Fase C
                    int processorCount = Environment.ProcessorCount;

                    if (processorCount == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("1 processor");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{processorCount} processors");
                    }
                    Console.ResetColor();

                    int reparatiePrijs = processorCount * 50;
                    if (reparatiePrijs > 200)
                        reparatiePrijs = 200;
                    Console.WriteLine($"{reparatiePrijs} euro");

                    bool is64Bit = Environment.Is64BitOperatingSystem;
                    if(is64Bit)
                        Console.WriteLine("Hier een bon!");
                    break;
                default:
                    Console.WriteLine("Er is een fout opgetreden, probeer opnieuw!");
                    break;
            }
        }
    }
}
