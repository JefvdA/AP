using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRace.Model
{
    public class Serie
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SortingOrder { get; set; }

        public List<Season> Seasons { get; set; }
    }
}