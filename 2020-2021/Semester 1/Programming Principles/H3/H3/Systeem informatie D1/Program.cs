using System;

namespace Systeem_informatie_D1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's some information about your pc: ");
            Console.WriteLine($"OS Version: {System.Environment.OSVersion}");
            Console.WriteLine($"# of processors: {System.Environment.ProcessorCount}");
        }
    }
}
