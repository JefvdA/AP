using System;
using System.Collections.Generic;

namespace StudentOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentenLijst = new List<Student>();
            studentenLijst.Add(new Student() { Klas = Klassen.EA1, Leeftijd = 18, Naam = "Jan Jansens", PuntenCommunicatie = 15, PuntenProgrammingPrinciples = 4, PuntenWebTech = 20 });
            studentenLijst.Add(new Student() { Klas = Klassen.EA2, Leeftijd = 16, Naam = "Tim Jansens", PuntenCommunicatie = 17, PuntenProgrammingPrinciples = 5, PuntenWebTech = 19 });
            studentenLijst.Add(new Student() { Klas = Klassen.EA2, Leeftijd = 18, Naam = "Bob Jansens", PuntenCommunicatie = 6, PuntenProgrammingPrinciples = 6, PuntenWebTech = 12 });
            studentenLijst.Add(new Student() { Klas = Klassen.EA3, Leeftijd = 20, Naam = "Joe Jansens", PuntenCommunicatie = 3, PuntenProgrammingPrinciples = 18, PuntenWebTech = 10 });
            studentenLijst.Add(new Student() { Klas = Klassen.EA4, Leeftijd = 40, Naam = "Jef Jansens", PuntenCommunicatie = 13, PuntenProgrammingPrinciples = 9, PuntenWebTech = 2 });

            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.Write("MENU: maak u keuze \n" +
                  "0: Student gegevens invoeren \n" +
                  "1: Student gegevens tonen \n" +
                  ">>>");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Student gegevens invoeren:");
                        Console.Write("Van welke student wil u gegevens invoeren? (1-5) \n" +
                                      ">>>");
                        input = Console.ReadLine();
                        int getal = 0;
                        if (!int.TryParse(input, out getal) || 0 >= getal || getal > studentenLijst.Count)
                        {
                            FouteInvoer();
                            continue;
                        }

                        Console.WriteLine($"Gegevens voor student {getal} invoeren: ");
                        Console.Write("Klas: \n" +
                        ">>>");
                        string klas = Console.ReadLine();
                        Klassen mijnKlas = (Klassen)Enum.Parse(typeof(Klassen), klas);
                        Console.Clear();
                        Console.Write("Leeftijd: \n" +
                        ">>>");
                        string leeftijdString = Console.ReadLine();
                        int leeftijd = 0;
                        if (!int.TryParse(leeftijdString, out leeftijd) || leeftijd < 0)
                        {
                            FouteInvoer();
                            continue;
                        }
                        Console.Clear();
                        Console.Write("Naam: \n" +
                        ">>>");
                        string naam = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Punten communicatie: \n" +
                        ">>>");
                        string communicatieString = Console.ReadLine();
                        int communicatie = 0;
                        if (!int.TryParse(communicatieString, out communicatie) || communicatie < 0 || communicatie > 20)
                        {
                            FouteInvoer();
                            continue;
                        }
                        Console.Clear();
                        Console.Write("Punten programming priciples: \n" +
                        ">>>");
                        string programmingString = Console.ReadLine();
                        int programming = 0;
                        if (!int.TryParse(programmingString, out programming) || programming < 0 || programming > 20)
                        {
                            FouteInvoer();
                            continue;
                        }
                        Console.Clear();
                        Console.Write("Punten webtech: \n" +
                        ">>>");
                        string webtechString = Console.ReadLine();
                        int webtech = 0;
                        if (!int.TryParse(webtechString, out webtech) || webtech < 0 || webtech > 20)
                        {
                            FouteInvoer();
                            continue;
                        }

                        int index = getal - 1;
                        studentenLijst[index].Klas = mijnKlas;
                        studentenLijst[index].Leeftijd = leeftijd;
                        studentenLijst[index].Naam = naam;
                        studentenLijst[index].PuntenCommunicatie = communicatie;
                        studentenLijst[index].PuntenProgrammingPrinciples = programming;
                        studentenLijst[index].PuntenWebTech = webtech;
                        break;
                    case "1":
                        for (int i = 0; i < studentenLijst.Count; i++)
                        {
                            studentenLijst[i].GeefOverzicht();
                        }
                        Console.ReadKey();
                        break;
                    default:
                        FouteInvoer();
                        continue;
                }
            }

            void FouteInvoer()
            {
                Console.Clear();
                Console.WriteLine("Foute invoer, probeer opnieuw!");
                Console.ReadKey();
            }
        }
    }
}
