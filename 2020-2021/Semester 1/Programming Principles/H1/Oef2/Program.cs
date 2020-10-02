using System;

namespace H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Wat is je favoriete kleur? >");
            string Kleur = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Wat is je favoriete eten? >");
            string Eten = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Wat is je favoriete auto? >");
            string Auto = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Wat is je favoriete film? >");
            string Film = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Wat is je favoriete boek? >");
            string Boek = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Je favoriete kleur is " + Eten + ". Je eet graag " + Auto + ". Je lievelingsfilm is " + Boek + " en je favoriete film is " + Kleur);

        }
    }
}
