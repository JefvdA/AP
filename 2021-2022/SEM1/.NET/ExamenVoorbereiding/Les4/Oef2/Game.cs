namespace Oef2
{
    class Game
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int PickOrder { get; set; }

        public Game(string name, string genre, int pickOrder)
        {
            Name = name;
            Genre = genre;
            PickOrder = pickOrder;
        }

        public override string ToString()
        {
            return "Name: " + Name + " | Genre: " + Genre + " | PickOrder: " + PickOrder;
        }
    }
}
