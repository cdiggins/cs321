using System.Text;

namespace SharedCode
{
    public class Class1
    {
        public static IReadOnlyList<string> GetAllStrings(string fileName)
        {
            return File.ReadAllLines(fileName);
        }

        public static IReadOnlyList<string> InternalReadAllLines(string fileName, Encoding encoding)
        {
            return File.ReadLines(fileName, encoding).ToList();
        }

    }
}