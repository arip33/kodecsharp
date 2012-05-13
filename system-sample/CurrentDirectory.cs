using System;

namespace Kodecsharp.Example.System
{
    class CurrentDirectory
    {
        public static void Main(string[] args)
        {
            //
            // Get the fully qualified path of the current working 
            // directory
            //
            string currentDir = Environment.CurrentDirectory;
            Console.WriteLine("Current Directory: {0}", currentDir);
        }
    }
}