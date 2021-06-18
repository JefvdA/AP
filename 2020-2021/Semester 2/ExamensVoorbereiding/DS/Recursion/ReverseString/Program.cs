using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string for the reversion:   >>>");
            string input = Console.ReadLine();

            Console.WriteLine(ReverseString(input));
        }

        static string ReverseString(string text)
        {
            if (text.Length == 1)
                return text;
            return ReverseString(text.Substring(1)) + text[0];
        }
    }
}
