using System;

namespace Vierkant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de lengte van de zijde van de balk:  >>");
            double zijde = double.Parse(Console.ReadLine());

            double omtrek = zijde * 4;
            double oppervlakte = zijde * zijde;

            Console.WriteLine($"Zijde:  >>{zijde}");
            Console.WriteLine($"Omtrek:  >>{omtrek}");
            Console.WriteLine($"Oppervlakte:  >>{oppervlakte}");
        }
    }
}
