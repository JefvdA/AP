using System;

namespace Schoenverkoper
{
    class Program
    {
        static void Main(string[] args)
        {
            const int schoenenVoorKorting = 9;

            Console.Write("Hoeveel schoenen wens je te kopen?   >>");
            int aantal = int.Parse(Console.ReadLine());

            if(aantal > schoenenVoorKorting) 
            {
                int aantalMetKorting = aantal - schoenenVoorKorting;
                int totaalPrijs = (schoenenVoorKorting * 20) + (aantalMetKorting * 10);
                Console.WriteLine($"{aantal} schoenen kost {schoenenVoorKorting}x20 + {aantalMetKorting}x10 = {totaalPrijs}");
            } else
            {
                int totaalPrijs = aantal * 20;
                Console.WriteLine($"{aantal} schoenen kost {aantal}*20 = {totaalPrijs}");
            }

            Console.ReadKey();
        }
    }
}
