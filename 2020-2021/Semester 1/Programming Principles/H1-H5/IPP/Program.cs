using System;

namespace IPP
{
    class Program
    {
        enum Bodems { CheesyCrust, MartianMeal, PegasusLime, Onbekend }
        enum Toppings { EndraliPies, ItalianCheese, Geen, Onbekend}

        static void Main(string[] args)
        {
            double pizzaPrijs = 0;
            //bodemPrijzen: 1 - Cheesy crust, 2 - Martian meal, 3 - Pegasus lime
            double[] bodemPrijzen = { 5, 2.8, 12.4 };

            //Bodems
            Console.WriteLine("Welkom bij Intergalactic PizzaPhone");
            Console.Write("Geef het type bodem: 1 - Cheesy crust, 2 - Martian meal, 3 - Pegasus lime:   >>>");
            int input = int.Parse(Console.ReadLine());

            Bodems bodem = Bodems.Onbekend;
            switch (input)
            {
                case 1:
                    bodem = Bodems.CheesyCrust;
                    break;
                case 2:
                    Console.WriteLine("De Martian meal is niet geschikt voor kinderen onder de 54 jaar!");
                    Console.Write("Wat is de leeftijd:   >>>");
                    input = int.Parse(Console.ReadLine());

                    if (input < 54)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR!");
                        Console.ResetColor();
                    }
                    else
                    {
                        bodem = Bodems.MartianMeal;
                    }
                    break;
                case 3:
                    bodem = Bodems.PegasusLime;
                    break;
                default:
                    Console.WriteLine("Sorry maar dit is geen geldig antwoord, probeer opnieuw");
                    break;
            }
            Console.Clear();

            int bodemIndex = (int)bodem;
            double bodemPrijs = bodemPrijzen[bodemIndex];
            pizzaPrijs += bodemPrijs;

            //Toppings
            Console.Write("Geef het type topping: 1 - Endrali pies, 2 - Italian cheese, 3 - Geen:   >>>");
            input = int.Parse(Console.ReadLine());

            double toppingPrijs = 0;
            Toppings topping = Toppings.Onbekend;
            switch (input)
            {
                case 1:
                    topping = Toppings.EndraliPies;

                    if (bodem == Bodems.CheesyCrust)
                        toppingPrijs = 10;
                    else
                        toppingPrijs = 15;
                    break;
                case 2:
                    topping = Toppings.ItalianCheese;
                    toppingPrijs = 5.5;
                    break;
                case 3:
                    topping = Toppings.Geen;
                    break;
                default:
                    Console.WriteLine("Sorry maar dit is geen geldig antwoord, probeer opnieuw");
                    break;
            }
            Console.Clear();

            //Chef's extra
            bool chefsExtra = false;
            if(topping == Toppings.Geen)
            {
                Console.Write("Wenst u de chef's extra? (1 - Ja, 2 - Nee)   >>>");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    chefsExtra = true;
                    toppingPrijs = 1;
                }
            }
            Console.Clear();

            pizzaPrijs += toppingPrijs;

            //Afstand
            Console.Write("Hoever is het leveradres in lichtjaren: 1 - 100   >>>");
            input = int.Parse(Console.ReadLine());
            if(!(0 < input && input < 101))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.ResetColor();
                Environment.Exit(1);
            }
            int afstand = input;

            //Visualisatie
            Console.Write("Pizzabestelling: ");
            switch (bodem)
            {
                case Bodems.CheesyCrust:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("C");
                    break;
                case Bodems.MartianMeal:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("M");
                    break;
                case Bodems.PegasusLime:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("P");
                    break;
                case Bodems.Onbekend:
                    Console.WriteLine("Er was een fout opgetreden bij het selecteren van een bodem");
                    break;
                default:
                    Console.WriteLine("Er was een fout opgetreden bij het selecteren van een bodem");
                    break;
            }
            Console.ResetColor();

            switch (topping)
            {
                case Toppings.EndraliPies:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("O");
                    break;
                case Toppings.ItalianCheese:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("O");
                    break;
                case Toppings.Geen:
                    if(chefsExtra)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("E");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Z");
                    }
                    break;
                case Toppings.Onbekend:
                    Console.WriteLine("Er was een fout opgetreden bij het selecteren van een topping");
                    break;
                default:
                    Console.WriteLine("Er was een fout opgetreden bij het selecteren van een topping");
                    break;
            }
            Console.ResetColor();
            Console.Write("\n");

            //Prijsberekening
            double transportKosten = 0;
            if (afstand < 10)
                transportKosten = 25;
            else
                transportKosten = Math.Sqrt(afstand / pizzaPrijs) + pizzaPrijs;

            if (chefsExtra)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 51);
                double korting = randomNumber / 100;

                transportKosten *= korting;
            }
            transportKosten = Math.Floor(transportKosten);
            double totaalPrijs = pizzaPrijs + transportKosten;

            //Benzine
            decimal tonnen = Math.Ceiling(afstand / 5.0m);
            decimal laatsteTon;
            if(afstand % 5 == 0)
            {
                laatsteTon = 1;
            }
            else
            {
                laatsteTon = tonnen - (afstand / 5.0m);
            }

            //Ticket
            Console.WriteLine($"{bodem}     {bodemPrijs} \n" +
                $"{topping}, Chef's extra: {chefsExtra}     {toppingPrijs} \n" +
                $"________________________________________________________\n" +
                $"Totaal pizza      {pizzaPrijs} \n" + "\n" +
                $"Afstand       {afstand} lichtjaren \n" +
                $"Transportkosten       {transportKosten} \n" +
                $"________________________________________________________\n" +
                $"TOTAAL        {totaalPrijs} \n" +
                $"********************************************************\n" +
                $"Informatie voor de piloot: \n" +
                $"Benzine tonnen in te laden: {tonnen} \n" +
                $"Benzine over in laatste ton: {laatsteTon * 100}%");
        }
    }
}
