using System;

namespace D3_Tekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Breedte en hoogte moeten tussen getallen van 2 tot en met 20 zijn!");
            Console.Write("Breedte:   >>>");
            int breedte = int.Parse(Console.ReadLine());

            Console.Write("Hoogte:   >>>");
            int hoogte = int.Parse(Console.ReadLine());

            if(breedte < 2 || breedte > 20 || hoogte < 2 || hoogte > 20)
            {
                Console.WriteLine("Foute invoer! Probeer opnieuw!");
                Environment.Exit(1);
            }

            for (int i = 0; i < hoogte; i++)
            {
                for (int j = 0; j < breedte; j++)
                {
                    if (i == 0 || i == hoogte - 1)
                        Console.Write("*");
                    else
                    {
                        if (j == 0 || j == breedte - 1)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
