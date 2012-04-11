using System;

namespace Kodecsharp.Example.Intro
{
    class ForDemo
    {
        public static void Main(string[] args)
        {
            //
            // create a for loop iterating from 0 and continue while
            // i is less that 10.
            //
            for (int i = 0; i < 10; i++)
            {
                //
                // a for loop for printing stars (asterisk) from 0 to
                // the length of i.
                //
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}