using System;

namespace Kodecsharp.Example.System
{
    class LogicalDriveDemo
    {
        static void Main()
        {
            //
            // Get the list of available logical drives
            //
            string[] drives = Environment.GetLogicalDrives();
            Console.WriteLine("Logical drives: {0}", 
                String.Join(", ", drives));
        }
    }
}
