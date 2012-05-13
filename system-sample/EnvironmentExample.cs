using System;

namespace Kodecsharp.Example.System
{
    class EnvironmentExample
    {
        public static void Main(string[] args)
        {
            //
            // Gets the NetBIOS name of this local computer.
            //
            Console.WriteLine("Machine Name     : {0}", Environment.MachineName);

            //
            // Gets the number of processors the current machine has.
            //
            Console.WriteLine("Processor Count  : {0}", Environment.ProcessorCount);

            //
            // Gets the operating system information that contains the
            // current platform identifier and the version number.
            //
            Console.WriteLine("OS Version       : {0}", Environment.OSVersion);

            //
            // Gets the fully qualified path to the system directory
            //
            Console.WriteLine("System Directory : {0}", Environment.SystemDirectory);

            //
            // Gets the network domain name associated with the current 
            // user.
            //
            Console.WriteLine("User Domain Name : {0}", Environment.UserDomainName);

            //
            // Gets user name of the current user login to the Windows
            // operating system.
            //
            Console.WriteLine("User Name        : {0}", Environment.UserName);
        }
    }
}