using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AANTAL_BALLETJES = 100;
            Random random = new Random();
            Balletje[] balletjes = new Balletje[AANTAL_BALLETJES];

            for (int i = 0; i < balletjes.Length; i++)
            {
                balletjes[i] = new Balletje();
                balletjes[i].X = random.Next(10, 20);
                balletjes[i].Y = random.Next(10, 20);
                balletjes[i].VectorX = random.Next(-2, 3);
                balletjes[i].VectorY = random.Next(-2, 3);
            }

            while (true)
            {
                for (int i = 0; i < balletjes.Length; i++)
                {
                    balletjes[i].Update();
                    balletjes[i].TekenOpScherm();
                }

                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}
