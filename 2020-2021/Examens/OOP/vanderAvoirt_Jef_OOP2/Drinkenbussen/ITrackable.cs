using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkenbussen
{
    interface ITrackable
    {
        public GPSLocation GetCurrentLocation();
    }
}
