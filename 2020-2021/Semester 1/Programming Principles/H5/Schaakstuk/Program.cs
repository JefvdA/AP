using System;

namespace Schaakstuk
{
    class Program
    {
        enum Kleur { Witte, Zwarte }
        enum Stuk { Toren, Paard, Loper, Koning, Koningin, Pion}

        static void Main(string[] args)
        {
            Random random = new Random();
            int kleurID = random.Next(0, Enum.GetNames(typeof(Kleur)).Length);
            int stukID = random.Next(0, Enum.GetNames(typeof(Stuk)).Length);

            Kleur kleur = (Kleur)kleurID;
            Stuk stuk = (Stuk)stukID;

            Console.WriteLine($"{kleur} {stuk}");
        }
    }
}
