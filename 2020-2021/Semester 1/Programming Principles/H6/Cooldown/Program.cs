//Programma werkt niet met alle delen tegelijk (gescheiden met witlijn)
//Uncomment delen om ze uit te voeren
//Cnrt + E + U = Uncomment; Cntr + E + C = Comment
using System;

namespace D2_Cooldown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            ////Toon alle getallen die een veelvoud van 3 zijn en oneven zijn tot en met 100
            //for (int i = 0; i < 101; i++)
            //{
            //    if (i % 3 == 0 && i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////Toon alle machten tot 5 van n
            //Console.Write("Input:   >>>");
            //n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine($"{n}^{i} = {Math.Pow(n, i)}");
            //}

            ////Toon de tafels tot 10 van ieder getal van 1 tot en met n.
            //Console.Write("Input:   >>>");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i < 11; i++)
            //{
            //    for (int j = 0; j < n + 1; j++)
            //    {
            //        Console.Write($"{i} * {j} = {i * j},");
            //    }
            //    Console.WriteLine();
            //}

            ////Schrijf een programma om de eerste n termen van een harmonische reeks te tonen en bereken vervolgens de som van deze termen.
            //Console.Write("Input:   >>>");
            //n = int.Parse(Console.ReadLine());
            //double som = 0;
            //for (int i = 1; i < n+1; i++)
            //{
            //    double x = 1.0 / i;
            //    som += x;
            //    Console.Write($"1/{i} + ");
            //}
            //Console.WriteLine($"\nSom = {som}");

            ////Schrijf een programma dat de som van de serie 9+99+999+9999... berkent.
            //int x = 9;
            //int sum = 0;
            //for (int i = 1; i < 7; i++)
            //{
            //    int nextNumber = 0;
            //    for (int j = i-1; j > -1; j--)
            //    {
            //        int nextPartOfNumber = x * Convert.ToInt32(Math.Pow(10, j));
            //        nextNumber += nextPartOfNumber;
            //    }
            //    Console.Write($"{nextNumber} + ");
            //    sum += nextNumber;
            //}
            //Console.WriteLine($"\n= {sum}");

            ////Vraag aan de gebruiker getallen tot hij -1 invoert. Toon het gemiddelde van deze getallen
            //int som = 0;
            //int i = -1;
            //n = 0;
            //do
            //{
            //    som += n;
            //    i++;
            //    Console.Write("Input:   >>>");
            //    n = int.Parse(Console.ReadLine());
            //} while (n != -1);
            //int gemiddelde = som / i;
            //Console.WriteLine($"Het gemiddelde van de ingevoerde getallen is {gemiddelde}");
        }
    }
}
