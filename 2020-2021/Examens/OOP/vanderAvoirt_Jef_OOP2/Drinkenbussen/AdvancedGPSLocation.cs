using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkenbussen
{
    class AdvancedGPSLocation : GPSLocation
    {
        public int Height { get; set; }


        public AdvancedGPSLocation() : base()
        {
            Height = 1;
        }

        public AdvancedGPSLocation(int latitude, int longitude, int height) : base(latitude, longitude)
        {
            Height = height;
        }


        public override string ToString()
        {
            return base.ToString() + $", Height: {Height}";
        }
    }
}
