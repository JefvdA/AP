using System;

namespace Geometric_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een hoek in graden:  >>");
            int hoekGraden = int.Parse(Console.ReadLine());

            double hoekRad = hoekGraden * (Math.PI / 180);
            double sin = Math.Sin(hoekRad);
            double cos = Math.Cos(hoekRad);
            double tan = Math.Tan(hoekRad);

            Console.WriteLine($"Hoek in radialen:  {hoekRad}");
            Console.WriteLine($"Sinus:  {sin}");
            Console.WriteLine($"Cosinus:  {cos}");
            Console.WriteLine($"Tangens:  {tan}");

            Console.ReadKey();
        }
    }
}
