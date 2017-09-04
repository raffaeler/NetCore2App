using System;
using System.Runtime.InteropServices;

// In order to publish the application you have two choices:
// Option 1: the target machine has the runtime installed
//    dotnet publish -c Release -r linux-arm --self-contained=false
// 
//    -c Release     ==> specify to publish the release version (not the debug)
//    -r linux-arm   ==> this tells the CLI to publish the required linux for ARM binaries
//    --self-contained=false  ==> false can only be used when the runtime is available on the target machine
//
//
// Option 2: the target machine may have the runtime or not
//    dotnet publish -c Release -r linux-arm --self-contained
//
//    --self-contained ==> the implicit true is used to publish the whole set of binaries including the CLR
//
// With Option 1, you will need to run the app with the command: "dotnet vanilla.dll"
// With Option 2, you will need to give the eXecutable permission: "chmod +x vanilla"
//                and then you can run the app by executing it:  "./vanilla"

namespace vanilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a very basic application to verify that dotnet is installed correctly");

            Console.WriteLine(
                $"Vanilla v1.0 by @raffaeler, 2017\r\n" +
                $"Machine:     {Environment.MachineName}\r\n" +
                $"OS         : { GetOS()}\r\n" +
                $"Description: { RuntimeInformation.OSDescription}"
                );

        }

        private static string GetOS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return "Windows";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return "Linux";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return "OSX";
            return "Unknown";
        }
    }
}
