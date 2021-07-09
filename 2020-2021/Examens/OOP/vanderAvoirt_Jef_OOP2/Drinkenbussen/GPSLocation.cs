using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkenbussen
{
    class GPSLocation
    {
        private Random random = new Random();

        public int Latitude { get; set; }
        public int Longitude { get; set; }


        public GPSLocation()
        {
            Latitude = random.Next(1, 10);
            Longitude = random.Next(1, 10);
        }
    
        public GPSLocation(int latitude, int longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }


        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
}
