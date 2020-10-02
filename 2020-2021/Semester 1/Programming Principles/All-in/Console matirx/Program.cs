using System;

namespace Console_matirx
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                char teken = Convert.ToChar(random.Next(62, 400));
                Console.Write(teken);

                System.Threading.Thread.Sleep(1);

                if(random.Next(0, 3) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }
    }
}
