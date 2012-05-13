using System;

namespace Kodecsharp.Example.System
{
    class GetTemporaryDirectory
    {
        static void Main()
        {
            //
            // Get temporary directory location.
            //
            string tempDir = Environment.GetEnvironmentVariable("TEMP");
            Console.WriteLine("Temporary directory : {0}", tempDir);

            //
            // When the environment variable doesn't exist you will get
            // a null value.
            //
            string none = Environment.GetEnvironmentVariable("__NONE__");
            Console.WriteLine("Environment variable: {0}", 
                none == null ? "null" : none);
        }
    }
}
