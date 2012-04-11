using System;

namespace Kodecsharp.Example.Intro
{
    class DoWhileDemo
    {
        public static void Main(string[] args)
        {
            int i = 0; // initialize an int variable

            //
            // iterate the loop while the value of i is still less 
            // than 10.
            //
            do
            {
                Console.WriteLine("*");
                i++; // increment the value of i
            } while (i < 10);

            Console.ReadLine();
        }
    }
}