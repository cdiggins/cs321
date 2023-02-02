using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using static Assignment2.ListOperationsReference;
using static Assignment2.ListOperations;

namespace Assignment2
{
    public static class ListTests
    {
        // This class contains tests for the ListOperations class written using the NUnit framework

        public static int[] EmptyIntArray = new int[0];
        public static string[] EmptyStringArray = new string[0];
        public static char[] EmptyCharArray = new char[0];

        public static int[] SingleIntArray = new int[] { 42 };
        public static string[] SingleStringArray = new string[] { "hello" };
        public static int[] SingleCharArray = new int[] { 'c' };

        public static int[] IntArray = new int[] { 3, 2, 1, 5, 4 };
        public static string[] StringArray = new string[] { "bananas", "cantaloupes", "apples" };
        public static char[] CharArray = "hello world!".ToCharArray();

        public static int[] SortedIntArray = new int[] { 1, 2, 3, 4, 5 };
        public static string[] SortedStringArray = new string[] { "apples", "bananas", "cantaloupes" };
        public static char[] SortedCharArray = "abcd".ToCharArray();

        [Test]
        public static void TestIsSorted()
        {
            Assert.IsTrue(IsSorted(SortedIntArray));
            Assert.IsFalse(IsSorted(IntArray));
        }

        [Test]
        public static void TestIsSortedRange()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public static void TestCount()
        { 
            Assert.AreEqual(0, Count(EmptyIntArray, 42));
        }

        [Test]
        public static void TestCount2()
        {
            Assert.AreEqual(1, Count(SingleIntArray, 42));
        }
        
        [Test]
        public static void TestListEquals()
        {
            Assert.IsTrue(ListEquals(EmptyIntArray, EmptyIntArray));
            Assert.IsTrue(ListEquals(SingleIntArray, SingleIntArray));
            Assert.IsTrue(ListEquals(IntArray, IntArray));
            Assert.IsFalse(ListEquals(EmptyIntArray, SingleIntArray));
            Assert.IsFalse(ListEquals(SingleIntArray, EmptyIntArray));
            Assert.IsFalse(ListEquals(IntArray, SingleIntArray));
            Assert.IsFalse(ListEquals(SingleIntArray, IntArray));
        }

        [Test]
        public static void TestListEqualsRange()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public static void TestIsReversed()
        {
            Assert.IsTrue(IsReversed(EmptyIntArray, EmptyIntArray));
            Assert.IsTrue(IsReversed(SingleIntArray, SingleIntArray));
            Assert.IsTrue(IsReversed(IntArray, IntArray));
            Assert.IsFalse(IsReversed(EmptyIntArray, SingleIntArray));
            Assert.IsFalse(IsReversed(SingleIntArray, EmptyIntArray));
            Assert.IsFalse(IsReversed(IntArray, SingleIntArray));
            Assert.IsFalse(IsReversed(SingleIntArray, IntArray));
        }

        [Test]
        public static void TestStartsWith()
        {
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1 }));
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1, 2 }));
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new int[] { }));
            Assert.IsTrue(StartsWith(new int[] { }, new int[] { }));
            Assert.IsFalse(StartsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
            Assert.IsFalse(StartsWith(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }));
        }

        [Test]
        public static void TestEndsWith()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestIndexOf()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestLastIndexOf()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestSkip()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestTake()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }


        [Test]
        public static void TestTakeLast()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestDrop()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestContains()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }


        [Test]
        public static void TestContainsRange()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }


        [Test]
        public static void TestIndexOfMin()
        {            
            Assert.AreEqual(0, IndexOfMin(new[] { 1, 2, 3 }));
            Assert.AreEqual(2, IndexOfMin(new[] { 3, 2, 1 }));
        }


        [Test]
        public static void TestIndexOfMax()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }


        [Test]
        public static void TestUniqueElements()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }


        [Test]
        public static void TestInsertElement()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestInsertElements()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestRemoveElement()
        {
            Assert.AreEqual(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestRemoveElements()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestAddElement()
        {
            
        }

        [Test]
        public static void TestReverse()
        {
            Assert.AreEqual(new[] { 3, 2, 1 }, Reverse(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestReverseRange()
        {
            Assert.AreEqual(new[] { 3, 2, 1 }, Reverse(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestSubArray()
        {
            Assert.AreEqual(new[] { 1 }, Subarray(new[] { 1, 2, 3 }, 0, 1));
        }

        [Test]
        public static void TestSwapInPlace()
        {
            var xs = new[] { 1, 2, 3 };
            var ys = xs.Clone();
            SwapInPlace(xs, 0, 2);
            Assert.AreEqual(new[] { 1, 2 }, Subarray(new[] { 1, 2, 3 }, 0, 2));
        }

        [Test]
        public static void TestSortedMerge()
        {
            Assert.AreEqual(SortedMerge(new[] { 1, 3, 5 }, new[] { 2, 4 }), new[] { 1, 2, 3, 4, 5 });
        }

        [Test]
        public static void TestRemove()
        {
            Assert.AreEqual(RemoveElements(new[] { 1, 2, 3 }, 2), new[] { 1, 3 });
        }

        [Test]
        public static void TestTransform()
        {
            Assert.AreEqual(Transform(new[] { 1, 2, 3 }, x => x * 2), new[] { 2, 4, 6 });
        }

        [Test]
        public static void TestFilter()
        {
            Assert.AreEqual(Filter(new[] { 1, 2, 3 }, x => x % 2 == 0), new[] { 2 });
        }

        [Test]
        public static void TestSort()
        {
            Assert.AreEqual(EmptyIntArray, Sort(EmptyIntArray));
            Assert.AreEqual(SortedIntArray, Sort(IntArray));
            Assert.AreEqual(SortedStringArray, Sort(StringArray));
            Assert.AreEqual(SortedCharArray, Sort(CharArray));
        }    
    }
}
