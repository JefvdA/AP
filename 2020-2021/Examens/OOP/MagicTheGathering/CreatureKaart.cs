using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    class CreatureKaart
    {
        #region properties
        public string CreatureName { get; private set; }
        public CastingCost CreatureCastingCost { get; private set; }
        public string SpecialAbilities { get; private set; }
        public string FlavourText { get; private set; }

        private int attack;
        public int Attack
        {
            get { return attack; }
            set { if(value >= 0) attack = value; }
        }

        private int defense;

        public int Defense
        {
            get { return defense; }
            set { if(value >= 0) defense = value; }
        }
        #endregion

        #region constructor
        public CreatureKaart(string creatureName, CastingCost creatureCastingCost, string specialAbilities, string flavourText, int attack, int defense)
        {
            CreatureName = creatureName;
            CreatureCastingCost = creatureCastingCost;
            SpecialAbilities = specialAbilities;
            FlavourText = flavourText;
            Attack = attack;
            Defense = defense;
        }
        #endregion

        #region methoden
        public void ChangeAttack(bool positveChange)
        {
            if (positveChange)
                Attack++;
            else
                Attack--;
        }

        public void ToonKaart()
        {
            string message = $"*******************************************************\n" +
                             $"{CreatureName} ({CreatureCastingCost.AmountUncoloredTypeNeeded} kleurloos, {CreatureCastingCost.AmountColoredTypeNeeded} {CreatureCastingCost.ColoredTypeNeeded} mana)\n" +
                             $"*******************************************************\n" +
                             $"\"{FlavourText}\"\n" +
                             $"------------------------------------------------------ -\n" +
                             $"Abilities: {SpecialAbilities}\n" +
                             $"Attack: {Attack}\n" +
                             $"Defense: {Defense}\n" +
                             $"------------------------------------------------------ -\n";
            Console.Write(message);
        }
        #endregion
    }
}
