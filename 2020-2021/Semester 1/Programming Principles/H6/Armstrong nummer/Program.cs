using System;

namespace D1_Armstrong_nummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input:   >>>");
            string input = Console.ReadLine();

            int lengte = input.Length;

            int nummer = int.Parse(input);
            int som = 0;
            for (int i = lengte; i > 0; i--)
            {
                int exponent = Convert.ToInt32(Math.Pow(10, i - 1));
                int getal = nummer / exponent;
                nummer -= getal * exponent;
                som += Convert.ToInt32(Math.Pow(getal, lengte));
            }

            if(som == int.Parse(input))
                Console.WriteLine($"{int.Parse(input)} is een Armstrong nummer!");
            else
                Console.WriteLine($"{int.Parse(input)} is geen Armstrong nummer!");
        }
    }
}
