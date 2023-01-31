using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosAndTests
{
    public static class TestFirstExample
    {
        public static int Factorial(int n)
        {
            throw new NotImplementedException();
        }

        [Test]
        public static void TestFactorial1()
        {
            var seq = new[] { 1, 1, 2, 6, 24, 120, 720 };
            for (var i = 0; i < seq.Length; i++)
            {
                Assert.AreEqual(seq[i], Factorial(i));
            }
        }

        [Test]
        public static void TestFactorial2()
        {
            for (var i = 0; i < 99; i++)
            {
                // This is effectively the definition of Factorial
                Assert.AreEqual(Factorial(i - 1) * i, Factorial(i));
            }
        }

        public static int Fibonacci(int n)
        {
            throw new NotImplementedException();
        }

        [Test]
        public static void TestFibonacci1()
        {
            var seq = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21 };
            for (var i = 0; i < seq.Length; i++)
            {
                Assert.AreEqual(seq[i], Fibonacci(i));
            }
        }

        [Test]
        public static void TestFibonacci2()
        {
            for (var i = 2; i < 99; i++)
            {
                Assert.AreEqual(Fibonacci(i - 2) + Fibonacci(i - 1), Fibonacci(i));
            }
        }
    }
}
