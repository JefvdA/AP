using System;

namespace D1_Euler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 1000;

            int som = 0;
            for (int i = 0; i < x + 1; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    som += i;
            }

            Console.WriteLine(som);
        }
    }
}
