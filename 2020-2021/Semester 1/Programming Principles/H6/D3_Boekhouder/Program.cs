using System;

namespace D3_Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            double balans = 0;

            double pos = 0;
            double neg = 0;

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
                if (input > 0)
                    pos += input;
                else
                    neg += input;

                //Gemiddelde
                i++;
                gemiddelde = Math.Round(balans / i, 2);

                Console.WriteLine($"De balans is: {balans}");
                Console.WriteLine($"Som negatieve getallen: {neg}");
                Console.WriteLine($"Som positieve getallen: {pos}");
                Console.WriteLine($"Gemiddelde: {gemiddelde}");
            }
        }
    }
}