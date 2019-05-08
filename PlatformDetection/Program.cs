using System;
using System.Runtime.InteropServices;

namespace PlatformDetection
{
    public class Program
    {
        static void Main(string[] args)
        {
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				Console.WriteLine("The OS is Windows!");
				Console.WriteLine($"\t{RuntimeInformation.OSDescription}");
			}
			else if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				Console.WriteLine("The OS is Linux!");
				Console.WriteLine($"\t{RuntimeInformation.OSDescription}");
			}
			else
			{
				Console.WriteLine("OS Unknown. . .");
			}


			Console.ReadLine();
        }
    }
}
