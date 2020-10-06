using System;

namespace Simple_maths
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1 + 4 * 6;
            int b = (35 + 5) % 7;
            int c = 14 + -4 * 6 / 11;
            int d = 2 + 15 / 6 * 1 - 7 % 2;

            double w = -1.0 + 4.0 * 6.0;
            double x = (35.0 + 5.0) % 7.0;
            double y = 14.0 + -4.0 * 6.0 / 11.0;
            double z = 2.0 + 15.0 / 6.0 * 1.0 - 7.0 % 2.0;

            Console.WriteLine("Met int: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Met double: ");
            Console.WriteLine(w);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
