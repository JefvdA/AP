using System;

namespace Ohm_berekenaar
{
    class Program
    {
        enum Keuzes { Spanning=1, Weestand, Stroomsterkte };

        static void Main(string[] args)
        {
            Console.Write("Wil je spanning(1), weestand(2) of stroomsterkte(3) berekenen?   >>");
            Keuzes keuze = (Keuzes)int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case Keuzes.Spanning:
                    Console.Write("Geef de weestand   >>");
                    double weerstand = int.Parse(Console.ReadLine());

                    Console.Write("Geef de stroomsterkte   >>");
                    double stroomsterkte = int.Parse(Console.ReadLine());

                    double spanning = weerstand * stroomsterkte;
                    Console.WriteLine($"Dat wil zeggen dat de spanning {spanning} volt bedraagt");
                    break;
                case Keuzes.Weestand:
                    Console.Write("Geef de spanning   >>");
                    spanning = int.Parse(Console.ReadLine());

                    Console.Write("Geef de stroomsterkte   >>");
                    stroomsterkte = int.Parse(Console.ReadLine());

                    weerstand = spanning / stroomsterkte;
                    Console.WriteLine($"Dat wil zeggen dat de weerstand {weerstand} volt bedraagt");
                    break;
                case Keuzes.Stroomsterkte:
                    Console.Write("Geef de spanning   >>");
                    spanning = int.Parse(Console.ReadLine());

                    Console.Write("Geef de weerstand   >>");
                    weerstand = int.Parse(Console.ReadLine());

                    stroomsterkte = spanning * weerstand;
                    Console.WriteLine($"Dat wil zeggen dat de stroomsterkte {stroomsterkte} volt bedraagt");
                    break;
            }

            Console.ReadKey();
        }
    }
}
