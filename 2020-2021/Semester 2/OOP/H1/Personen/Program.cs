using System;

namespace Personen
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon p1 = new Persoon();
            p1.name = "Jef";

            p1.Introductie();
        }
    }
}
