using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            //Vraag 1
            Console.WriteLine("QUIZ: geef als antwoord A B C D ");
            Console.WriteLine("Wat is de hoofdstad van Congo?");
            Console.Write("A - Gaborone || B - Bangui || C - Kinshasa || D - Gitega ||     Antwoord(a,b,c,d):     >>");
            string input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "a":
                    Console.WriteLine("Fout, het juiste antwoord was: C - Kinshasa");
                    score -= 1;
                    break;
                case "b":
                    Console.WriteLine("Fout, het juiste antwoord was: C - Kinshasa");
                    score -= 1;
                    break;
                case "c":
                    Console.WriteLine("Proficiat, je hebt de vraag juist beantwoord!");
                    score += 2;
                    break;
                case "d":
                    Console.WriteLine("Fout, het juiste antwoord was: C - Kinshasa");
                    score -= 1;
                    break;
            }
            Console.WriteLine($"Je huidige score bedraagt {score}");
            Console.ReadKey();
            Console.Clear();


            //Vraag 2
            Console.WriteLine("Wie is de president van Brazilie?");
            Console.Write("A - Donald Trump || B - Jair Bolsonaro || C - Emmanuel Macron || D - Marcelo Rebelo de Sousa ||     Antwoord(a,b,c,d):     >>");
            input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "a":
                    Console.WriteLine("Fout, het juiste antwoord was: B - Jair Bolsonaro");
                    score -= 1;
                    break;
                case "b":
                    Console.WriteLine("Proficiat, je hebt de vraag juist beantwoord!");
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("Fout, het juiste antwoord was: B - Jair Bolsonaro");
                    score -= 1;
                    break;
                case "d":
                    Console.WriteLine("Fout, het juiste antwoord was: B - Jair Bolsonaro");
                    score -= 1;
                    break;
            }
            Console.WriteLine($"Je huidige score bedraagt {score}");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine($"Je eindscore bedraagt {score}, proficiat!");
            Console.ReadKey();
        }
    }
}
