namespace OutputFilesRecursive
{
    public static class Program
    {
        public static void OutputFiles(string dir, string prefix, bool recursive)
        {
            Console.WriteLine("Files");
            foreach (var file in Directory.GetFiles(dir))
            {
                var date = File.GetCreationTime(file);
                var size = new FileInfo(file).Length;
                var name = Path.GetFileName(file);

                Console.WriteLine($"{prefix} {date} {name} {size}bytes");
            }

            Console.WriteLine("Directories");
            foreach (var subDir in Directory.GetDirectories(dir))
            {
                var date = File.GetCreationTime(subDir);
                var name = Path.GetFileName(subDir);

                Console.WriteLine($"{prefix} <DIR> {date} {name}");

                if (recursive)
                {
                    OutputFiles(subDir, prefix + "--", recursive);
                }
            }
        }
        
        static void Main(string[] args)
        {
            var dir = args[0];
            var recursive = args.Contains("/r");
            OutputFiles(dir, "", recursive);
        }
    }
}