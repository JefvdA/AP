using System;

namespace GuntherD_Stemwijzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stemwijzer! Antwoord met j en n op de vragen!");
            Console.Write("Werk je veel?   >>");
            string input = Console.ReadLine();
            Console.Clear();

            if(input == "j")
            {
                Console.Write("Koop je soms bruin brood?   >>");
                input = Console.ReadLine();
                Console.Clear();

                if(input == "j")
                {
                    Console.Write("Ben je een seut?   >>");
                    input = Console.ReadLine();
                    Console.Clear();

                    if(input == "j")
                    {
                        Console.WriteLine("Je stemprofiel is: CD&V   >>");
                    }else
                    {
                        Console.Write("Heb je vrienden?");
                        input = Console.ReadLine();
                        Console.Clear();

                        if(input == "j")
                        {
                            Console.Write("Staat je wagen, huis, ... ingeschreven op naam van jouw ouders?   >>");
                            input = Console.ReadLine();

                            if (input == "j")
                            {
                                Console.WriteLine("Je stemprofiel is: OPEN VLD");
                            } else
                            {
                                Console.WriteLine("Je stemprofiel is: BLANCO");
                            }
                        } else
                        {
                            Console.WriteLine("Je stemprofiel is: NVA");
                        }
                    }
                } else
                {
                    Console.WriteLine("Je stemprofiel is: VLAAMS BELANG");
                }
            }else
            {
                Console.Write("Eet je vaak Quinoa?   >>");
                input = Console.ReadLine();
                Console.Clear();

                if(input == "j")
                {
                    Console.WriteLine("Je stemprofiel is: GROEN");
                } else
                {
                    Console.Write("Krijg je vaak de schuld van alles?   >>");
                    input = Console.ReadLine();
                    Console.Clear();

                    if(input == "j")
                    {
                        Console.WriteLine("Je stemprofiel is: SP.A");
                    } else
                    {
                        Console.Write("Geloof je nog in sinterklaas?   >>");
                        input = Console.ReadLine();
                        Console.Clear();

                        if(input == "j")
                        {
                            Console.WriteLine("Je stemprofiel is: PVDA");
                        } else
                        {
                            Console.WriteLine("Je stemprofiel is: BLANCO");
                        }
                    }
                }
            }
        }
    }
}
