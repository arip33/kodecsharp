using System;

namespace Kodecsharp.Example.System
{
    class GetCommandLine
    {
        static void Main(string[] args)
        {
            //
            // Get command line information including the argument list
            //
            Console.WriteLine("Command line: {0}", Environment.CommandLine);
            
            //
            // Iterate the specified arguments
            //
            Console.WriteLine("Parameters  : ");
            foreach (string parameter in args)
            {
                Console.WriteLine("- {0} ", parameter);
            }
        }
    }
}
