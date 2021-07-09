using System;
using System.Collections.Generic;

namespace MagicTheGathering
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatureKaart creature1 = new CreatureKaart("Mahamori Djinn", new CastingCost(ManaType.Water, 2, 4), "Flying", "Of royal blood amoung the spirits of the air...", 5, 6);
            CreatureKaart creature2 = new CreatureKaart("KinderCatch", new CastingCost(ManaType.Bos, 3, 3), "", "In the forest villages of Kessig...", 6, 6);
            CreatureKaart creature3 = new CreatureKaart("Mountain Goat", new CastingCost(ManaType.Vuur, 1, 0), "Mountainwalk", "Folklore has it that to capture a mountain goat is a sign of devine blessing", 1, 1);

            int input = 0;

            #region Landen maken
            List<LandKaart> landKaarten = new List<LandKaart>();
            for (int i = 0; i < Enum.GetValues(typeof(ManaType)).Length; i++)
            {
                ManaType manaType = (ManaType)i;
                string name = manaType.ToString();

                Console.Write($"Aantal {(ManaType)i}? \n" + ">>>");
                input = int.Parse(Console.ReadLine()); // We gaan ervan uit dat de gebruiker een input geeft die naar een int geparsed kan worden
                for (int j = 0; j < input; j++)
                {
                    landKaarten.Add(new LandKaart(name, manaType));
                }
            }
            #endregion

            #region Creature vraag
            Console.Clear();
            creature1.ToonKaart();
            creature2.ToonKaart();
            creature3.ToonKaart();
            Console.WriteLine("Kies 1 van bovenstaande creature kaarten (input:1-2-3)");

            input = int.Parse(Console.ReadLine()); // We gaan ervan uit dat de gebruiker de juiste input geefts
            CreatureKaart creatureToTest = null;
            switch (input)
            {
                case 1:
                    creatureToTest = creature1;
                    break;
                case 2:
                    creatureToTest = creature2;
                    break;
                case 3:
                    creatureToTest = creature3;
                    break;
            }
            bool canBeCreated = LandKaart.CastTest(landKaarten, creatureToTest);
            if(canBeCreated)
                Console.WriteLine("Creature kan gemaakt worden");
            else
                Console.WriteLine("Creature kan niet gemaakt worden");

            Console.ReadKey();
            #endregion
        }
    }
}
