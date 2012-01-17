using System;

namespace Kodecsharp.Example.Intro
{
    class CommandLineParameter
    {
        /// <summary>
        /// Reading command line parameter.
        /// </summary>
        /// <param name="args">command line parameteres</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Argument size: " + args.Length);

            //
            // Print out the entire command line parameters passed 
            // into this program.
            //
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Argument[" + i + "] : " + args[i]);
            }
        }
    }
}
