using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SizeOfFileOrFolder
{
    class Program
    {
        static ulong totalBytes = 0;
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            Console.Write("Enter the path: ");
            time.Start();
            string path = "";
            if (args.Length > 0)
            {
                path = args[0];
            }
            else
            {
                path = Console.ReadLine();
            }
            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }
            time.Stop();
            Console.WriteLine();
            Console.WriteLine($"Total size of \"{path}\" is {totalBytes} bytes ({totalBytes / 1024f} KB, {totalBytes / (1024f * 1024f)} MB, {totalBytes / (1024f * 1024f * 1024f)} GB)");
            Console.WriteLine($"Time to parse everything is {time.ElapsedMilliseconds} millisecnds ({time.ElapsedMilliseconds / 1000} seconds)");
            Console.ReadLine();
        }

        public static void ProcessDirectory(string targetDirectory)
        {
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                ProcessFile(fileName);

            string[] subDirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subDirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public static void ProcessFile(string path)
        {
            totalBytes += (ulong)File.ReadAllBytes(path).Length;
            Console.WriteLine($"Processed file \"{path}\"");
        }
    }
}
