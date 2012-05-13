using System;
using System.Collections;

namespace Kodecsharp.Example.System
{
    class EnvironmentVariablesDemo
    {
        static void Main()
        {
            //
            // Get the environment variables.
            //
            IDictionary envVars = Environment.GetEnvironmentVariables();

            //
            // Prints the available environment variables.
            //
            foreach (DictionaryEntry entry in envVars)
            {
                Console.WriteLine("{0} => {1}", entry.Key, entry.Value);
            }
        }
    }
}
