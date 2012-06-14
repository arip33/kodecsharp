using System;

namespace Kodecsharp.Example.Intro
{
    class ReadUserInput
    {
        static void Main()
        {
            Console.WriteLine("Hello there!");
            Console.Write("What is your name? : ");
            string name = Console.ReadLine();

            Console.Write("How old are you?   : ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello {0}, you are {1} year(s) old.", name, age);
        }
    }
}
