using SharedCode;

namespace DirectoryProgram
{
    public class Options
    {
        // Could be "name", "size", "date", "ext"
        public string SortType = "name"; 
        public bool IgnoreFiles = false;
        public bool IgnoreDirs = false;
        public long MinSize = 0;
        public long MaxSize = long.MaxValue;
        public bool OrderDescending = false;
        public bool Recursive = false;
        public TimeSpan MaxAge = TimeSpan.MaxValue;
        public TimeSpan MinAge = TimeSpan.MinValue;
        public bool LowerCase = false;
        public bool ShortName = true;
        public bool UseColors = true;
        public bool ShowDate = true;
        public bool ShowSize = true;
        public string Mask = "*";
        public bool UseKb = false;
        public string DirLengthString = "<DIR>";
    }

    public class Colors
    {
        public static ConsoleColor Dir = ConsoleColor.DarkCyan;
        public static ConsoleColor File = ConsoleColor.Green;
        public static ConsoleColor Size = ConsoleColor.DarkYellow;
        public static ConsoleColor Date = ConsoleColor.DarkMagenta;
        public static ConsoleColor Error = ConsoleColor.Red;
        public static ConsoleColor Help = ConsoleColor.Cyan;
    }

    public static class Program
    {
        public static void Main(string[] args)
        {
            if (Utils.HasOption(args, "help", "?" ))
            {
                ShowHelp();
                return;
            }

            var options = ParseCommandLine(args);

            // Get the current directory 
            var dir = Utils.GetCurrentWorkingDirectory();

            // Get the directory from the first option if it doesn't start with a "-" or "/"
            if (args.Length > 0)
            {
                var arg = args[0];
                if (!arg.StartsWith("-") && !arg.StartsWith("/"))
                    dir = new DirectoryInfo(arg);
            }

            if (!dir.Exists)
            {
                Utils.WriteLine($"Directory {dir.FullName} does not exist", Colors.Error);
                return;
            }

            // Retrieve the files and directories 
            var filesAndDirs = Utils.GetFilesAndDirs(dir, options.Mask, options.Recursive);

            // Remove files if request
            if (options.IgnoreFiles)
            {
                filesAndDirs = filesAndDirs.Where(f => f is DirectoryInfo);
            }

            // Remove directories if request
            if (options.IgnoreDirs)
            {
                filesAndDirs = filesAndDirs.Where(f => f is FileInfo);
            }

            // Filter the files by size
            filesAndDirs = Utils.FilterFilesBySize(filesAndDirs, options.MinSize, options.MaxSize);
            
            // Filter files and directories by size
            filesAndDirs = Utils.FilterFilesOrDirsByAge(filesAndDirs, options.MinAge, options.MaxAge);

            // Reorder the files
            filesAndDirs = SortFiles(filesAndDirs, options.SortType);

            // Revere the order if requested
            if (options.OrderDescending)
            {
                filesAndDirs = filesAndDirs.Reverse();
            }
            
            // Output the entries
            foreach (var f in filesAndDirs)
            {
                OutputEntry(f, options);
            }
        }

        public static Options ParseCommandLine(string[] args)
        {
            var r = new Options();
            r.SortType = Utils.GetOptionValue(args, "sort", r.SortType);
            r.IgnoreFiles = Utils.HasOption(args, "nofiles");
            r.IgnoreDirs = Utils.HasOption(args, "nodirs");
            r.UseColors = !Utils.HasOption(args, "nocolors");
            r.OrderDescending = Utils.HasOption(args, "desc");
            r.Recursive = Utils.HasOption(args, "r");
            r.LowerCase = Utils.HasOption(args, "lower");
            r.ShortName = Utils.HasOption(args, "short");
            r.ShowDate = !Utils.HasOption(args, "nodate");
            r.ShowSize = !Utils.HasOption(args, "nosize");
            r.Mask = Utils.GetOptionValue(args, "mask", r.Mask);
            r.UseKb = Utils.HasOption(args, "kb");
            return r;
        }

        public static void ShowHelp()
        {
            Utils.WriteLine($"{Utils.GetExeName()}Outputs directory contents", Colors.Help);
        }

        public static ConsoleColor GetNameColor(FileSystemInfo fileOrDir, Options options)
        {
            if (!options.UseColors) return Console.ForegroundColor;
            return fileOrDir is DirectoryInfo ? Colors.Dir : Colors.File;
        }

        public static ConsoleColor GetSizeColor(FileSystemInfo fileOrDir, Options options)
        {
            if (!options.UseColors) return Console.ForegroundColor;
            return fileOrDir is DirectoryInfo ? Colors.Dir : Colors.Size;
        }

        public static ConsoleColor GetDateColor(Options options)
        {
            return !options.UseColors ? Console.ForegroundColor : Colors.Date;
        }

        public static IEnumerable<FileSystemInfo> SortFiles(IEnumerable<FileSystemInfo> files, string sortType)
        {
            switch (sortType)
            {
                case "name":
                    return files.OrderBy(f => f.Name);
                case "size":
                    return files.OrderBy(f => Utils.FileSize(f));
                case "date":
                    return files.OrderBy(f => f.CreationTime);
                case "ext":
                    return files.OrderBy(f => f.Extension);
                default:
                    return files;
            }
        }

        public static string FileLengthString(FileSystemInfo fileOrDir, Options options)
        {
            if (fileOrDir is DirectoryInfo)
            {
                return $"{options.DirLengthString,12}";
            }

            var length = ((FileInfo)fileOrDir).Length;
            if (options.UseKb)
            {
                length /= 1024;
            }
            
            return $"{length,12}";
        }

        public static void OutputEntry(FileSystemInfo fileOrDir, Options options)
        {
            if (options.ShowDate)
            {
                Utils.Write($"{fileOrDir.CreationTime:yyyy-MM-dd HH:mm:ss}", GetDateColor(options));
            }

            if (options.ShowSize)
            {
                Utils.Write(FileLengthString(fileOrDir, options), GetSizeColor(fileOrDir, options));
            }

            var name = options.ShortName 
                ? fileOrDir.Name 
                : fileOrDir.FullName;

            if (options.LowerCase)
            {
                name = name.ToLower();
            }

            Console.Write(" ");
            Utils.Write(name, GetNameColor(fileOrDir, options));
            Console.WriteLine();
        }
    }
}