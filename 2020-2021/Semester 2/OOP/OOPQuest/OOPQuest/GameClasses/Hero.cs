using System;
using System.Collections.Generic;
using System.Text;

namespace OOPQuest.GameClasses
{
    enum HeroType { Barbarian, Paladin, Archer, Wizzard }

    class Hero
    {
        public string Name { get; set; } = "Onbekend";

        private double health;
        public double Health
        {
            get { return health; }
            set
            {
                if (value > 0 && value <= 100)
                    health = value;
            }
        }


        public int XP { get; set; } = 0;

        private double attack;
        public double Attack
        {
            get { return attack; }
            set { if (value >= 0) attack = value; }
        }

        private double defense;
        public double Defense
        {
            get { return defense; }
            set { if (value >= 0) defense = value; }
        }

        public HeroType Type { get; set; }


        public string GetInfo()
        {
            return $"{Name} ({Type}, XP={XP}) {Health}/{Attack}/{Defense}";
        }

        public void takeDamage(double damage)
        {
            if (damage > Defense)
                Health -= (damage - Defense);
        }
    }
}
