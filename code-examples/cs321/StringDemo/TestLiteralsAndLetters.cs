using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosAndTests
{
    public static class TestLiteralsAndLetters
    {
        [Test]
        public static void TestLiterals()
        {
            var xs = new object[] { "Hello", 123, 12.34, 1.23f, true, 't', 0xFFul };
            foreach (var x in xs)
            {
                OutputValueAndType(x);
            }
        }

        public static void OutputValueAndType(object value)
        {
            Console.WriteLine($"The value {value} has type {value.GetType()}");
        }

        [Test]
        public static void TestLetters()
        {
            for (var i = 0; i < 128; i++)
            {
                var c = (char)i;
                if (char.IsLetter(c))
                {
                    Console.WriteLine($"{i} = {c}");
                }
            }
        }

        [Test]
        public static void TestLettersUsingLinq()
        {
            foreach (var c in Enumerable.Range(0, 128).Cast<char>().Where(char.IsLetter))
                Console.WriteLine($"{(int)c} = {c}");
        }
    }
}
