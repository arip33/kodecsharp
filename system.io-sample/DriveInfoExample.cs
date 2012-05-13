using System;
using System.IO;

namespace Kodecsharp.Example.System.IO
{
    class DriveInfoExample
    {
        static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive name          : {0}", drive.Name);

                //
                // When drive is ready we can get the drive information details.
                //
                if (drive.IsReady)
                {                    
                    Console.WriteLine("Volume label        : {0}", drive.VolumeLabel);
                    Console.WriteLine("Type                : {0}", drive.DriveType);
                    Console.WriteLine("Format              : {0}", drive.DriveFormat);

                    double totalSize = drive.TotalSize;
                    double freeSpace = drive.TotalFreeSpace;
                    double availableFreeSpace = drive.AvailableFreeSpace;
                    Console.WriteLine("Total size          : {0}", totalSize);
                    Console.WriteLine("Free space          : {0}", freeSpace);
                    Console.WriteLine("Available free space: {0}", availableFreeSpace);
                }

                Console.WriteLine("Is ready            : {0}\n", drive.IsReady);
            }
        }
    }
}
