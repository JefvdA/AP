using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinkenbussen
{
    class Rugzak : ITrackable
    {
        private Dictionary<string, SportItem> sportItems = new Dictionary<string, SportItem>();
        public Dictionary<string, SportItem> SportItems
        {
            get { return sportItems; }
            set { sportItems = value; }
        }


        public void Visualiseer()
        {
            GPSLocation rugzakLocatoin = GetCurrentLocation();

            Console.Clear();
            Console.SetCursorPosition(rugzakLocatoin.Latitude, rugzakLocatoin.Longitude);
            Console.Write("r");

            for (int i = 0; i < sportItems.Count; i++)
            {
                SportItem sportItem = sportItems.Values.ElementAt(i);
                if (sportItem is ITrackable)
                {
                    GPSLocation sportItemLocation = ((ITrackable)sportItem).GetCurrentLocation();
                    Console.SetCursorPosition(sportItemLocation.Latitude, sportItemLocation.Longitude);
                    Console.Write("D");
                }
            }
        }


        public GPSLocation GetCurrentLocation()
        {
            return new AdvancedGPSLocation();
        }


        public override string ToString()
        {
            AdvancedGPSLocation rugzakLocation = (AdvancedGPSLocation)GetCurrentLocation();

            string message = $"Rugzak op locatie: Latitude:{rugzakLocation.Latitude}, Longitude:{rugzakLocation.Longitude}, Height:{rugzakLocation.Height}\n" +
                             $" Met inhoud:\n";
            for (int i = 0; i < SportItems.Count; i++)
            {
                string key = SportItems.Keys.ElementAt(i);
                SportItem sportItem = SportItems.Values.ElementAt(i);

                message += $"           {key} ({sportItem})\n";
                if (sportItem is ITrackable)
                {
                    GPSLocation sportItemLocation = ((ITrackable)sportItem).GetCurrentLocation();
                    message += $"                   -Laatste locatie is Latitude:{sportItemLocation.Latitude}, Longitude:{sportItemLocation.Longitude}\n";
                }
                else
                    message += $"                   -Geen tracker aanwezig\n";
            }

            return message;
        }
    }
}
