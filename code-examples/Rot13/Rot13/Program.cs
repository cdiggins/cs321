using System.ComponentModel.DataAnnotations;

namespace Rot13
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            while (line != null)
            {
                Console.WriteLine(Rot13(line));
                line = Console.ReadLine();
            }
        }

        public static string Rot13_LongWay(string input)
        {
            var list = new List<char>();
            foreach (var c in input)
                list.Add(Rot13(c));
            var chars = list.ToArray();
            return new string(chars);
        }

        public static string Rot13_ShortWay(string input)
            => new(input.ToCharArray().Select(Rot13).ToArray());

        public static string Rot13(string input)
        {
            return new string(input.ToCharArray().Select(Rot13).ToArray());
        }

        /// <summary>
        /// Given a character in the range A-Z or a-z, returns the character offset by 13 places,
        /// otherwise returns the character unchanged.
        /// </summary>
        public static char Rot13(char c)
        {
            // If not a letter, return the character
            if (!char.IsLetter(c))
            {
                return c;
            }

            // Convert the character into a code
            var code = (int)c;

            // Compute the new character code
            var newCode = code + 13;

            // If it was an upper-case letter, check if the new code is beyond 'Z'
            if (char.IsUpper(c) && newCode > 'Z')
            {
                // Loop back to the beginning of the alphabet
                newCode -= 26;
            }

            // If it was a lower-case letter, check if the new code is beyond lower-case 'z'
            if (char.IsLower(c) && newCode > 'z')
            {
                // Loop back to the beginning of the alphabet
                newCode -= 26;
            }

            return (char)newCode;
        }
    }
}