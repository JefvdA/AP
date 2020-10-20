using System;

namespace op_de_poef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer bedrag in   >>");
            double poef = double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat nu op {poef}");

            Console.Write("Voer bedrag in   >>");
            poef += double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat nu op {poef}");

            Console.Write("Voer bedrag in   >>");
            poef += double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat nu op {poef}");

            Console.Write("Voer bedrag in   >>");
            poef += double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat nu op {poef}");

            Console.Write("Voer bedrag in   >>");
            poef += double.Parse(Console.ReadLine());
            Console.WriteLine($"De poef staat nu op {poef}");

            Console.WriteLine("");
            Console.WriteLine($"De poef staat nu op {poef} euro");
            Console.WriteLine("________________________________");

            double betalingsDuur = Math.Round(poef / 10);
            Console.WriteLine("");
            Console.WriteLine($"Het totaal van de poef is {poef} en het zal {betalingsDuur} weken duren voor afbetaald te worden!");

            Console.ReadKey();
        }
    }
}
