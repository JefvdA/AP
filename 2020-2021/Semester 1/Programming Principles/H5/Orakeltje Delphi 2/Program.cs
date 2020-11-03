using System;

namespace Orakeltje_Delphi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Ben je een man (m) of een vrouw (v) ?     >>");
            string geslacht = Console.ReadLine();

            Console.Write("Wat is je leeftijd?     >>");
            int leeftijd = int.Parse(Console.ReadLine());

            int maxM = 120;
            int maxV = 150;
            int max;

            if(geslacht == "m")
            {
                max = maxM - leeftijd;
            } else
            {
                max = maxV - leeftijd;
            }

            int voorspelling = random.Next(5, max);
            Console.WriteLine($"Je zal nog {voorspelling} jaren leven");

            Console.ReadKey();
        }
    }
}
