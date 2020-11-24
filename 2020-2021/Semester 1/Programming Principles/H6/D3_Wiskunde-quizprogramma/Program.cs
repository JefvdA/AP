using System;

namespace D3_Wiskunde_quizprogramma
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool gameloop = true;
            int juisteAntwoorden = 0;
            int level = 1;

            while (gameloop)
            {
                int max = 5 * Convert.ToInt32(Math.Pow(2, level - 1));
                int x = random.Next(1, max);
                int y = random.Next(1, max);
                int product = x * y;

                //Console.WriteLine($"LEVEL: {level}, MAX: {max}");
                Console.Write($"{x} * {y} = ");
                int input = int.Parse(Console.ReadLine());

                //Antwoord nakijken
                if (input == product)
                {
                    juisteAntwoorden++;
                    Console.WriteLine("Proficiat, juiste antwoord druk op een knop om verder te gaan!");
                }
                else
                {
                    Console.WriteLine($"Fout... het juiste antwoord was: {product}");
                    gameloop = false;
                }

                //Level stijgen bij 5 juiste antwoorden
                if (juisteAntwoorden % 5 == 0)
                {
                    level++;
                }

                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"In totaal heb je {juisteAntwoorden} keer juist geantwoord!");
        }
    }
}
