using System;

namespace Kodecsharp.Example.Intro
{
    class IfElseDemo
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 25;

            //
            // A simple if-else block
            //
            if (a <= b)
            {
                Console.WriteLine("a is less than or equals to b");
            }
            else
            {
                Console.WriteLine("b is greater than a");
            }

            //
            // An if-else if-else block
            //
            if (a * 4 < b)
            {
                Console.WriteLine("a * 4 is less than b");
            }
            else if (a * 5 - 8 < b)
            {
                Console.WriteLine("a * 5 - 8 is less that b");
            }
            else
            {
                Console.WriteLine("a = " + a + "; b = " + b);
            }

            Console.ReadLine();
        }
    }
}