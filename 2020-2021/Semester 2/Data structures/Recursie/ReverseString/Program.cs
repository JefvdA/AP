using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hallo"));
        }

        static string Reverse(string text)
        {
            if (text.Length > 0)
                return text[text.Length - 1] + Reverse(text.Substring(0, text.Length - 1));
            else
                return text;
        }
    }
}
