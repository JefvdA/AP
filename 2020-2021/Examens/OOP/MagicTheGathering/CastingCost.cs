using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    class CastingCost
    {
        public ManaType ColoredTypeNeeded { get; private set; }
        public int AmountColoredTypeNeeded { get; private set; }
        public int AmountUncoloredTypeNeeded { get; set; }

        public CastingCost(ManaType coloredTypeNeeded, int amountColoredTypeNeeded, int amountUncoloredTypeNeeded)
        {
            ColoredTypeNeeded = coloredTypeNeeded;
            AmountColoredTypeNeeded = amountColoredTypeNeeded;
            AmountUncoloredTypeNeeded = amountUncoloredTypeNeeded;
        }
    }
}
