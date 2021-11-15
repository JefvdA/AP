using System.Collections.Generic;

namespace AutoRace.Model
{
    public class Circuit
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string Adres { get; set; }
        public float Length { get; set; }

        public Country Country { get; set; }
        public List<Race> Races { get; set; }
    }
}