using System;

namespace Kodecsharp.Example.Intro
{
    class ForeachDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Argument size: " + args.Length);

            foreach (string arg in args)
            {
                Console.WriteLine("Argument: " + arg);
            }
        }
    }
}
