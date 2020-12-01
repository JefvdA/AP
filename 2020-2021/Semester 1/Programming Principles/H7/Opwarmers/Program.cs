using System;

namespace Opwarmers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. (KWADRAAT) Geef een geheel getal   >>>");
            int input = int.Parse(Console.ReadLine());
            int kwadraat = Kwadraat(input);
            Console.WriteLine($"Het kwadraat van {input} is {kwadraat}");

            Console.Write("2. (STRAAL) Geef een geheel getal, diameter vd cirkel   >>>");
            input = int.Parse(Console.ReadLine());
            int straal = BerekenStraal(input);
            Console.WriteLine($"De straal van een cirkel met diameter = {input} is {straal}");

            Console.WriteLine("3. (GROOTSTE GETAL) Geef 2 gehele getallen");
            Console.Write("1.   >>>");
            int x = int.Parse(Console.ReadLine());
            Console.Write("2.   >>>");
            int y = int.Parse(Console.ReadLine());
            int grootste = GrootsteGetal(x, y);
            Console.WriteLine($"X = {x}, Y = {y} -> Het grootste getal is {grootste}");
        }

        static int Kwadraat(int x)
        {
            return Convert.ToInt32(Math.Pow(x, 2));
        }

        static int BerekenStraal(int x)
        {
            return x / 2;
        }

        static int GrootsteGetal(int x, int y)
        {
            return Math.Max(x, y);
        }
    }
}
