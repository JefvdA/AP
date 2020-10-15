using System;

namespace Weerstandberekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de waarde voor de eerste ring:  >>");
            int ring1 = int.Parse(Console.ReadLine()) * 10;
            Console.Write("Geef de waarde voor de tweede ring:  >>");
            int ring2 = int.Parse(Console.ReadLine());
            Console.Write("Geef de waarde voor de derde ring:  >>");
            double ring3 = Math.Pow(10, int.Parse(Console.ReadLine()));

            double waarde = (ring1 + ring2) * ring3;


            string table = @$"
╔═══════════════╦═══════════════╦═══════════════╦═══════════════╗
║RING 1         ║RING 2         ║RING 3         ║Totaal (Ohm)   ║
╟───────────────╫───────────────╢───────────────║───────────────║
║{ring1}             ║{ring2}              ║{ring3}            ║{waarde} Ohm   ║
╚═══════════════╩═══════════════╩═══════════════╩═══════════════╝";
            Console.WriteLine(table);
        }
    }
}
