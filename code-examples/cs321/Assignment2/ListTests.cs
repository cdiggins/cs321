using System.Runtime.InteropServices;
using NUnit.Framework;

using static Assignment2.ListOperationsReference;
//using static Assignment2.ListOperations;

namespace Assignment2
{
    public static class ListSmokeTests1
    {
        [Test]
        public static void TestIsSorted()
        {
            Assert.IsTrue(IsSorted(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestIsSortedRange()
        {
            Assert.IsTrue(IsSorted(new[] { 3, 1, 2 }, 1, 2));
        }

        [Test]
        public static void TestCount()
        {
            Assert.AreEqual(2, Count(new[] { 1, 2, 1, }, 1));
        }

        [Test]
        public static void TestListEquals()
        {
            Assert.IsTrue(ListEquals(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestIsReversed()
        {
            Assert.IsTrue(IsReversed(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }));
        }

        [Test]
        public static void TestStartsWith()
        {
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1 }));
        }

        [Test]
        public static void TestEndsWith()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestIndexOf()
        {
            Assert.AreEqual(1, IndexOf(new[] { 1, 2, 1 }, 2));
        }

        [Test]
        public static void TestLastIndexOf()
        {
            Assert.AreEqual(1, LastIndexOf(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestSkip()
        {
            Assert.AreEqual(new[] { 2, 3 }, Skip(new[] { 1, 2, 3 }, 1));
        }

        [Test]
        public static void TestTake()
        {
            Assert.AreEqual(new[] { 1, 2 }, Take(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestTakeLast()
        {
            Assert.AreEqual(new[] { 2, 3 }, TakeLast(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestDrop()
        {
            Assert.AreEqual(new[] { 1 }, Drop(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestContains()
        {
            Assert.IsTrue(Contains(new[] { 1, 2, 3 }, 2));
            Assert.IsFalse(Contains(new[] { 1, 2, 3 }, 4));
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
            Assert.AreEqual(2, IndexOfMax(new[] { 1, 2, 3 }));
            Assert.AreEqual(0, IndexOfMax(new[] { 3, 2, 1 }));
        }

        [Test]
        public static void TestUniqueElements()
        {
            Assert.AreEqual(new[] { 1, 2 }, UniqueElements(new[] { 1, 2, 2, 1 }));
        }

        [Test]
        public static void TestInsertElement()
        {
            Assert.AreEqual(new[] { 1, 9, 2, 3 }, InsertElement(new[] { 1, 2, 3 }, 9, 1));
        }

        [Test]
        public static void TestInsertElements()
        {
            Assert.AreEqual(new[] { 1, 4, 5, 2, 3 }, InsertElements(new[] { 1, 2, 3 }, new[] { 4, 5 }, 1));
        }

        [Test]
        public static void TestRemoveElement()
        {
            Assert.AreEqual(new[] { 1, 3 }, RemoveElements(new[] { 1, 2, 3}, 2));
        }

        [Test]
        public static void TestRemoveElements()
        {
            Assert.AreEqual(new[] { 1 }, RemoveElements(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestAddElement()
        {
            Assert.AreEqual(AddElement(new[] { 1, 2 }, 3), new[] { 1, 2, 3});
        }

        [Test]
        public static void TestReverse()
        {
            Assert.AreEqual(new[] { 3, 2, 1 }, Reverse(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestReverseRange()
        {
            Assert.AreEqual(new[] { 1, 3, 2 }, Reverse(new[] { 1, 2, 3 }, 1, 2));
        }

        [Test]
        public static void TestSubArray()
        {
            Assert.AreEqual(new[] { 2, 3 }, Subarray(new[] { 1, 2, 3 }, 1, 2));
        }

        [Test]
        public static void TestSortedMerge()
        {
            Assert.AreEqual(SortedMerge(new[] { 1, 3, 5 }, new[] { 2, 4 }), new[] { 1, 2, 3, 4, 5 });
        }

        [Test]
        public static void TestRemove()
        {
            Assert.AreEqual(new[] { 1, 3 }, RemoveElements(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestTransform()
        {
            Assert.AreEqual(new[] { 2, 4, 6 }, Transform(new[] { 1, 2, 3 }, x => x * 2));
        }

        [Test]
        public static void TestFilter()
        {
            Assert.AreEqual(new[] { 2 }, Filter(new[] { 1, 2, 3 }, x => x % 2 == 0));
        }
    }
    public static class ListSmokeTests2
    {
        [Test]
        public static void TestIsSorted()
        {
            Assert.IsTrue(IsSorted(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestIsSortedRange()
        {
            Assert.IsTrue(IsSorted(new[] { 3, 1, 2 }, 1, 2));
        }

        [Test]
        public static void TestCount()
        {
            Assert.AreEqual(2, Count(new[] { 1, 2, 1, }, 1));
        }

        [Test]
        public static void TestListEquals()
        {
            Assert.IsTrue(ListEquals(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestIsReversed()
        {
            Assert.IsTrue(IsReversed(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }));
        }

        [Test]
        public static void TestStartsWith()
        {
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1 }));
            /* TODO: remove
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1, 2 }));
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
            Assert.IsTrue(StartsWith(new[] { 1, 2, 3 }, new int[] { }));
            Assert.IsTrue(StartsWith(new int[] { }, new int[] { }));
            Assert.IsFalse(StartsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
            Assert.IsFalse(StartsWith(new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4 }));
            */
        }

        [Test]
        public static void TestEndsWith()
        {
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestIndexOf()
        {
            Assert.AreEqual(1, IndexOf(new[] { 1, 2, 1 }, 2));
            Assert.AreEqual(-1, IndexOf(new[] { 1, 2, 1 }, 0));
            Assert.AreEqual(0, IndexOf(new[] { 1, 2, 1 }, 1));
        }

        [Test]
        public static void TestLastIndexOf()
        {
            Assert.AreEqual(1, LastIndexOf(new[] { 1, 2, 3 }, 2));
            Assert.AreEqual(-1, LastIndexOf(new[] { 1, 2, 3 }, 0));
            Assert.AreEqual(2, LastIndexOf(new[] { 1, 2, 1 }, 1));
        }

        [Test]
        public static void TestSkip()
        {
            Assert.AreEqual(new[] { 2, 3 }, Skip(new[] { 1, 2, 3 }, 1));
        }

        [Test]
        public static void TestTake()
        {
            Assert.AreEqual(new[] { 1, 2 }, Take(new[] { 1, 2, 3 }, 2));
        }


        [Test]
        public static void TestTakeLast()
        {
            Assert.AreEqual(new[] { 2, 3 }, TakeLast(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestDrop()
        {
            Assert.AreEqual(new[] { 1 }, Drop(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestContains()
        {
            Assert.IsTrue(Contains(new[] { 1, 2, 3 }, 2));
            Assert.IsFalse(Contains(new[] { 1, 2, 3 }, 4));
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
            Assert.AreEqual(2, IndexOfMax(new[] { 1, 2, 3 }));
            Assert.AreEqual(0, IndexOfMax(new[] { 3, 2, 1 }));
        }

        [Test]
        public static void TestUniqueElements()
        {
            Assert.AreEqual(new[] { 1, 2 }, UniqueElements(new[] { 1, 2, 2, 1 }));
        }

        [Test]
        public static void TestInsertElement()
        {
            Assert.AreEqual(new[] { 1, 9, 2, 3 }, InsertElement(new[] { 1, 2, 3 }, 9, 1));
        }

        [Test]
        public static void TestInsertElements()
        {
            Assert.AreEqual(new[] { 1, 4, 5, 2, 3 }, InsertElements(new[] { 1, 2, 3 }, new[] { 4, 5 }, 1));
        }

        [Test]
        public static void TestRemoveElement()
        {
            Assert.AreEqual(new[] { 1, 3 }, RemoveElements(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestRemoveElements()
        {
            Assert.AreEqual(new[] { 1 }, RemoveElements(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestAddElement()
        {
            Assert.AreEqual(AddElement(new[] { 1, 2 }, 3), new[] { 1, 2, 3 });
        }

        [Test]
        public static void TestReverse()
        {
            Assert.AreEqual(new[] { 3, 2, 1 }, Reverse(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestReverseRange()
        {
            Assert.AreEqual(new[] { 1, 3, 2 }, Reverse(new[] { 1, 2, 3 }, 1, 2));
        }

        [Test]
        public static void TestSubArray()
        {
            Assert.AreEqual(new[] { 2, 3 }, Subarray(new[] { 1, 2, 3 }, 1, 2));
        }

        [Test]
        public static void TestSortedMerge()
        {
            Assert.AreEqual(SortedMerge(new[] { 1, 3, 5 }, new[] { 2, 4 }), new[] { 1, 2, 3, 4, 5 });
        }

        [Test]
        public static void TestRemove()
        {
            Assert.AreEqual(new[] { 1, 3 }, RemoveElements(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestTransform()
        {
            Assert.AreEqual(new[] { 2, 4, 6 }, Transform(new[] { 1, 2, 3 }, x => x * 2));
        }

        [Test]
        public static void TestFilter()
        {
            Assert.AreEqual(new[] { 2 }, Filter(new[] { 1, 2, 3 }, x => x % 2 == 0));
        }
    }

    public static class ListTestsExtensive
    {
        public static int[][] Inputs = new[]
        {
            Array.Empty<int>(),
            new [] { 1 },
            new [] { 1, 2 },
            new [] { 1, 2, 3, 4, 5 },
            new [] { 5, 4, 3, 2, 1 },
            new [] { 1, 2, 3, 2, 1 },
            new [] { 1, 1, 2, 2, },
            new [] { 1, 2, 1, 2 },
            new [] { 1, 5, 2, 4, 3 },
            new [] { 1, 1, 1, 1, 1 },
        };

        [Test]
        public static void TestIsSorted()
        {
            foreach (var xs in Inputs)
            {
                var sorted = IsSorted(xs);
                if (xs.Length <= 1)
                    Assert.IsTrue(sorted);
                if (sorted)
                {
                    for (var i = 0; i < xs.Length - 1; i++)
                        Assert.IsTrue(xs[i] <= xs[i + 1]);
                }

                Assert.AreEqual(sorted, IsSorted(xs, 0, xs.Length));
            }
        }

        [Test]
        public static void TestCount()
        {
            foreach (var xs in Inputs)
            {
                Assert.IsTrue(xs.Length >= Count(xs, 0));
                // We didn't put 99 in any of the inputs 
                Assert.AreEqual(0, Count(xs, 99));

                // Check that the first item and the last item in the list are indeed counted 
                if (xs.Length > 1)
                {
                    Assert.IsTrue(Count(xs, xs[0]) > 0);
                    Assert.IsTrue(Count(xs, xs[xs.Length - 1]) > 0);
                }
            }
        }

        [Test]
        public static void TestListEquals()
        {
            foreach (var xs in Inputs)
            {
                Assert.IsTrue(ListEquals(xs, xs));
                Assert.IsFalse(ListEquals(xs, new [] { 99 }));
            }
        }

        [Test]
        public static void TestIsReversed()
        {
            foreach (var xs in Inputs)
            {
                if (Helpers.IsPalindrome(xs) || xs.Length <= 1)
                    Assert.IsTrue(IsReversed(xs, xs));
                Assert.IsTrue(IsReversed(xs, Reverse(xs)));
            }
        }

        [Test]
        public static void TestStartsWith()
        {
            foreach (var xs in Inputs)
            {
                Assert.IsTrue(StartsWith(xs, xs));
                Assert.IsTrue(StartsWith(xs, Array.Empty<int>()));
                for (var i=0; i < xs.Length; ++i)
                {
                    var prefix = Take(xs, i);
                    Assert.IsTrue(StartsWith(xs, prefix));
                }
            }
        }

        [Test]
        public static void TestEndsWith()
        {
            foreach (var xs in Inputs)
            {
                Assert.IsTrue(EndsWith(xs, xs));
                Assert.IsTrue(EndsWith(xs, Array.Empty<int>()));
                for (var i = 0; i < xs.Length; ++i)
                {
                    var suffix = TakeLast(xs, i);
                    Assert.IsTrue(EndsWith(xs, suffix));
                }
            }
        }

        [Test]
        public static void TestIndexOf()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(-1, IndexOf(xs, 99));

                if (xs.Length > 1)
                {
                    Assert.AreEqual(0, IndexOf(xs, xs[0]));
                    Assert.IsTrue(IndexOf(xs, xs[xs.Length - 1]) >= 0);
                }
            }
        }

        [Test]
        public static void TestLastIndexOf()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(-1, IndexOf(xs, 99));

                if (xs.Length > 1)
                {
                    Assert.AreEqual(xs.Length -1, LastIndexOf(xs, xs[xs.Length-1]));
                    Assert.IsTrue(IndexOf(xs, xs[0]) >= 0);
                }
            }
        }

        [Test]
        public static void TestSkipAndTakeLast()
        {
            foreach (var xs in Inputs)
            {
                for (var i = 0; i < xs.Length; ++i)
                {
                    var suffix = Skip(xs, i);
                    var suffix2 = TakeLast(xs, xs.Length - i);
                    Assert.AreEqual(suffix, suffix2);
                    Assert.AreEqual(i, suffix.Count);
                    Assert.IsTrue(EndsWith(xs, suffix));
                }
            }
        }

        [Test]
        public static void TestTakeAndDrop()
        {
            foreach (var xs in Inputs)
            {
                for (var i = 0; i < xs.Length; ++i)
                {
                    var prefix = Take(xs, i);
                    var prefix2 = Drop(xs, xs.Length - i);
                    Assert.AreEqual(prefix, prefix2);
                    Assert.AreEqual(i, prefix.Count);
                    Assert.IsTrue(StartsWith(xs, prefix));
                }
            }
        }

        [Test]
        public static void TestContains()
        {
            foreach (var xs in Inputs)
            {
                Assert.IsFalse(Contains(xs, 99));
                foreach (var x in xs)
                    Assert.IsTrue(Contains(xs, x));
            }
        }
        
        [Test]
        public static void TestIndexOfMinAndMax()
        {
            foreach (var xs in Inputs)
            {
                if (xs.Length == 0)
                {
                    Assert.AreEqual(-1, IndexOfMin(xs));
                    Assert.AreEqual(-1, IndexOfMax(xs));
                }
                else if (xs.Length == 1)
                {
                    Assert.AreEqual(0, IndexOfMin(xs));
                    Assert.AreEqual(0, IndexOfMax(xs));
                }
                else
                {
                    var min = xs[IndexOfMin(xs)];
                    var max = xs[IndexOfMax(xs)];
                    foreach (var x in xs)
                    {
                        Assert.IsTrue(Helpers.IsLessThanOrEqualTo(min, x));
                        Assert.IsTrue(Helpers.IsLessThanOrEqualTo(x, max));
                    }
                }
            }
        }

        [Test]
        public static void TestUniqueElements()
        {
            foreach (var xs in Inputs)
            {
                var unique = UniqueElements(xs);
                foreach (var x in unique)
                {
                    Assert.AreEqual(1, Count(xs, x));
                }
            }
        }

        [Test]
        public static void TestInsertElement()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(InsertElement(xs, 99, xs.Length), AddElement(xs, 99));
                
                for (var i = 0; i <= xs.Length; ++i)
                {
                    var ys = InsertElement(xs, i, 99);
                    Assert.AreEqual(xs.Length + 1, ys.Count);
                    Assert.AreEqual(99, ys[i]);
                    for (var j = 0; j < xs.Length; ++j)
                    {
                        Assert.AreEqual(xs[j], ys[j < i ? j : j + 1]);
                    }
                }
            }
        }

        [Test]
        public static void TestInsertElements()
        {
            Assert.AreEqual(new[] { 1, 4, 5, 2, 3 }, InsertElements(new[] { 1, 2, 3 }, new[] { 4, 5 }, 1));
        }

        [Test]
        public static void TestRemoveElement()
        {
            Assert.AreEqual(new[] { 1, 3 }, RemoveElements(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestRemoveElements()
        {
            Assert.AreEqual(new[] { 1 }, RemoveElements(new[] { 1, 2, 3 }, new[] { 2, 3 }));
        }

        [Test]
        public static void TestAddElement()
        {
            Assert.AreEqual(AddElement(new[] { 1, 2 }, 3), new[] { 1, 2, 3 });
        }

        [Test]
        public static void TestReverse()
        {
            Assert.AreEqual(new[] { 3, 2, 1 }, Reverse(new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestReverseRange()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(Reverse(xs), Reverse(xs, 0, xs.Length));

                for (var i = 0; i < xs.Length; ++i)
                {
                    for (var cnt = 0; cnt < xs.Length - i; ++cnt)
                    {
                        var tmp = Reverse(xs, i, cnt);
                        Assert.IsTrue(IsReversed(xs, i, tmp));
                    }
                }
            }
        }

        [Test]
        public static void TestSubArray()
        {
            foreach (var xs in Inputs)
            {
                for (var i = 0; i < xs.Length - 1; i++)
                {
                    for (var cnt = 0; cnt < xs.Length - 1 - i; cnt++)
                    {
                        var sub = Subarray(xs, i, cnt);
                        Assert.AreEqual(sub.Count, cnt);
                        for (var j = 0; j < cnt; j++)
                        {
                            Assert.AreEqual(xs[i + j], sub[j]);
                        }
                    }
                }
            }
        }

        [Test]
        public static void TestRemove()
        {
            foreach (var xs in Inputs)
            {
                if (xs.Length > 0)
                {
                    var tmp = RemoveElements(xs, xs[0]);
                    Assert.IsTrue(tmp.Count < xs.Length);
                    Assert.IsFalse(Contains(tmp, xs[0]));
                }
            }
        }
    }
}
