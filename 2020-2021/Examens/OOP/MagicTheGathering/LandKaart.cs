using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    public enum ManaType { Water, Bos, Zon, Vuur, Dood }

    class LandKaart
    {
        #region properties
        public string LandName { get; private set; }
        public ManaType LandManaType { get; private set; }
        #endregion

        #region constructor
        public LandKaart(string landName, ManaType landManaType)
        {
            LandName = landName;
            LandManaType = landManaType;
        }
        #endregion

        #region methoden
        public void ToonKaart()
        {
            string message = $"*******************************************************" +
                             $"{LandName} ({LandManaType} mana)" +
                             $"*******************************************************";
            Console.WriteLine(message);
        }

        public static bool CastTest(List<LandKaart> landKaarten, CreatureKaart creatureKaart)
        {
            ManaType coloredTypeNeeded = creatureKaart.CreatureCastingCost.ColoredTypeNeeded;
            int amountColoredTypeNeeded = creatureKaart.CreatureCastingCost.AmountColoredTypeNeeded;
            int amountUncoloredTypeNeeded = creatureKaart.CreatureCastingCost.AmountUncoloredTypeNeeded;

            int amountColoredType = 0;
            int amountOthers = 0;
            for (int i = 0; i < landKaarten.Count; i++)
            {
                if (landKaarten[i].LandManaType == coloredTypeNeeded)
                    amountColoredType++;
                else
                    amountOthers++;
            }

            if (amountColoredType >= amountColoredTypeNeeded && (amountOthers + amountColoredType - amountColoredTypeNeeded) >= amountUncoloredTypeNeeded)
                return true;
            return false;
        }
        #endregion
    }
}
