using System;

namespace Feestkassa
{
    class Program
    {
        static void Main(string[] args)
        {
            const int prijsFrietjes = 20;
            const int prijsKoninginnenhapjes = 10;
            const int prijsIjsjes = 3;
            const int prijsDrankjes = 2;


            Console.Write("Frietjes?");
            int frietjes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tussenprijs: {frietjes * prijsFrietjes}");

            Console.Write("Koninginnenhapjes?");
            int koninginnenhapjes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tussenprijs: {frietjes * prijsFrietjes} + {koninginnenhapjes * prijsKoninginnenhapjes}");

            Console.Write("Ijsjes?");
            int ijsjes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tussenprijs: {frietjes * prijsFrietjes} + {koninginnenhapjes * prijsKoninginnenhapjes} + {ijsjes * prijsIjsjes}");

            Console.Write("Drankjes?");
            int drankjes = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tussenprijs: {frietjes * prijsFrietjes} + {koninginnenhapjes * prijsKoninginnenhapjes} + {ijsjes * prijsIjsjes} + {drankjes * prijsDrankjes}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Het totaal te betalen bedrag is {frietjes * prijsFrietjes + koninginnenhapjes * prijsKoninginnenhapjes + ijsjes * prijsIjsjes + drankjes * prijsDrankjes} euro");

            Console.ReadKey();
        }
    }
}
