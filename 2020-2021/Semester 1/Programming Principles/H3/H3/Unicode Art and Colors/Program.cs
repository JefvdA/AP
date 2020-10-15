using System;

namespace Unicode_Art_and_Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string unicodeArt = @"
     _      __                      _             _          _     _   
  _ | |___ / _| __ ____ _ _ _    __| |___ _ _    /_\__ _____(_)_ _| |_ 
 | || / -_)  _| \ V / _` | ' \  / _` / -_) '_|  / _ \ V / _ \ | '_|  _|
  \__/\___|_|    \_/\__,_|_||_| \__,_\___|_|   /_/ \_\_/\___/_|_|  \__|";

            Console.WriteLine(unicodeArt);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(50, 1);
            Console.Write(@"_");
            Console.SetCursorPosition(49, 2);
            Console.Write(@"/_\");
            Console.SetCursorPosition(48, 3);
            Console.Write(@"/ _ \");
            Console.SetCursorPosition(47, 4);
            Console.Write(@"/_/ \_\");
            Console.SetCursorPosition(70, 5);
            Console.ResetColor();
        }
    }
}
