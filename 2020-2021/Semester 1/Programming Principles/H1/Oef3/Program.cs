using System;

namespace Oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je naam? >");
            string Name = Console.ReadLine();

            Console.Write("Wat is je adres? >");
            string Adress = Console.ReadLine();

            Console.Write("Wat is je hobby? >");
            string Hobby = Console.ReadLine();

            Console.Write("Waarom deze opleiding? >");
            string Why1 = Console.ReadLine();

            Console.Write("Waarom AP? >");
            string Why2 = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("Naam: " + Name + "\nAdres: " + Adress + "\nHobby: " + Hobby + "\nWhy TI: " + Why1 + "\nWhy AP: " + Why2);
            
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
