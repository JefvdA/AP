using System.Collections.Generic;

namespace Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerData = new 
            {
                firstName = "Jef",
                lastName = "van der Avoirt",
                games = new List<Game>
                {
                    new Game("Fortnite", "Battle royale", 0),
                    new Game("PUBG", "Battle royale", 1)
                }
            };

            System.Console.WriteLine("Ik ben " + playerData.firstName + " " + playerData.lastName + "en mijn favoriete games zijn:");
            for (int i = 0; i < playerData.games.Count; i++)
            {
                System.Console.WriteLine(playerData.games[i]);
            }
        }
    }
}
