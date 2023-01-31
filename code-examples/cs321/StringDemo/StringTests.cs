using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace StringDemo
{
    public class StringTests
    {
        public static string Reverse(string s)
        {
            var r = "";
            for (var i=s.Length-1; i >= 0; --i)
            {
                r += s[i];
            }
            return r;
        }

        public static bool IsStringReversed(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (var i = 0; i < a.Length; ++i)
            {
                var charA = a[i];
                var charB = b[b.Length - 1 - i];   
                if (charA != charB)
                    return false;
            }
            return true;
        }

        [Test]
        public static void TestReversals()
        {
            {
                var input = "abc";
                var output = Reverse(input);
                Assert.AreEqual("cba", output);
                Assert.IsTrue(IsStringReversed(input, output));
                Assert.IsTrue(IsStringReversed(output, input));
                Assert.AreEqual(input, Reverse(Reverse(input)));
            }
        }

        [Test]
        public void BasicStringExample()
        {
            var s1 = "Hello";
            string s2 = "Hello";
            String s3 = "Hello";
            var s4 = $"{s1}";
            var s5 = "He" + "llo";
            CompareEquality(s1, s2);
            CompareEquality(s1, s3);
            CompareEquality(s1, s4);
            CompareEquality(s1, s5);
        }

        [Test]
        public static void ComparableInterfaceExample()
        {
            var c1 = 'b';
            var c2 = 'd';
            var iface = (IComparable<char>)c1;
            var result = iface.CompareTo(c2);
            Console.WriteLine($"Compared {c1} to {c2} and the result was {result}");
        }

        public static void CharParse()
        {

        }

        public static void TestString(string s)
        {
            if (s == null)
            {
                Console.WriteLine("The string is null");                           
            }
            else 
            {
                Console.WriteLine($"The string {s} has length {s.Length}");
            }
        }

        [Test]
        public static void SimpleTestStrings()
        {
            var s1 = (string)null;
            var s2 = "";
            var s3 = " ";
            var s4 = " hello ";
            var s5 = s4.Trim();
            TestString(s1);
            TestString(s2);
            TestString(s3);
            TestString(s4);
            TestString(s5);
        }

        public static void TestNullString()
        {
            string s;
            //Console.WriteLine(s);
        }

        [Test]
        public static void StringFailOnPurpose()
        {
            var s = (string)null;
            Console.WriteLine($"The string {s} has length {s.Length}");
        }

        [Test]
        public static void FormatDemo()
        {
            var code = 0x263A;
            var ch = (char)code;
            var format1 = string.Format("The code in decimal is {0,10:G}", code);
            var format2 = string.Format("The code in hexdecimal is {0,10:X}", code);
            var format3 = string.Format("The character is {0}", ch);
            Console.WriteLine(format1);
            Console.WriteLine(format2);
            Console.WriteLine(format3);
            Console.WriteLine("But I could have also just written \u263A");
        }

        [Test]
        public static void CharMath()
        {
            var n = 98;
            var c = (char)n;
            Console.WriteLine($"This number {n} corresponds to the letter {c}");
        }

        public static void CharProperties()
        {

        }

        public static void PrintableCharacters()
        {
            for (var i = 0; i < 128; ++i)
            {
                var c = (char)i;
                if (char.IsControl(c))
                {
                    Console.WriteLine($"Character {i} is a control character {c}");
                }
                else
                {
                    Console.WriteLine($"Character {i} is {c}");
                }
            }
        }

        [Test]
        public static void LastTenChars()
        {
            // The 0 last character is 'z'
            for (var i = 0; i < 10; ++i)
            {
                var c = (char)('z' - i);
                Console.WriteLine($"The {i} last character is {c}");
            }

        }

        [Test]
        public static void TestCharInString()
        {
            var s = "Hello world";
            Console.WriteLine(s[4]);
        }

        public static void CompareEquality(object a, object b)
        {
            var eq = a.Equals(b);
            Console.WriteLine($"a is {a.GetType()} and b is {b.GetType()}");
            Console.WriteLine($"It is {eq} that {a} and {b} are equal");
        }

        public static void CompareRefEquality(object a, object b)
        {
            var refEq = object.ReferenceEquals(a, b);
            Console.WriteLine($"a is {a.GetType()} and b is {b.GetType()}");
            Console.WriteLine($"It is {refEq} that {a} and {b} are the same ");
        }

        [Test]
        public static void TestChar()
        {
            var c1 = 'a';
            var c2 = 'b';
            var c3 = (int)c1;
            var c4 = (char)c3;
            var c5 = c2 - 1;
            var c6 = (char)c5;
            CompareEquality(c1, c1);
            CompareEquality(c1, c2);
            CompareEquality(c1, c3);
            CompareEquality(c1, c4);
            CompareEquality(c1, c5);
            CompareEquality(c1, c6);
        }

        public static void TestCharWord()
        {
            // Note: illegal, won't compile
            // var x = Char;
            var c = new char();
            
        }

        [Test]
        public static void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public static void Test2()
        {
            var x = (object)"Hello"; 
            var s = (string)"World"; 
            //Console.WriteLine($"{x.Length}"); 
            Console.WriteLine($"{s.Length}");
        }


        [Test]
        public static void Test4()
        {
            object x = "Hello";
            string s = "World";
            Console.WriteLine($"{x.GetType()}");
            Console.WriteLine($"{s.GetType()}");
        }

        [Test]
        public static void Test3()
        {
            object x = "Hello";
            string s = "World";
            //Console.WriteLine($"{x.Length}");
            Console.WriteLine($"{s.Length}");
        }

        [Test]
        public static void TestChars1()
        {
            var s = "Hello world"; 
            foreach (var c in s) 
            {
                Console.WriteLine($"Char {c} has code {(int)c}");
            }
        }

        [Test]
        public static void TestStringLiterals()
        {
            var s1 = "c:\\temp\\test.txt";
            var s2 = @"c:\temp\test.txt";
            var s3 = "There is a line break\n here";
            var s4 = @"There is a line break
here";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
        }

        [Test]
        public static void TestStringSplit()
        {
            var s = "I like apple, bananas, and grapes.";
            var xs = s.Split(new char[] { ' ', ',', '.' });
            foreach (var x in xs)
                Console.WriteLine(x);
        }

        [Test]
        public static void TestStringSplit2()
        {
            var s = "I like apple, bananas, and grapes.";
            var xs = s.Split(' ', ',', '.' );
            foreach (var x in xs)
                Console.WriteLine(x);
        }

        [Test]
        public static void TestIndexOf()
        {
            var s = "Bananas are good";
            var sub = "nana";
            var n = s.IndexOf(sub);
            Console.WriteLine($"Indeof {sub} is {n}");
        }

        [Test]
        public static void TestSubstring()
        {
            var s = "Bananas are good";
            var n = s.IndexOf("good");
            var sub = s.Substring(n, 3);
            Console.WriteLine(sub); // "goo
        }

        [Test]
        public static void TestStringCtorsAndOps()
        {
            var s1 = new string(new[] { 'h', 'e' });
            var s2 = new string('l', 2);
            var s3 = "o";
            var r = s1 + s2;
            r += s3;
            Console.WriteLine(r);
        }

        [Test]
        public static void StringJoinDemo()
        {
            var input = new object[] { "Hello", "to", "all", "my", 28, "students" };
            var joined = string.Join(" ", input);
            Console.WriteLine(joined); // Hello to all my 28 students
        }

        [Test]
        public static void TestCharsEnumerator()
        {
            var s = "Hello world";
            for (var e=s.GetEnumerator(); e.MoveNext(); )
            {
                var c = e.Current;
                Console.WriteLine($"Char {c} has code {(int)c}");
            }
        }

        [Test]
        public static void TestCharsForLoop()
        {
            var s = "Hello world";
            var index = s.Length - 1;
            var ch = s[index];
            Console.WriteLine($"The character at pos {index} is {ch}");
        }

        [Test]
        public static void TestFormat()
        {
            var s = $"Pi with 3 digits is {Math.PI,10:F3}";
            Console.WriteLine(s);
        }

        [Test]
        public static void Test5()
        {
            var o = (object)"hello"; 
            var s = (string)o; 
            var n = (int)o;
            Console.WriteLine(o);
            Console.WriteLine(s);
            Console.WriteLine(n);
        }

        [Test]
        public static void TestDir()
        {
            var asmLocation = Assembly.GetExecutingAssembly().Location;
            var testDir = Path.GetDirectoryName(asmLocation);

            Console.WriteLine("Files");            
            foreach (var f in Directory.GetFiles(testDir))
            {
                var name = f; // Path.GetFileName(f);
                Console.WriteLine(name);
            }

            Console.WriteLine("Directories");
            foreach (var d in Directory.GetDirectories(testDir))
            {
                var name = Path.GetFileName(d);
                Console.WriteLine(name);
            }
        }
    }
}