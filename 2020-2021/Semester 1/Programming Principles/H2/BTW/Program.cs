using System;

namespace BTW
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BTW = 0.21;

            Console.Write("Vul een prijs in in euro: >>");
            double prijs = double.Parse(Console.ReadLine());
            double prijsGeenBTW = prijs * (1 - BTW);

            Console.WriteLine($"{prijs} euro, zou {prijsGeenBTW} euro geweest zijn, mocht er geen {BTW * 100}% BTW ingerekend zijn!");            
        }
    }
}
