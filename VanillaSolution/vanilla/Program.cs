using System;
using System.Runtime.InteropServices;

namespace vanilla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
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
