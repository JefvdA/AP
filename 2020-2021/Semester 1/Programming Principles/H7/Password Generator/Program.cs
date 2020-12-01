using System;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef lengte voor password:   >>>");
            int lengte = int.Parse(Console.ReadLine());
            string password = Generate(lengte);

            Console.WriteLine($"Je veilig gegenereerd wachtwoord is: {password}");
        }

        static string Generate(int lengte)
        {
            Random random = new Random();
            string password = "";

            for (int i = 0; i < lengte; i++)
            {
                int x = random.Next(0, 2);
                if (x == 0) // Generate number
                {
                    int y = random.Next(0, 10);
                    password += y;
                }
                else // Generate letter
                {
                    int y = random.Next(97, 123);
                    password += (char)y;
                }
            }

            return password;
        }
    }
}
