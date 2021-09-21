using System;

namespace Drinkenbussen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Rugzak rugzak = new Rugzak();
            Console.WriteLine("Hoeveel items moeten er in de sportzak komen");
            int sportItemCount = int.Parse(GetInput()); // We gaan er van uit dat de gebruiker input zal geven die naar een int geparsed kan worden

            for (int i = 0; i < sportItemCount; i++)
            {
                SportItem sportItem;

                int randomNumber = random.Next(0, 2);
                if (randomNumber == 0)
                    sportItem = new SportItem();
                else
                    sportItem = new Drinkenbus();

                Console.WriteLine($"Ik koos {sportItem} voor je. Welke key moet dit krrijgen?");
                string key = GetInput();


                rugzak.SportItems.Add(key, sportItem);
            }
            Console.WriteLine("Ik ben klaar, druk op enter hierna om telkens een visualisatie te doen");

            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine(rugzak);
                Console.ReadLine();
                Console.Clear();
                rugzak.Visualiseer();
                Console.ReadLine();
            }
        }

        static string GetInput()
        {
            Console.Write(">>>");
            return Console.ReadLine();
        }
    }
}
