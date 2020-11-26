using System;

namespace D3_Schaar_steen_papier
{
    class Program
    {
        enum Opties { Schaar=1, Steen, Papier }

        static void Main(string[] args)
        {
            Random random = new Random();

            int scoreSpeler = 0;
            int scorePC = 0;

            //Gameloop
            while (scoreSpeler < 10 && scorePC < 10)
            {
                //Keuze PC
                int pcKeuzeInt = random.Next(1, 4);
                Opties pcKeuze = (Opties)pcKeuzeInt;

                //Keuze Speler
                Console.Write("Schaar = 1; Steen = 2; Papier = 3; Keuze:   >>>");
                int spelerKeuzeInt = int.Parse(Console.ReadLine());
                Opties spelerKeuze = (Opties)spelerKeuzeInt;

                //Toon keuzes aan speler
                Console.WriteLine($"SPELER: {spelerKeuze};      PC: {pcKeuze}");    

                //Gelijk gespeeld?
                if (spelerKeuze == pcKeuze) //JA
                {
                    Console.WriteLine("Gelijk! Niemand wint deze ronde");
                }
                else //NEE
                {
                    //Wint speler?
                    bool wintSpeler = false;
                    switch (spelerKeuze)
                    {
                        case Opties.Schaar:
                            if (pcKeuze == Opties.Papier)
                                wintSpeler = true;
                            break;
                        case Opties.Steen:
                            if (pcKeuze == Opties.Schaar)
                                wintSpeler = true;
                            break;
                        case Opties.Papier:
                            if (pcKeuze == Opties.Steen)
                                wintSpeler = true;
                            break;
                    }

                    if (wintSpeler) //JA
                    {
                        scoreSpeler++;
                        Console.WriteLine("Gewonnen!");
                    }
                    else //NEE
                    {
                        scorePC++;
                        Console.WriteLine("Verloren!");
                    }

                    //Toon uitslag ronde
                    Console.WriteLine($"Uitslag ronde: SPELER:PC {scoreSpeler}:{scorePC}");
                }

                //Wacht tot toets ingedrukt wordt
                Console.ReadKey();

                //Clear
                Console.Clear();
            }
            //Toon totale uitslag
            if (scoreSpeler > scorePC)
            {
                Console.WriteLine($"Je hebt PC verslagen, totale uitslag: {scoreSpeler}:{scorePC}");
            }
            else
            {
                Console.WriteLine($"Je bent verloren... , totale uitslag: {scoreSpeler}:{scorePC}");
            }
        }
    }
}
