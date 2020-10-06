using System;

namespace Euro_Dollar
{
    class Program
    {
        static void Main(string[] args)
        {
            const float koers = 1.18f;

            Console.WriteLine("Vul aantal euro in dat omgerekend moet worden naar dollar");
            float euro = float.Parse(Console.ReadLine());
            float dollar = koers * euro;
            Console.WriteLine($"{euro} euro is gelijk aan {dollar} dollar!");
        }
    }
}
