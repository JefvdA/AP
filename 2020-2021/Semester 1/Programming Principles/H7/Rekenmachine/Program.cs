using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("REKENMACHINE");
            Console.Write("Getal 1:   >>>");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Operator: (+, -, *, /)   >>>");
            string op = Console.ReadLine();
            Console.Write("Getal 2:   >>>");
            double y = double.Parse(Console.ReadLine());

            double output = 0;
            switch (op)
            {
                case "+":
                    output = TelOp(x, y);
                    break;
                case "-":
                    output = TrekAf(x, y);
                    break;
                case "*":
                    output = VermenigVuldig(x, y);
                    break;
                case "/":
                    output = Deel(x, y);
                    break;
                default:
                    Console.WriteLine("Er is een fout opgetreden!");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine($"{x} {op} {y} = {output}");
        }

        static double TelOp(double x, double y)
        {
            return x + y;
        }

        static double TrekAf(double x, double y)
        {
            return x - y;
        }

        static double VermenigVuldig(double x, double y)
        {
            return x * y;
        }

        static double Deel(double x, double y)
        {
            return x / y;
        }
    }
}
