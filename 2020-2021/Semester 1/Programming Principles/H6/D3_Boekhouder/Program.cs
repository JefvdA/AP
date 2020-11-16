using System;

namespace D3_Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            double balans = 0;

            int pos = 0;
            int neg = 0;

            int i = 0;
            double gemiddelde = 0;

            double input = 0;
            while (true)
            {
                Console.Write("Input:   >>>");
                input = double.Parse(Console.ReadLine());

                //Balans
                balans += input;

                //Pos + neg getallen
                if (input % 2 == 0)
                    pos += 1;
                else
                    neg += 1;

                //Gemiddelde
                i++;
                Console.WriteLine($"Balans: {balans}, I: {i}");
                gemiddelde = Math.Round(balans / i, 2);

                Console.WriteLine($"De balans is: {balans}");
                Console.WriteLine($"Aantal negatieve getallen: {neg}");
                Console.WriteLine($"Aantal positieve getallen: {pos}");
                Console.WriteLine($"Gemiddelde: {gemiddelde}");
            }
        }
    }
}
