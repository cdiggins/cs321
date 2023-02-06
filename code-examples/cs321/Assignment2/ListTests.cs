using NUnit.Framework;

//using static Assignment2.ListOperationsReference;
using static Assignment2.ListOperations;

namespace Assignment2
{
    /// <summary>
    /// Minimal unit tests for the ListOperations class.
    /// In each test we give a simple input and expected output and check it works. 
    /// </summary>
    public static class ListTestsBasic
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
            Assert.AreEqual(new[] { 1, 2 }, UniqueElements(new[] { 3, 1, 2, 3  }));
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
        public static void TestRemoveAt()
        {
            Assert.AreEqual(new[] { 1, 2 }, RemoveAt(new[] { 1, 2, 3 }, 2));
        }

        [Test]
        public static void TestAddElement()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, AddElement(new[] { 1, 2 }, 3));
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

    /// <summary>
    /// Additional unit tests for the ListOperations class.
    /// In these tests we check with additional inputs, and where possible check for expected negative results 
    /// </summary>
    public static class ListTestsAdditional
    {
        [Test]
        public static void TestIsSorted()
        {
            Assert.IsTrue(IsSorted(new int[] { }));
            Assert.IsTrue(IsSorted(new[] { 1 }));
            Assert.IsTrue(IsSorted(new[] { 1, 1, 1 }));
            Assert.IsFalse(IsSorted(new[] { 3, 2, 1 }));
            Assert.IsFalse(IsSorted(new[] { 1, 2, 1 }));
        }

        [Test]
        public static void TestIsSortedRange()
        {
            Assert.IsTrue(IsSorted(new[] { 3, 1, 2 }, 0, 1));
            Assert.IsFalse(IsSorted(new[] { 3, 1, 2 }, 0, 2));
        }

        [Test]
        public static void TestCount()
        {
            Assert.AreEqual(1, Count(new[] { 1, 2, 1, }, 2));
            Assert.AreEqual(0, Count(new[] { 1, 2, 1, }, 3));
        }

        [Test]
        public static void TestListEquals()
        {
            Assert.IsTrue(ListEquals(new int[] { }, new int[] { }));
            Assert.IsFalse(ListEquals(new[] { 1, 2 }, new[] { 2, 3 }));
            Assert.IsFalse(ListEquals(new[] { 1 }, new[] { 2 }));
            Assert.IsFalse(ListEquals(new[] { 1, 2 }, new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestIsReversed()
        {
            Assert.IsTrue(IsReversed(new int[] { }, new int[] { }));
            Assert.IsTrue(IsReversed(new[] { 1 }, new[] { 1 }));
            Assert.IsFalse(IsReversed(new[] { 1 }, new[] { 2 }));
            Assert.IsTrue(IsReversed(new[] { 1, 1 }, new[] { 1, 1 }));
            Assert.IsFalse(IsReversed(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
        }

        [Test]
        public static void TestStartsWith()
        {
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
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new[] { 3 }));
            Assert.IsTrue(EndsWith(new[] { 1, 2, 3 }, new int[] { }));
            Assert.IsFalse(EndsWith(new[] { 1, 2, 3 }, new[] { 1, 2 }));
            Assert.IsFalse(EndsWith(new[] { 1, 2, 3 }, new[] { 1, 3 }));
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
            Assert.AreEqual(new[] { 1, 2, 3 }, Skip(new[] { 1, 2, 3 }, 0));
            Assert.AreEqual(new int[] { }, Skip(new[] { 1, 2, 3 }, 3));
        }

        [Test]
        public static void TestTake()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, Take(new[] { 1, 2, 3 }, 3));
            Assert.AreEqual(new int[] { }, Take(new[] { 1, 2, 3 }, 0));
        }

        [Test]
        public static void TestTakeLast()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, TakeLast(new[] { 1, 2, 3 }, 3));
            Assert.AreEqual(new int[] { }, TakeLast(new[] { 1, 2, 3 }, 0));
        }

        [Test]
        public static void TestDrop()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, Drop(new[] { 1, 2, 3 }, 0));
            Assert.AreEqual(new int[] { }, Drop(new[] { 1, 2, 3 }, 3));
        }

        [Test]
        public static void TestContains()
        {
            Assert.IsFalse(Contains(new int[] { }, 2));
            Assert.IsFalse(Contains(new[] { 1, 2, 3 }, 4));
        }

        [Test]
        public static void TestIndexOfMin()
        {
            Assert.AreEqual(-1, IndexOfMin(new int[] { }));
            Assert.AreEqual(0, IndexOfMin(new[] { 1, 1, 1 }));
        }

        [Test]
        public static void TestIndexOfMax()
        {
            Assert.AreEqual(-1, IndexOfMax(new int[] { }));
            Assert.AreEqual(0, IndexOfMax(new[] { 1, 1, 1 }));
        }

        [Test]
        public static void TestUniqueElements()
        {
            Assert.AreEqual(new int[] { }, UniqueElements(new int[] { }));
            Assert.AreEqual(new[] { 1 }, UniqueElements(new[] { 1 }));
            Assert.AreEqual(new int[] { }, UniqueElements(new[] { 1, 1, 1 }));
            Assert.AreEqual(new[] { 1, 2 }, UniqueElements(new[] { 1, 2 }));
        }

        [Test]
        public static void TestInsertElement()
        {
            Assert.AreEqual(new[] { 9, 1, 2, 3 }, InsertElement(new[] { 1, 2, 3 }, 9, 0));
            Assert.AreEqual(new[] { 1, 2, 3, 9 }, InsertElement(new[] { 1, 2, 3 }, 9, 3 ));
            Assert.AreEqual(new[] { 9 }, InsertElement(new int[] { }, 9, 0 ));
        }

        [Test]
        public static void TestInsertElements()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, InsertElements(new[] { 1, 2, 3 }, new int[] { }, 0));
            Assert.AreEqual(new[] { 1, 2, 3, 1, 2, 3 }, InsertElements(new[] { 1, 2, 3 }, new [] { 1, 2, 3 }, 0));
            Assert.AreEqual(new[] { 1, 4, 5, 2, 3 }, InsertElements(new[] { 1, 2, 3 }, new[] { 4, 5 }, 1));
        }

        [Test]
        public static void TestRemoveElement()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, RemoveElements(new[] { 1, 2, 3 }, 99));
        }

        [Test]
        public static void TestRemoveElements()
        {
            Assert.AreEqual(new int[] { }, RemoveElements(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
            Assert.AreEqual(new[] { 1, 2, 3 }, RemoveElements(new[] { 1, 2, 3 }, new int[] { }));
        }

        [Test]
        public static void TestRemoveAt()
        {
            Assert.AreEqual(new int[] { }, RemoveAt(new[] { 1 }, 0));
        }

        [Test]
        public static void TestAddElement()
        {
            Assert.AreEqual(new[] { 1 }, AddElement(new int[] { }, 1));
        }

        [Test]
        public static void TestReverse()
        {
            var xs = new[] { 1, 2, 3 };
            Assert.AreEqual(xs, Reverse(Reverse(xs)));
            Assert.AreEqual(new[] { 1 }, Reverse(new[] { 1 }));
        }

        [Test]
        public static void TestReverseRange()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, Reverse(new[] { 1, 2, 3 }, 0, 0));
            Assert.AreEqual(new[] { 1, 2, 3 }, Reverse(new[] { 1, 2, 3 }, 1, 0));
            Assert.AreEqual(new[] { 1, 2, 3 }, Reverse(new[] { 1, 2, 3 }, 1, 1));
            Assert.AreEqual(new[] { 3, 2, 1 }, Reverse(new[] { 1, 2, 3 }, 0, 3));
        }

        [Test]
        public static void TestSubArray()
        {
            Assert.AreEqual(new int[] { }, Subarray(new[] { 1, 2, 3 }, 0, 0));
            var xs = new[] { 1, 2, 3 };
            Assert.AreEqual(xs, Subarray(xs, 0, 3));
        }

        [Test]
        public static void TestSortedMerge()
        {
            Assert.AreEqual(new int[] { }, SortedMerge(new int[] { }, new int[] { }));
            Assert.AreEqual(new [] { 1, 1 }, SortedMerge(new [] { 1 }, new int[] { 1 }));
        }

        [Test]
        public static void TestTransform()
        {
            Assert.AreEqual(new[] { 1, 2, 3 }, Transform(new[] { 1, 2, 3 }, x => x));
            Assert.AreEqual(new int[] { }, Transform(new int[] { }, x => x));
        }

        [Test]
        public static void TestFilter()
        {
            Assert.AreEqual(new int[] { }, Filter(new[] { 1, 2, 3 }, x => false));
            Assert.AreEqual(new[] {1,2,3 }, Filter(new[] { 1, 2, 3 }, x => true));
        }
    }
    
    /// <summary>
    /// This is a more extensive set of tests that runs thgough a set of inputs and validates properties
    /// and equalities
    /// </summary>
    public static class ListTestsExtensive
    {
        public static int[][] Inputs = new[]
        {
            Array.Empty<int>(),
            new[] { 1 },
            new[] { 1, 2 },
            new[] { 1, 2, 3, 4, 5 },
            new[] { 5, 4, 3, 2, 1 },
            new[] { 1, 2, 3, 2, 1 },
            new[] { 1, 1, 2, 2, },
            new[] { 1, 2, 1, 2 },
            new[] { 1, 5, 2, 4, 3 },
            new[] { 1, 1, 1, 1, 1 },
            new[] { 1, 1, 1, 1, 5 },
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
                Assert.IsFalse(ListEquals(xs, new[] { 99 }));
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
                for (var i = 0; i < xs.Length; ++i)
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
                    Assert.AreEqual(xs.Length - 1, LastIndexOf(xs, xs[xs.Length - 1]));
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
                    Assert.AreEqual(xs.Length - i, suffix.Count);
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
                    var ys = InsertElement(xs, 99, i);
                    Assert.AreEqual(xs.Length + 1, ys.Count);
                    Assert.AreEqual(99, ys[i]);
                    for (var j = i + 1; j < ys.Count; ++j)
                    {
                        Assert.AreEqual(xs[j - 1], ys[j]);
                    }
                }
            }
        }

        [Test]
        public static void TestInsertElements()
        {
            var tmp = new[] { 1, 2, 3 };
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(AddElements(xs, tmp), InsertElements(xs, tmp, xs.Length));
                
                for (var i = 0; i < xs.Length; ++i)
                {
                    var r = InsertElements(xs, tmp, i);
                    Assert.AreEqual(xs.Length + tmp.Length, r.Count);
                    var sub = Subarray(r, i, tmp.Length);
                    Assert.AreEqual(tmp, sub);
                }
            }
        }

        [Test]
        public static void TestRemoveElement()
        {
            foreach (var xs in Inputs)
            {
                if (xs.Length > 0)
                {
                    Assert.IsTrue(RemoveElements(xs, xs[0]).Count < xs.Length);
                }
            }
        }

        [Test]
        public static void TestRemoveElements()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(0, RemoveElements(xs, xs).Count);
                Assert.AreEqual(xs.Length, RemoveElements(xs, new[] { 99 }).Count);
            }
        }

        [Test]
        public static void TestRemoveElementAt()
        {
            foreach (var xs in Inputs)
            {
                for (var i = 0; i < xs.Length; ++i)
                {
                    var tmp = RemoveAt(xs, i);
                    Assert.AreEqual(xs.Length - 1, tmp.Count);
                    if (i < xs.Length - 1)
                    {
                        Assert.AreEqual(xs[i + 1], tmp[i]);
                    }
                }
            }
        }

        [Test]
        public static void TestAddElement()
        {
            foreach (var xs in Inputs)
            {
                var tmp = AddElement(xs, 99);
                Assert.AreEqual(xs.Length + 1, tmp.Count);
                Assert.AreEqual(tmp[tmp.Count - 1], 99);
            }
        }

        [Test]
        public static void TestReverse()
        {
            foreach (var xs in Inputs)
            {
                var ys = Reverse(xs);
                Assert.AreEqual(xs.Length, ys.Count);
                Assert.IsTrue(IsReversed(xs, ys));
            }
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
                        var sub = Subarray(tmp, i, cnt);
                        Assert.IsTrue(IsReversed(xs, i, sub));
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

        [Test]
        public static void TestTransform()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(xs, Transform(xs, x => x));
                var tmp = new int[xs.Length];
                Array.Fill(tmp, 99);
                Assert.AreEqual(tmp, Transform(xs, x => 99));
            }
        }

        [Test]
        public static void TestFilter()
        {
            foreach (var xs in Inputs)
            {
                Assert.AreEqual(xs, Filter(xs, x => true));
                Assert.AreEqual(Array.Empty<int>(), Filter(xs, x => false));
            }
        }
    }
}
