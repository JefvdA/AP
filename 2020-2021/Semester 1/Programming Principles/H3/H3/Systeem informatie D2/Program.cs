using System;
using System.IO;

namespace Systeem_informatie_D2
{
    class Program
    {
        static void Main(string[] args)
        {
            long cdriveinbytes = DriveInfo.GetDrives()[0].AvailableFreeSpace;
            long totalsize = DriveInfo.GetDrives()[0].TotalSize;

            Console.WriteLine($"Free space on disk: {cdriveinbytes}");
            Console.WriteLine($"Total size of disk: {totalsize}");
        }
    }
}
