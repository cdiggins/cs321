using System.Runtime.InteropServices;

namespace HelloCommandLineArgs
{
    public static class Program
    {
        public static void OutputDirectory(string directory)
        {
            Console.WriteLine($"I'm going to output the contents of {directory}");
        }

        public static void Main(string[] args)
        {
            var i = 0;
            foreach (var arg in args)
            {
                Console.WriteLine($"The {i}th argument is {args[i++]}");
            }
        }

        public static void ReadLineDemo()
        {
            var dirName = "c:\\myfolder";
            OutputDirectory(dirName);

            for (var s=Console.ReadLine(); s != null; s = Console.ReadLine())
            {
                Console.WriteLine($"You wrote: {s}");
            }
            Console.WriteLine("You finished by pressing Ctrl+Z");
        }
    }
}