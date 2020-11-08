using System;

namespace BMI_met_enum
{
    class Program
    {
        enum Gewichten { Ondergewicht, Normaal, Overgewicht, Obees, Zwaarlijvig, Undefined}
        static void Main(string[] args)
        {
            Console.Write("Wat is je lengte?  >>");
            double lengte = double.Parse(Console.ReadLine());

            Console.Write("Wat is je gewicht?  >>");
            double gewicht = double.Parse(Console.ReadLine());

            double bmi = Math.Round(gewicht / (lengte * lengte), 2);

            Gewichten soortGewicht = Gewichten.Undefined;
            if (bmi < 18.5)
            {
                soortGewicht = Gewichten.Ondergewicht;
            }
            else if (bmi < 24.9)
            {
                soortGewicht = Gewichten.Normaal;
            }
            else if (bmi < 29.9)
            {
                soortGewicht = Gewichten.Overgewicht;
            }
            else if (bmi < 39.9)
            {
                soortGewicht = Gewichten.Obees;
            }
            else
            {
                soortGewicht = Gewichten.Zwaarlijvig;
            }

            switch (soortGewicht)
            {
                case Gewichten.Ondergewicht:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Je hebt een BMI van {bmi}");
                    Console.WriteLine(", je hebt ondergewicht!");
                    break;
                case Gewichten.Normaal:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Je hebt een BMI van {bmi}");
                    Console.WriteLine(", je hebt een normaal gewicht.");
                    break;
                case Gewichten.Overgewicht:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write($"Je hebt een BMI van {bmi}");
                    Console.WriteLine(", overgewicht, je loopt niet echt een risico maar je mag niet verdikken");
                    break;
                case Gewichten.Obees:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Je hebt een BMI van {bmi}");
                    Console.WriteLine(", verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
                    break;
                case Gewichten.Zwaarlijvig:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($"Je hebt een BMI van {bmi}");
                    Console.WriteLine(", Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
                    break;
                default:
                    Console.WriteLine("Er is een fout opgetreden met het berekenen van de bmi, probeer opnieuw");
                    break;
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
