
using System.Diagnostics;

namespace SharedCode
{
    public static class Utils
    {
        public static DirectoryInfo GetCurrentWorkingDirectory()
        {
            return new DirectoryInfo(Directory.GetCurrentDirectory());
        }

        public static string GetExePath()
        {
            return Process.GetCurrentProcess().MainModule.FileName;
        }

        public static string GetExeName()
        {
            return Path.GetFileNameWithoutExtension(GetExePath());
        }

        public static bool HasOption(IEnumerable<string> args, string optionName)
        {
            return args.Any(s => s.StartsWith($"/{optionName}")) ||
                   args.Any(s => s.StartsWith($"-{optionName}"));
        }

        public static bool HasOption(IEnumerable<string> args, params string[] optionNames)
        {
            return optionNames.Any(option => HasOption(args, option));
        }

        public static string GetOptionValue(IEnumerable<string> args, string optionName, string defaultValue)
        {
            foreach (var arg in args)
            {
                if (arg.StartsWith($"/{optionName}="))
                {
                    return arg.Substring(optionName.Length + 2);
                }
            }

            return defaultValue;
        }

        public static void WriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static long FileSize(FileSystemInfo fileOrDir)
        {
            return fileOrDir is DirectoryInfo ? 0 : ((FileInfo)fileOrDir).Length;
        }

        public static IEnumerable<FileSystemInfo> FilterFilesBySize(IEnumerable<FileSystemInfo> files, long minSize, long maxSize)
        {
            return files.Where(f => FileSize(f) >= minSize && FileSize(f) <= maxSize);
        }

        public static TimeSpan FileAge(FileSystemInfo file)
        {
            return DateTime.Now - file.CreationTime;
        }
        
        public static IEnumerable<FileSystemInfo> FilterFilesOrDirsByAge(IEnumerable<FileSystemInfo> files, TimeSpan minAge, TimeSpan maxAge)
        {
            return files.Where(f => FileAge(f) >= minAge && FileAge(f) <= maxAge);
        }

        public static IEnumerable<FileInfo> GetFiles(DirectoryInfo dir, string searchPattern, bool recursive)
        {
            return GetFilesAndDirs(dir, searchPattern, recursive).OfType<FileInfo>();
        }

        public static IEnumerable<DirectoryInfo> GetDirs(DirectoryInfo dir, string searchPattern, bool recursive)
        {
            return GetFilesAndDirs(dir, searchPattern, recursive).OfType<DirectoryInfo>();
        }

        public static IEnumerable<FileSystemInfo> GetFilesAndDirs(DirectoryInfo dir, string searchPattern, bool recursive)
        {
            var searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            return dir.EnumerateFileSystemInfos(searchPattern, searchOption);
        }
    }
}