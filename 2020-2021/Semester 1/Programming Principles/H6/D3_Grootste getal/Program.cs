using System;

namespace D3_Grootste_getal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int max = 0;
            do
            {
                y = y + x;

                //max waarde bijhouden
                if (x > max)
                {
                    max = x;
                }
                Console.WriteLine("Voer gehele waarden in (32767=stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);
            } while (x != 32767);
            Console.WriteLine($"Som is {y}");
            Console.WriteLine($"De grootste waarde die werd ingevoerd is {max}");
        }
    }
}
