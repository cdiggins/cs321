using System.Diagnostics;
using DirectoryProgram;

namespace DirTests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(RunBuiltInDir(dir));
            Program.Main(new[] { dir, "/b" });
        }

        public static string? RunBuiltInDir(string dir)
        {
            var psi = new ProcessStartInfo("cmd.exe", "/C dir /b")
            {
                WorkingDirectory = dir,
                RedirectStandardOutput = true,
                WindowStyle = ProcessWindowStyle.Hidden,
            };
            using var p = Process.Start(psi);
            return p?.StandardOutput.ReadToEnd();
        }
    }
}