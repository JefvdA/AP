using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRace.Model
{
    public class Season
    {
        public int ID { get; set; }
        public int SerieID { get; set; }

        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool ActiveSeason { get; set; }

        public Serie Serie { get; set; }
        public List<Race> Races { get; set; }
    }
}
