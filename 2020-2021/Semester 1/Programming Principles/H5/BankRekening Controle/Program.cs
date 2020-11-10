using System;

namespace BankRekening_Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de eerste 3 cijfers van de bankrekeningnummer     >>");
            string get1 = Console.ReadLine();
            Console.Write("Geef de volgende 7 cijfers van de bankrekeningnummer     >>");
            string get2 = Console.ReadLine();
            Console.Write("Geef de laatste 2 cijfers van de bankrekeningnummer     >>");
            int get3 = int.Parse(Console.ReadLine());

            if(int.Parse(get1 + get2) % 97 == get3)
            {
                Console.WriteLine("Dit is een geldig bankrekeningnummer!");
            }
            else
            {
                Console.WriteLine("Dit is GEEN geldig bankrekeningnummer!");
            }
        }
    }
}
