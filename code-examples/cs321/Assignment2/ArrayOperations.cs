
// Implement these functions from first principles. 
// Do not use System library functions except for the following:
//
// IList<T>.Count
// IList<T>.Add()
// IList<T>.[]
// IList<T>.[]= 
// IReadOnlyList<T>.Count
// IReadOnlyList<T>.[]
// object.Equals()
// object.ToString()
// IComparable<T>.CompareTo()
//
// Feel free to use additional functions that you write, or that exists in this file
// If the list is invalid throw an Exception with an error message (e.g. throw new Exception(message))
// 
// This may seem like a daunting task at first, but look for opportunities to reduce
// the amount of code you write, and to reuse existing functions, and it will become easier as you progress.

namespace Assignment2
{
    public static class Helpers
    {
        public static bool IsLessThanOrEqualTo<T>(T first, T second) where T : IComparable<T>
            => first.CompareTo(second) <= 0;

        public static (T, T) Sort<T>(T first, T second) where T : IComparable<T>
            => IsLessThanOrEqualTo(first, second) ? (first, second) : (second, first);
    }

    public static class ArrayOperations
    {
        public static bool IsSorted<T>(IReadOnlyList<T> xs) where T : IComparable<T>
            => throw new NotImplementedException();

        public static bool IsSorted<T>(IReadOnlyList<T> list, int from, int count) where T : IComparable<T>
            => throw new NotImplementedException();

        public static int Count<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static bool SequenceEquals<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
            => throw new NotImplementedException();

        public static bool SequenceReversed<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
            => throw new NotImplementedException();

        public static bool SequenceEquals<T>(IReadOnlyList<T> list1, int from1, IReadOnlyList<T> list2, int from2, int count)
            => throw new NotImplementedException();

        public static bool SequenceReversed<T>(IReadOnlyList<T> list1, int from1, IReadOnlyList<T> list2, int from2, int count)
            => throw new NotImplementedException();

        public static bool EndsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> suffix)
            => throw new NotImplementedException();

        public static bool StartsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> prefix)
            => throw new NotImplementedException();

        public static int IndexOf<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static int IndexOf<T>(IReadOnlyList<T> list, IReadOnlyList<T> subArray)
            => throw new NotImplementedException();

        public static int LastIndexOf<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static int LastIndexOf<T>(IReadOnlyList<T> list, IReadOnlyList<T> subArray)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Skip<T>(IReadOnlyList<T> list, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Take<T>(IReadOnlyList<T> list, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Drop<T>(IReadOnlyList<T> list, int count)
            => throw new NotImplementedException();

        public static bool Contains<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static bool Contains<T>(IReadOnlyList<T> list, IReadOnlyList<T> subArray)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> RemoveUniqueElements<T>(IReadOnlyList<T> list)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> RemoveDuplicateElements<T>(IReadOnlyList<T> list)
            => throw new NotImplementedException();

        public static T MostCommonElement<T>(IReadOnlyList<T> list)
            => throw new NotImplementedException();

        public static int IndexOfMin<T>(IReadOnlyList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static int IndexOfMax<T>(IReadOnlyList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static (T min, T max) GetMinAndMax<T>(IReadOnlyList<T> list) where T: IComparable<T>
            => throw new NotImplementedException();

        public static int IndexOfNthLargest<T>(IReadOnlyList<T> self, int nth)
            => throw new NotImplementedException();

        public static T NthLargest<T>(IReadOnlyList<T> self, int nth)
            => throw new NotImplementedException();

        public static T Median<T>(IReadOnlyList<T> self)
            => throw new NotImplementedException();

        public static int IndexOfMedian<T>(IReadOnlyList<T> self)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> GetUniqueElements<T>(IReadOnlyList<T> list)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> GetDuplicatedElements<T>(IReadOnlyList<T> list)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> InsertElement<T>(IReadOnlyList<T> list, T element, int index)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> InsertElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> range, int index)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> RemoveElement<T>(IReadOnlyList<T> list, int index)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, int index, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> AddElement<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> SortedMerge<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> AddElements<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> RemoveRange<T>(IReadOnlyList<T> list, int start, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Resize<T>(IReadOnlyList<T> list, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list, int start, int count)
            => throw new NotImplementedException();

        public static void ReverseInPlace<T>(List<T> list)
            => throw new NotImplementedException();

        public static void ReverseInPlace<T>(List<T> list, int start, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Fill<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Fill<T>(IReadOnlyList<T> list, int start, int count, T element)
            => throw new NotImplementedException();

        public static void FillInPlace<T>(List<T> list, T element)
            => throw new NotImplementedException();

        public static void FillInPlace<T>(List<T> list, int start, int count, T element)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Subarray<T>(IReadOnlyList<T> list, int start, int count)
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Swap<T>(IReadOnlyList<T> list, int index1, int index2)
            => throw new NotImplementedException();

        public static void SwapInPlace<T>(IList<T> list, int index1, int index2)
            => throw new NotImplementedException();

        public static int SortedArrayContains<T>(IReadOnlyList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void BubbleSort<T>(IList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void BubbleSort<T>(IList<T> list, int from, int count) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void MergeSort<T>(IList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void MergeSort<T>(IList<T> list, int from, int count) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void QuickSort<T>(IList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void QuickSort<T>(IList<T> list, int from, int count) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void InsertionSort<T>(IList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static void InsertionSort<T>(IList<T> list, int from, int count) where T : IComparable<T>
            => throw new NotImplementedException();

        public static IReadOnlyList<T> Except<T>(IReadOnlyList<T> list, T element)
            => throw new NotImplementedException();

        public static (IReadOnlyList<T>, IReadOnlyList<T>) SplitAt<T>(IReadOnlyList<T> list, int index)
            => throw new NotImplementedException();

        public static (IReadOnlyList<T>, IReadOnlyList<T>) Partition<T>(IReadOnlyList<T> list, T element) where T : IComparable<T>
            => throw new NotImplementedException();

        public static bool IsHeap<T>(IReadOnlyList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static bool IsBinaryTree<T>(IReadOnlyList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static (int start, int count) LongestRun<T>(IReadOnlyList<T> list) where T : IComparable<T>
            => throw new NotImplementedException();

        public static IReadOnlyList<T1> Transform<T0, T1>(IReadOnlyList<T0> list, Func<T0, T1> transformer)
            => throw new NotImplementedException();
    }
}
