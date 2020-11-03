using System;

namespace Enum_seizoenen
{
    class Program
    {
        enum Seizoen { WINTER, LENTE, ZOMER, HERFST, UNDECLARED }

        static void Main(string[] args)
        {
            Console.Write("Geef een maand (1-12)     >>");
            int input = int.Parse(Console.ReadLine());

            Seizoen seizoen = Seizoen.UNDECLARED;
            switch (input)
            {
                case int i when 0 < i && i < 4:
                    seizoen = Seizoen.WINTER;
                    break;
                case int i when 3 < i && i < 7:
                    seizoen = Seizoen.LENTE;
                    break;
                case int i when 6 < i && i < 10:
                    seizoen = Seizoen.ZOMER;
                    break;
                case int i when 9 < i && i < 13:
                    seizoen = Seizoen.HERFST;
                    break;
            }

            Console.WriteLine($"De maand {input} ligt in de {seizoen}!");

            if(seizoen == Seizoen.LENTE || seizoen == Seizoen.ZOMER)
            {
                Console.WriteLine($"De maand {input} ligt in een warm seizoen!");
            } else
            {
                Console.WriteLine($"De maand {input} ligt in een koud seizoen!");
            }

            Console.ReadKey();
        }
    }
}
