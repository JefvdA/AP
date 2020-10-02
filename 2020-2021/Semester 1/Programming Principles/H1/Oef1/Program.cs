using System;

namespace H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je favoriete kleur? >");
            string Kleur = Console.ReadLine();

            Console.Write("Wat is je favoriete eten? >");
            string Eten = Console.ReadLine();

            Console.Write("Wat is je favoriete auto? >");
            string Auto = Console.ReadLine();

            Console.Write("Wat is je favoriete film? >");
            string Film = Console.ReadLine();

            Console.Write("Wat is je favoriete boek? >");
            string Boek = Console.ReadLine();

            Console.WriteLine("Je favoriete kleur is " + Eten + ". Je eet graag " + Auto + ". Je lievelingsfilm is " + Boek + " en je favoriete film is " + Kleur);
        }
    }
}
