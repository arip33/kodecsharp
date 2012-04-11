using System;

namespace Kodecsharp.Example.Intro
{
    class WhileDemo
    {
        [STAThread]
        public static void Main(string[] args)
        {
            int number = 0;

            int result = 0;

            //
            // Iterate the while loop untile number is greater 
            // than 10.
            //
            while (number <= 10)
            {
                result = result + number;
                number++;

                Console.WriteLine("Temporary result: " + result);
            }

            Console.WriteLine("The total addition of " +
                "number starting from 0 to 10 = " + result);
            Console.ReadLine();
        }
    }
}