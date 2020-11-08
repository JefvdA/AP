using System;

namespace Kleurcode_weerstand_ENUM
{
    class Program
    {
        enum Kleuren { Zilver=-2, Goud, Zwart, Bruin, Rood, Oranje, Geel, Groen, Blauw, Paars, Grijs, Wit, Undefined}
        static void Main(string[] args)
        {
            Console.Write("Kleur van de eerste ring     >>");
            string input1 = Console.ReadLine().ToLower();
            Console.Write("Kleur van de tweede ring     >>");
            string input2 = Console.ReadLine().ToLower();
            Console.Write("Kleur van de derede ring     >>");
            string input3 = Console.ReadLine().ToLower();

            Kleuren kleur1 = Kleuren.Undefined;
            Kleuren kleur2 = Kleuren.Undefined;
            Kleuren kleur3 = Kleuren.Undefined;


            int ring1 = 0;
            int ring2 = 0;
            int mult = 0;

            //Ring 1
            switch (input1)
            {
                case "zwart":
                    kleur1 = Kleuren.Zwart;
                    break;
                case "bruin":
                    kleur1 = Kleuren.Bruin;
                    break;
                case "rood":
                    kleur1 = Kleuren.Rood;
                    break;
                case "oranje":
                    kleur1 = Kleuren.Oranje;
                    break;
                case "geel":
                    kleur1 = Kleuren.Geel;
                    break;
                case "groen":
                    kleur1 = Kleuren.Groen;
                    break;
                case "blauw":
                    kleur1 = Kleuren.Blauw;
                    break;
                case "paars":
                    kleur1 = Kleuren.Paars;
                    break;
                case "grijs":
                    kleur1 = Kleuren.Grijs;
                    break;
                case "wit":
                    kleur1 = Kleuren.Wit;
                    break;
            }
            ring1 = (int)kleur1;

            //Ring 2
            switch (input2)
            {
                case "zwart":
                    kleur2 = Kleuren.Zwart;
                    break;
                case "bruin":
                    kleur2 = Kleuren.Bruin;
                    break;
                case "rood":
                    kleur2 = Kleuren.Rood;
                    break;
                case "oranje":
                    kleur2 = Kleuren.Oranje;
                    break;
                case "geel":
                    kleur2 = Kleuren.Geel;
                    break;
                case "groen":
                    kleur2 = Kleuren.Groen;
                    break;
                case "blauw":
                    kleur2 = Kleuren.Blauw;
                    break;
                case "paars":
                    kleur2 = Kleuren.Paars;
                    break;
                case "grijs":
                    kleur2 = Kleuren.Grijs;
                    break;
                case "wit":
                    kleur2 = Kleuren.Wit;
                    break;
            }
            ring2 = (int)kleur2;

            //Ring 3
            switch (input3)
            {
                case "zwart":
                    kleur3 = Kleuren.Zwart;
                    break;
                case "bruin":
                    kleur3 = Kleuren.Bruin;
                    break;
                case "rood":
                    kleur3 = Kleuren.Rood;
                    break;
                case "oranje":
                    kleur3 = Kleuren.Oranje;
                    break;
                case "geel":
                    kleur3 = Kleuren.Geel;
                    break;
                case "groen":
                    kleur3 = Kleuren.Groen;
                    break;
                case "blauw":
                    kleur3 = Kleuren.Blauw;
                    break;
                case "paars":
                    kleur3 = Kleuren.Paars;
                    break;
                case "goud":
                    kleur3 = Kleuren.Goud;
                    break;
                case "zilver":
                    kleur3 = Kleuren.Zilver;
                    break;
            }
            mult = (int)kleur3;

            double totaal = int.Parse(ring1.ToString() + ring2.ToString()) * Math.Pow(10, mult);
            Console.Clear();
            Console.WriteLine($"Deze weerstand heeft een waarde van {totaal} Ohm.");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
