using System;
using System.Collections;

namespace ConsoleClient
{
    public class Oefening3
    {
        /// <summary>
        /// Startpunt van oef3: Gebruik van een stack
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Welkom bij oefening 3. Geef telkens een woord of een getal");

            //Vul deze code aan...
            Stack stack = new Stack();
            int getal = 0;
            while (true)
            {
                var text = Console.ReadLine();
                if (int.TryParse(text, out getal))
                {
                    //Gebruiker geeft een getal in
                    if(getal > stack.Count)
                        Console.WriteLine($">Sorry, de stack bevat nog maar {stack.Count} woord(en).");
                    else
                    {
                        string message = ">";
                        for (int i = 0; i < getal; i++)
                        {
                            message += stack.Pop() + " ";
                        }
                        Console.WriteLine(message);
                    }
                }
                else
                {
                    //Gebruiker geeft een woord in
                    stack.Push(text);
                }
            }
        }
    }
}
