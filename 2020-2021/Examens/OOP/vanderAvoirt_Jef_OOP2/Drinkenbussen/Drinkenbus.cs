using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkenbussen
{
    class Drinkenbus : SportItem, ITrackable
    {
        public override string ToString()
        {
            return "een drinkbus";
        }

        public GPSLocation GetCurrentLocation()
        {
            return new GPSLocation();
        }
    }
}
