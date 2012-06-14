using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kodecsharp.Example.Intro
{
    class ReadKeyModifier
    {
        static void Main()
        {
            ConsoleKeyInfo info;

            do
            {
                Console.WriteLine("Enter any key. Press X to exit");
                info = Console.ReadKey();

                //
                // Check for modifier keys pressed by user.
                //
                if (info.Modifiers == ConsoleModifiers.Control)
                {
                    Console.WriteLine("You've pressed Control key");
                }

                if (info.Modifiers == ConsoleModifiers.Alt)
                {
                    Console.WriteLine("You've pressed Alt key");
                }

                if (info.Modifiers == ConsoleModifiers.Shift)
                {
                    Console.WriteLine("You've pressed Shift key");
                }

                if (info.Modifiers == ConsoleModifiers.Control 
                    && info.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("You've pressed Control-Q key");
                }
            } while (info.Key != ConsoleKey.X);
        }
    }
}
