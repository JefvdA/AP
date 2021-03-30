using System;

namespace van_der_Avoirt_Jef_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container1 = new Container("Tim NV", "Graan", 30);
            Container container2 = new Container("Tim NV", "Water", 30);

            container1.VoegContainerToe(container2);

            for (int i = 0; i < 10; i++)
            {
                container1.Gewicht += 10;
                Console.WriteLine(Scanner.ScanContainer(container1));
            }
        }
    }
}
