﻿using System;

namespace Kleurcode_weerstand_naar_ohm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kleur van de eerste ring     >>");
            string kleur1 = Console.ReadLine().ToLower();
            Console.Write("Kleur van de tweede ring     >>");
            string kleur2 = Console.ReadLine().ToLower();
            Console.Write("Kleur van de derede ring     >>");
            string kleur3 = Console.ReadLine().ToLower();

            int ring1 = 0;
            int ring2 = 0;
            int mult = 0;

            //Ring 1
            switch (kleur1)
            {
                case "zwart":
                    ring1 = 0;
                    break;
                case "bruin":
                    ring1 = 1;
                    break;
                case "rood":
                    ring1 = 2;
                    break;
                case "oranje":
                    ring1 = 3;
                    break;
                case "geel":
                    ring1 = 4;
                    break;
                case "groen":
                    ring1 = 5;
                    break;
                case "blauw":
                    ring1 = 6;
                    break;
                case "paars":
                    ring1 = 7;
                    break;
                case "grijs":
                    ring1 = 8;
                    break;
                case "wit":
                    ring1 = 9;
                    break;
            }

            //Ring 2
            switch (kleur2)
            {
                case "zwart":
                    ring2 = 0;
                    break;
                case "bruin":
                    ring2 = 1;
                    break;
                case "rood":
                    ring2 = 2;
                    break;
                case "oranje":
                    ring2 = 3;
                    break;
                case "geel":
                    ring2 = 4;
                    break;
                case "groen":
                    ring2 = 5;
                    break;
                case "blauw":
                    ring2 = 6;
                    break;
                case "paars":
                    ring2 = 7;
                    break;
                case "grijs":
                    ring2 = 8;
                    break;
                case "wit":
                    ring2 = 9;
                    break;
            }

            //Ring 3
            switch (kleur3)
            {
                case "zwart":
                    mult = 0;
                    break;
                case "bruin":
                    mult = 1;
                    break;
                case "rood":
                    mult = 2;
                    break;
                case "oranje":
                    mult = 3;
                    break;
                case "geel":
                    mult = 4;
                    break;
                case "groen":
                    mult = 5;
                    break;
                case "blauw":
                    mult = 6;
                    break;
                case "violet":
                    mult = 7;
                    break;
                case "goud":
                    mult = -1;
                    break;
                case "zilver":
                    mult = -2;
                    break;
            }

            double totaal = int.Parse(ring1.ToString() + ring2.ToString()) * Math.Pow(10, mult);
            Console.Clear();
            Console.WriteLine($"Deze weerstand heeft een waarde van {totaal} Ohm.");

            Console.ReadKey();
        }
    }
}
