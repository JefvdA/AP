namespace AutoRace.Model
{
    public class Race
    {
        public int ID { get; set; }
        public int SeasonID { get; set; }
        public int CircuitID { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public Season Season { get; set; }
        public Circuit Circuit { get; set; }
    }
}