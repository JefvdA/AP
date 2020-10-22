using System;

namespace BMI_met_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is je lengte?  >>");
            double lengte = double.Parse(Console.ReadLine());

            Console.Write("Wat is je gewicht?  >>");
            double gewicht = double.Parse(Console.ReadLine());

            double bmi = Math.Round(gewicht / (lengte * lengte), 2);
            
            if(bmi < 18.5){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Je hebt een BMI van {bmi}");
                Console.WriteLine(", je hebt ondergewicht!");
            } else if(bmi < 24.9) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Je hebt een BMI van {bmi}");
                Console.WriteLine(", je hebt een normaal gewicht.");
            } else if(bmi < 29.9) {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"Je hebt een BMI van {bmi}");
                Console.WriteLine(", overgewicht, je loopt niet echt een risico maar je mag niet verdikken");
            } else if(bmi < 39.9) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Je hebt een BMI van {bmi}");
                Console.WriteLine(", verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
            } else {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"Je hebt een BMI van {bmi}");
                Console.WriteLine(", Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd).");
            }

            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
