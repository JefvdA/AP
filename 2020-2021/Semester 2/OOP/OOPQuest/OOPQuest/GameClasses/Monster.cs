using System;
using System.Collections.Generic;
using System.Text;

namespace OOPQuest.GameClasses
{
    class Monster // TODO HERO and Monster still share code
    {
        public string Name { get; set; } = "Onbekend";

        private double health = 100;
        public double Health
        {
            get { return health; }
            set
            {
                if (value > 0 && value <= 100)
                    health = value;
                else if (value < 0)
                    health = 0;
            }
        }

        public int XP { get; set; } = 0;

        private double attack = 10;
        public double Attack
        {
            get { return attack; }
            set { if (value >= 0) attack = value; }
        }

        private double defense = 10;
        public double Defense
        {
            get { return defense; }
            set { if (value >= 0) defense = value; }
        }

        public string GetInfo()
        {
            return $"{Name} (XP={XP}) {Health}/{Attack}/{Defense}";
        }

        public void takeDamage(double damage)
        {
            if(damage > Defense)
                Health -= (damage - Defense);
        }
    }
}
