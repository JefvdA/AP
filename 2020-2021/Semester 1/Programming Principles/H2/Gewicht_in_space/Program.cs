using System;

namespace Gewicht_in_space
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gewichtOparde = 55.0;

            double mercurius = 0.38;
            double venus = 0.91;
            double aarde = 1.00;
            double mars = 0.38;
            double jupiter = 2.34;
            double saturnus = 1.06;
            double uranus = 0.92;
            double neptunus = 1.19;
            double pluto = 0.06;

            Console.WriteLine($"Je weegt op Mercurius {gewichtOparde * mercurius}kg!");
            Console.WriteLine($"Je weegt op Venus {gewichtOparde * venus}kg!");
            Console.WriteLine($"Je weegt op Aarde {gewichtOparde * aarde}kg!");
            Console.WriteLine($"Je weegt op Mars {gewichtOparde * mars}kg!");
            Console.WriteLine($"Je weegt op Jupiter {gewichtOparde * jupiter}kg!");
            Console.WriteLine($"Je weegt op Saturnus {gewichtOparde * saturnus}kg!");
            Console.WriteLine($"Je weegt op Uranus {gewichtOparde * uranus}kg!");
            Console.WriteLine($"Je weegt op Neptunus {gewichtOparde * neptunus}kg!");
            Console.WriteLine($"Je weegt op Pluto {gewichtOparde * pluto}kg!");
        }
    }
}
