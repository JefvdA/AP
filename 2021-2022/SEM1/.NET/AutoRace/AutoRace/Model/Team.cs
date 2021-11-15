using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRace.Model
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Pilot> Pilots { get; set; }
    }
}