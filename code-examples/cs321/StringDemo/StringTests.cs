namespace StringDemo
{
    public class StringTests
    {
        
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
            for (var i = 0; i < 10; ++i)
            {
                var c = (char)('z' - i);
                Console.WriteLine($"The {i} last character is {c}");
            }
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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}