using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool gameOver = false;

            //Bal variables
            int balX = 5;
            int balY = 10;
            int vX = 1;
            int vY = 2;

            //Paddle A variables
            const int PADDLE_A_LOCATION_X = 5;
            int paddleALocationY = 10;
            int paddleALength = 5;

            while (!gameOver)
            {
                //Input verwerken
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (input.Key == ConsoleKey.W)
                        paddleALocationY--;
                    else if (input.Key == ConsoleKey.S)
                        paddleALocationY++;
                }

                //Updaten
                if (balX + vX >= Console.WindowWidth || balX + vX < 0)
                    vX *= -1;
                if (balY + vY >= Console.WindowHeight || balY + vY < 0)
                    vY *= -1;


                balX += vX;
                balY += vY;

                //Renderen
                Console.SetCursorPosition(balX, balY);
                Console.Write("O");

                for (int i = 0; i < paddleALength; i++)
                {
                    Console.SetCursorPosition(PADDLE_A_LOCATION_X, paddleALocationY-i);
                    Console.Write("|");
                }

                //Wait
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}
