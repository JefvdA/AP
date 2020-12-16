using System;

namespace Vraag_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vragen = {"Hoe oud ben je?", 
                               "Wat is je postcode?", 
                               "Hoeveel broers heb je?", 
                               "Hoeveel zussen heb je?", 
                               "Wanneer ben je geboren", 
                               "Hoeveel is 3+5?" };

            int[] antwoorden = new int[vragen.Length];

            for (int i = 0; i < vragen.Length; i++)
            {
                Console.Write($"{vragen[i]}:   >>>");
                antwoorden[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Dit waren je antwoorden:");
            for (int i = 0; i < vragen.Length; i++)
            {
                Console.WriteLine($"{vragen[i]} : {antwoorden[i]}");
            }
        }
    }
}
