using System.Collections.Generic;

namespace AutoRace.Model
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Circuit> Circuits { get; set; }
    }
}