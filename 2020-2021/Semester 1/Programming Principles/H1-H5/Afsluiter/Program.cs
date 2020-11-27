using System;

namespace Afsluiter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een item uit het menu: 1 - Rekenmachine, 2 - Password tester, 3 - Recyclage, 4 - Computersolver");
            Console.Write(">>>");

            string input = Console.ReadLine();

            Console.Clear();
            switch (input)
            {
                case "1":
                    Rekenmachine();
                    break;
                case "2":
                    PasswordTester();
                    break;
                case "3":
                    Recyclage();
                    break;
                case "4":
                    Computersolver();
                    break;
                default:
                    Console.WriteLine("Je koos een ongeldig menuitem, start het programma opnieuw!");
                    break;
            }

            Console.ReadKey();
        }

        static void Rekenmachine()
        {
            Console.WriteLine("Je koos voor 1 - Rekenmachine");
            Console.ReadKey();

            Console.Write("Geef het eerste getal:   >>>");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef het tweede getal:   >>>");
            int getal2 = int.Parse(Console.ReadLine());

            Console.Write("Welke operator? (+, -, *, /, %)   >>>");
            string oper = Console.ReadLine();

            double output = 0;
            switch (oper)
            {
                case "+":
                    output = getal1 + getal2;
                    break;
                case "-":
                    output = getal1 - getal2;
                    break;
                case "*":
                    output = getal1 * getal2;
                    break;
                case "/":
                    output = getal1 / getal2;
                    break;
                case "%":
                    output = getal1 % getal2;
                    break;
                default:
                    Console.WriteLine("Je koos geen geldige operator, start het programma opnieuw!");
                    break;
            }

            if (output > 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine($"{getal1} {oper} {getal2} = {output}");
        }
    
        static void PasswordTester()
        {
            Console.WriteLine("Je koos voor 2 - Password tester");
            Console.Write("Wachtwoord:  >>>");
            string input = Console.ReadLine();

            if(input == "BidenSux")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Toegelaten!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Verboden!");
            }
        }
    
        static void Recyclage()
        {
            Console.WriteLine("Je koos voor 3 - recyclage");
            Console.WriteLine("Fuck off geen zin in");
        }
    
        static void Computersolver()
        {
            Console.WriteLine("Flowchart om computerproblemen op te lossen: (antwoord met y/n)");
            Console.Write("Does the computer turn on?  >>>");
            Console.Clear();
            string input = Console.ReadLine();

            if(input == "y")
            {
                Console.Write("Is the computer power light on?  >>>");
                Console.Clear();
                input = Console.ReadLine();

                if(input == "y")
                {
                    Console.WriteLine("Turn the computer monitor on!");
                }
                else
                {
                    Console.WriteLine("Check the computer power cord!");
                }
            }
            else
            {
                Console.Write("Are there any error messages?  >>>");
                Console.Clear();
                input = Console.ReadLine();

                if(input == "y")
                {
                    Console.WriteLine("Perform a search for the error message");
                }
                else
                {
                    Console.WriteLine("Computer is fine");
                }
            }
        }
    }
}
