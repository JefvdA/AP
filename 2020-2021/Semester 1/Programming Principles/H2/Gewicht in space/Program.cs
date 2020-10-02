using System;

namespace Gewicht_in_space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel weeg je?( x.x kg) >");
            double gewichtOpAarde = double.Parse(Console.ReadLine());

            double mercurius = 0.38;
            double venus = 0.91;
            double mars = 0.38;
            double jupiter = 2.34;
            double saturnus = 1.06;
            double uranus = 0.92;
            double neptunus = 1.19;
            double pluto = 0.06;

            Console.WriteLine("Je weegt op mercurius: " + gewichtOpAarde * mercurius);
            Console.WriteLine("Je weegt op venus: " + gewichtOpAarde * venus);
            Console.WriteLine("Je weegt op mars: " + gewichtOpAarde * mars);
            Console.WriteLine("Je weegt op jupiter: " + gewichtOpAarde * jupiter);
            Console.WriteLine("Je weegt op saturnus: " + gewichtOpAarde * saturnus);
            Console.WriteLine("Je weegt op uranus: " + gewichtOpAarde * uranus);
            Console.WriteLine("Je weegt op neptunus: " + gewichtOpAarde * neptunus);
            Console.WriteLine("Je weegt op pluto: " + gewichtOpAarde * pluto);
        }
    }
}
