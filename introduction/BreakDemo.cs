using System;

namespace Kodecsharp.Example.Intro
{
    class BreakDemo
    {
        [STAThread]
        public static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                if (i == 10)
                {
                    //
                    // break the for loop
                    //
                    break;
                }
                Console.WriteLine("i = " + i);
            }
            Console.ReadLine();
        }
    }
}