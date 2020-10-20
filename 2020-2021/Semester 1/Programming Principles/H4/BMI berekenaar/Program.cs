using System;

namespace BMI_berekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je lengte?  >>");
            double lengte = double.Parse(Console.ReadLine());

            Console.Write("Wat is je gewicht?  >>");
            double gewicht = double.Parse(Console.ReadLine());

            double bmi = Math.Round(gewicht / (lengte * lengte), 2);
            Console.WriteLine($"Je hebt een BMI van {bmi}");
        }
    }
}
