using System;
using System.Collections.Generic;
using System.Text;

namespace OOPQuest.GameClasses
{
    class Game
    {
        public void StartGame()
        {
            bool gameLoop = true;

            ShowIntro();

            do
            {
                ShowStartScreen();
                Console.Write("Maak je keuze: >>>");
                int keuze = int.Parse(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        StartMainGame();
                        break;
                    case 2:
                        ShowOptionsScreen();
                        break;
                    case 3:
                        gameLoop = false;
                        break;
                }
            } while (gameLoop);
        }

        private void ShowIntro()
        {
            Console.Clear();
            Console.WriteLine("Hier komt de intro!");
        }

        private void ShowStartScreen()
        {
            Console.WriteLine("1 = Start game");
            Console.WriteLine("2 = Options");
            Console.WriteLine("3 = Quit");
        }

        private void ShowOptionsScreen()
        {
            Console.Clear();
            Console.WriteLine("OPTIONS!");
        }

        private void StartMainGame()
        {
            Hero hero = GenerateHero();
            Console.WriteLine("Your current hero: ");
            Console.WriteLine(hero.GetInfo());
            do
            {
                // TODO think about the lvl of the hero
                Monster monster = GenerateMonster();

                do
                {
                    Console.Clear();
                    Console.WriteLine("Attack: ");
                    // Attack choice
                    monster.takeDamage(hero.Attack);
                    if (monster.Health > 0)
                        hero.takeDamage(monster.Attack);
                    else
                        hero.XP += monster.XP;
                    Console.WriteLine(hero.GetInfo());
                    Console.WriteLine(monster.GetInfo());
                    Console.ReadLine();
                } while (monster.Health > 0 && hero.Health > 0);
            } while (hero.Health>0);
        }

        // TODO put this in monster class (static)
        private Monster GenerateMonster()
        {
            return new Monster();
        }

        private Hero GenerateHero()
        {
            Random random = new Random();

            Hero hero = new Hero();
            hero.Attack = random.Next(10, 51);
            hero.Type = (HeroType)random.Next(0, 4);
            hero.Defense = random.Next(10, 51);
            hero.Name = "Random held nummer: " + random.Next(0, 100);
            hero.Health = 100;

            return hero;
        }
    }
}
