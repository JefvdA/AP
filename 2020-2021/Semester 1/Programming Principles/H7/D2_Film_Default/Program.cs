using System;

namespace D2_Film_Default
{
    class Program
    {
        enum Genres { Drama, Actie, Avontuur, Sci_fi, Onbekend }

        static void Main(string[] args)
        {
            FilmRuntime("A new Hope", genre: Genres.Sci_fi);
            FilmRuntime("Joker", 120);
            FilmRuntime("TITEL");
        }

        static void FilmRuntime(string name, int duration = 90, Genres genre = Genres.Onbekend)
        {
            Console.WriteLine($"{name} ({duration}minuten, {genre})");
        }
    }
}
