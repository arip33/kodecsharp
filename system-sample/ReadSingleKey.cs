using System;

namespace Kodecsharp.Example.System
{
    class ReadSingleKey
    {
        static void Main()
        {            
            ConsoleKeyInfo info;

            //
            // Read user input until user presses 'N'
            //
            do
            {
                Console.Write("Do you want to continue the process? (Y/N): ");
                info = Console.ReadKey();
                if (info.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Continue...");
                }
            } while (info.Key != ConsoleKey.N);
            Console.WriteLine("");
            Console.WriteLine("Exit...");
        }
    }
}
