using System;
using System.Runtime.InteropServices;

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
