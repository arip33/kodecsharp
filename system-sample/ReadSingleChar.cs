using System;

namespace Kodecsharp.Example.System
{
    class ReadSingleChar
    {
        static void Main()
        {
            Console.WriteLine("Menus");
            Console.WriteLine("==================");
            Console.WriteLine("1. Friend Chicken");
            Console.WriteLine("2. Burger");
            Console.WriteLine("3. Sandwich");
            Console.WriteLine("4. Hot Dog");
            Console.WriteLine("==================");
            Console.Write("Enter your selection: ");

            int readValue = Console.Read();
            char character = (char) readValue;

            //
            // Check if user enter value 1 to 4. Other input will execute the
            // else block.
            //
            if (readValue >= 49 && readValue <= 52)
            {
                Console.WriteLine("You've choosen menu number: {0}", character);
                Console.WriteLine("Read value                : {0}", readValue);
                Console.WriteLine("Character value           : {0}", character);
            }
            else
            {
                Console.WriteLine("We don't have anything for you");
                Console.WriteLine("You've entered: {0}, {1}", readValue, character);
            }

        }
    }
}
