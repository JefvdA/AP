using System;

namespace Gemiddelde
{
    class Program
    {
        static void Main(string[] args)
        {
            int september = 248;
            int oktober = 270;
            int november = 310;

            double gemiddelde = (september + oktober + november) / 3.0;
            Console.WriteLine($"in sep, okt en nov sliep je gemiddeld {gemiddelde}u per maand");
        }
    }
}
