namespace Lab2Find
{
    public static class Program
    {
        static void Main(string[] args)
        {
            if (args.Contains("/?"))
            {
                OutputHelp();
            }
            else if (args.Length == 0)
            {
                OutputHelp();
            }
            else if (args.Length == 1)
            {
                WriteStdInputContainingString(args[0]);
            }
            else if (args.Length >= 2)
            {
                WriteFileContentsContainingString(args[1], args[0]);
            }
        }

        public static void OutputHelp()
        {
            Console.WriteLine("The first argument is required and should be the string to find");
            Console.WriteLine("The second argument is the optional file path");
        }

        public static void WriteStdInputContainingString(string s)
        { 
            var current=Console.ReadLine();
            while (current != null)
            {
                if (current.Contains(s))
                    Console.WriteLine(current);
                current = Console.ReadLine();
            }
        }

        public static void WriteFileContentsContainingString(string filePath, string s)
        {
            foreach (var line in File.ReadLines(filePath))
            {
                if (line.Contains(s))
                    Console.WriteLine(line);
            }
        }
    }
}