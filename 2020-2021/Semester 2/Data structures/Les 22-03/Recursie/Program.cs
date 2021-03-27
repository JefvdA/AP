using System;

namespace Recursie
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveTower(3, "A", "C", "B");
        }

        static void MoveTower(int diskNr, string starting, string target, string extra)
        {
            if(diskNr == 1)
                Console.WriteLine($"disk {diskNr} is getting moved from {starting} to {target}");
            else
            {
                // Move upper n-1 disks to extra tower
                MoveTower(diskNr - 1, starting, extra, target);

                Console.WriteLine($"disk {diskNr} is getting moved from {starting} to {target}");

                MoveTower(diskNr - 1, extra, target, starting);
            }
        }
    }
}
