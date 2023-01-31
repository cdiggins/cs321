using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Assignment2
{
    public class Tests
    {
        /*
         * Notes:
         * - 
         */

        public static string TestHieroglyph = "𓀀";

        public static void RandomizeList<T>(IList<T> list) where T: IComparable<T>
        {
        }

        public static bool IsSorted<T>(IReadOnlyList<T> xs) 
            where T : IComparable<T> 
        {
            if (xs.Count <= 1)
                return true;
            for (var i=0; i<xs.Count-1; i++)
            {
                if (xs[i].CompareTo(xs[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        [Test]
        public static void TestIsSorted()
        {
            Assert.IsTrue(IsSorted(new[] { 1, 2, 3 }));
            Assert.IsTrue(IsSorted(new[] { "a", "bbb", "cc" }));
            Assert.IsTrue(IsSorted(new int[] { }));
            Assert.IsTrue(IsSorted(new[] { 42 }));
            Assert.IsFalse(IsSorted(new[] { 1, 3, 2 }));
            Assert.IsFalse(IsSorted(new[] { "b", "c", "ab" }));
        }

        public static bool IsPalindrome(string s)
        {
            throw new NotImplementedException();
        }

        [Test]
        public static void TestIsPalindrome()
        {
            Assert.IsTrue(IsPalindrome("tacocat"));
            Assert.IsFalse(IsPalindrome("cat"));
            Assert.IsTrue(IsPalindrome("ABBA"));
            Assert.IsTrue(IsPalindrome("a"));
            Assert.IsTrue(IsPalindrome(""));
        }

        public static bool IsReversed(string a, string b)
        {
            throw new NotImplementedException();
        }

        [Test]
        public static void TestIsReversed()
        {
            Assert.IsTrue(IsReversed("abc", "cba"));
            Assert.IsFalse(IsReversed("abc", "abc"));
            Assert.IsFalse(IsReversed("abc", " cba "));
            Assert.IsTrue(IsReversed("tacocat", "tacocat"));
        }

        public static string Reverse(string s)
        { 
            // TODO: reverse the string by reversing bytes? 
            throw new NotImplementedException(); 
        }

        public static int Factorial(int n)
        {
            throw new NotImplementedException();
        }

        public static void TestFactorial()
        {
            var seq = new[] { 1, 1, 2, 6, 24, 120, 720 };
            for (var i = 0; i < seq.Length; i++)
            {
                Assert.AreEqual(seq[i], Factorial(i));

                if (i > 1)
                {
                    // This is effectively the definition of Factorial
                    Assert.AreEqual(Factorial(i - 1) * i, Factorial(i));
                }
            }
        }

        public static int Fibonacci(int n)
        {
            throw new NotImplementedException();
        }

        public static void TestFibonacci()
        {
            var seq = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 };
            for (var i=0; i < seq.Length; i++)
            {
                Assert.AreEqual(seq[i], Fibonacci(i));

                if (i >= 2)
                {
                    // This is effectively the definition of fibonacci
                    Assert.AreEqual(Fibonacci(i - 2) + Fibonacci(i - 1), Fibonacci(i));
                }
            }
        }

        [Test]
        public static void TestReverse()
        {
            Assert.AreEqual("cba", Reverse("abc"));
            Assert.AreEqual("tacocat", Reverse("tacocat"));
        }

        public static bool IsPrime(int n)
        {
            throw new NotImplementedException();
        }

        public static void TestPrime()
        {
            // Set-up a list of known prime numbers up to 99
            // Using an old algorithm: 
            // https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes

            var sieve = Enumerable.Repeat(true, 99).ToList();
            for (var step = 2; step < sieve.Count / 2; ++step)
            {
                for (var i = step; i < sieve.Count; i += step)
                {
                    sieve[i] = false;
                }
            }

            for (var i=0; i < sieve.Count; i++)
            {
                Assert.AreEqual(sieve[i], IsPrime(i));
            }
        }

        public static void BubbleSortInPlace<T>(List<T> list) where T: IComparable<T>
        {
            for (var end = list.Count - 1; end > 0; end--)
            {
                for (var i = 0; i < end - 1; i++)
                {
                    if (list[i].CompareTo(list[i + 1]) > 0)
                    {
                        // Swap the items
                        (list[i], list[i+1]) = (list[i+1], list[i]);
                    }

                    // The item on the left should now be less than or equal to the item on the right 
                    Debug.Assert(list[i].CompareTo(list[i + 1]) <= 0);
                }
            }
            Debug.Assert(IsSorted(list));
        }

        public static IReadOnlyList<string> Substrings(string s)
        {
            throw new NotImplementedException();
        }

        [Test]
        public static void TestSubstrings()
        {
            Assert.AreEqual(new[] { "c" }, Substrings("c"));
            Assert.AreEqual(new[] { "c", "a", "t", "ca", "at", "cat" }, Substrings("cat"));
        }


        public static class StringOperations
        {
            public static IReadOnlyList<byte> ToAscii<T>(string s)
                => throw new NotImplementedException();

            public static IReadOnlyList<char> Rot13(string s)
                => throw new NotImplementedException();

            public static char Rot13(char c)
                => throw new NotImplementedException();

            public static IReadOnlyList<string> Words(string s)
                => throw new NotImplementedException();
        }
    }
}