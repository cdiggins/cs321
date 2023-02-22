
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

using System.Diagnostics;
using System.Security.Principal;

namespace Assignment2
{
    public static class ListOperations
    {
        // Helper
        public static bool All<T>(IReadOnlyList<T> xs, Func<T, int, bool> predicate)
        {
            return Filter(xs, predicate).Count == xs.Count;
        }

        /// <summary>
        /// Returns true if the list is in ascending order, false otherwise. 
        /// </summary>
        public static bool IsSorted<T>(IReadOnlyList<T> xs) where T : IComparable<T>
        {
            return All(xs, (x, i) => i == 0 || x.CompareTo(xs[i-1]) >= 0);
        }

        /// <summary>
        /// Returns true if the section of list is in ascending order, false otherwise. 
        /// </summary>
        public static bool IsSorted<T>(IReadOnlyList<T> list, int from, int count) where T : IComparable<T>
        {
            return IsSorted(Subarray(list, from, count));
        }

        /// <summary>
        /// Returns the number of times the character occurs in the list 
        /// </summary>
        public static int Count<T>(IReadOnlyList<T> list, T element)
        {
            return Filter(list, x => x.Equals(element)).Count;
        }

        /// <summary>
        /// Returns true if the two collections are the same
        /// </summary>
        public static bool ListEquals<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            if (list1.Count != list2.Count)
                return false;
            return All(list1, (x, i) => x.Equals(list2[i]));
        }

        /// <summary>
        /// Returns true if the second collection is the same as the second in reverse order. 
        /// </summary>
        public static bool IsReversed<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            return ListEquals(list1, Reverse(list2));
        }

        /// <summary>
        /// Returns true if the second collection is the same as the first sequence starting from index in reverse order. 
        /// </summary>
        public static bool IsReversed<T>(IReadOnlyList<T> list1, int index, IReadOnlyList<T> list2)
        {
            return IsReversed(Subarray(list1, index, list2.Count), list2);
        }

        /// <summary>
        /// Returns true if the collection starts with the specified elements 
        /// </summary>
        public static bool StartsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> prefix)
        {
            return ListEquals(Take(list, prefix.Count), prefix);
        }

        /// <summary>
        /// Returns true if the collection ends with the specfied elements 
        /// </summary>
        public static bool EndsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> suffix)
        {
            return ListEquals(TakeLast(list, suffix.Count), suffix);
        }

        /// <summary>
        /// Returns the index of the first occurence of the specified value, or -1 if it is not found. 
        /// </summary>
        public static int IndexOf<T>(IReadOnlyList<T> list, T value)
        {
            for (var i = 0; i < list.Count; ++i)
                if (list[i].Equals(value))
                    return i;
            return -1;
        }

        /// <summary>
        /// Returns the last index of the first occurence of the specified sublist, or -1 if it is not found. 
        /// </summary>
        public static int LastIndexOf<T>(IReadOnlyList<T> list, T value)
        {
            for (var i = list.Count - 1; i >= 0; --i)
                if (list[i].Equals(value))
                    return i;
            return -1;
        }

        /// <summary>
        /// Creates a new list by skipping the first n items of a list 
        /// </summary>
        public static IReadOnlyList<T> Skip<T>(IReadOnlyList<T> list, int n)
        {
            return Subarray(list, n, list.Count - n);
        }

        /// <summary>
        /// Creates a new list by taking the first n items of the list 
        /// </summary>
        public static IReadOnlyList<T> Take<T>(IReadOnlyList<T> list, int n)
        {
            return Subarray(list, 0, n);
        }

        /// <summary>
        /// Creates a new list from the last n items in a list
        /// </summary>
        public static IReadOnlyList<T> TakeLast<T>(IReadOnlyList<T> list, int n)
        {
            return Subarray(list, list.Count - n, n);
        }

        /// <summary>
        /// Creates a new list without the last n items
        /// </summary>
        public static IReadOnlyList<T> Drop<T>(IReadOnlyList<T> list, int n)
        {
            return Subarray(list, 0, list.Count - n);
        }

        /// <summary>
        /// Returns true if the value is contained in the list 
        /// </summary>
        public static bool Contains<T>(IReadOnlyList<T> list, T value)
        {
            return IndexOf(list, value) >= 0;
        }

        /// <summary>
        /// Returns the index of the minimum item in a list 
        /// </summary>
        public static int IndexOfMin<T>(IReadOnlyList<T> list) where T : IComparable<T>
        {
            if (list.Count == 0) return -1;
            var r = 0;
            for (var i = 1; i < list.Count; ++i)
                if (list[i].CompareTo(list[r]) < 0)
                    r = i;
            return r;
        }

        /// <summary>
        /// Returns the index of the maximum item in a list 
        /// </summary>
        public static int IndexOfMax<T>(IReadOnlyList<T> list) where T : IComparable<T>
        {
            if (list.Count == 0) return -1;
            var r = 0;
            for (var i = 1; i < list.Count; ++i)
                if (list[i].CompareTo(list[r]) > 0)
                    r = i;
            return r;
        }

        /// <summary>
        /// Returns elements which have a count of exactly one
        /// </summary>
        public static IReadOnlyList<T> UniqueElements<T>(IReadOnlyList<T> list)
        {
            return Filter(list, x => Count(list, x) == 1);
        }

        /// <summary>
        /// Creates a copy of a list that contains a new element inserted at the specified position. 
        /// </summary>
        public static IReadOnlyList<T> InsertElement<T>(IReadOnlyList<T> list, T element, int index)
        {
            return InsertElements(list, new[] { element }, index);
        }

        /// <summary>
        /// Creates a copy of a  list that contains the range inserted at the specified position. 
        /// </summary>
        public static IReadOnlyList<T> InsertElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> range, int index)
        {
            var prefix = Take(list, index);
            var tmp = AddElements(prefix, range);
            var suffix = Skip(list, index);
            return AddElements(tmp, suffix);
        }

        /// <summary>
        /// Creates a copy of a list that does not have the element at the specified position. 
        /// </summary>
        public static IReadOnlyList<T> RemoveAt<T>(IReadOnlyList<T> list, int index)
        {
            return RemoveRange(list, index, 1);
        }

        /// <summary>
        /// Returns all elements except those are equal to the element 
        /// </summary>
        public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, T element)
        {
            return Filter(list, x => !x.Equals(element));
        }

        /// <summary>
        /// Returns all elements except those are in the second collection
        /// </summary>
        public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> elements)
        {
            return Filter(list, x => !Contains(elements, x));
        }

        /// <summary>
        /// Creates a copy of a list that removes a range from the specified location 
        /// </summary>
        public static IReadOnlyList<T> RemoveRange<T>(IReadOnlyList<T> list, int index, int count)
        {
            return Filter(list, (x, i) => i < index || i >= index + count);
        }

        /// <summary>
        /// Adds a single item to the end of a list 
        /// </summary>
        public static IReadOnlyList<T> AddElement<T>(IReadOnlyList<T> list, T element)
        {
            return AddElements(list, new[] { element });
        }

        /// <summary>
        /// Concatenates two lists. 
        /// </summary>
        public static IReadOnlyList<T> AddElements<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            var r = new List<T>();
            foreach (var x in list1) r.Add(x);
            foreach (var x in list2) r.Add(x);
            return r;
        }

        /// <summary>
        /// Merges two lists that are sorted maintaining sorted order. 
        /// </summary>
        public static IReadOnlyList<T> SortedMerge<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2) where T : IComparable<T>
        {
            var i = 0;
            var j = 0;
            var r = new List<T>();

            // Either i or j is incremented each time
            while (i < list1.Count && j < list2.Count)
            {
                if (list1[i].CompareTo(list2[j]) < 0)
                {
                    r.Add(list1[i++]);
                }
                else
                {
                    r.Add(list2[j++]);
                }
            }

            // Add remainder of list1
            for (; i < list1.Count; ++i)
                r.Add(list1[i]);

            // Add remainder of list2
            for (; j < list2.Count; ++j)
                r.Add(list1[j]);
            
            return r;
        }

        /// <summary>
        /// Create a list copy by reversing elements in a list. 
        /// </summary>
        public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list)
        {
            var r = new List<T>();
            for (var i = list.Count - 1; i >= 0; --i)
                r.Add(list[i]);
            return r;
        }

        /// <summary>
        /// Creates a list by reversing elements within a range of elements 
        /// </summary>
        public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list, int start, int count)
        {
            var a = Take(list, start);
            var b = Subarray(list, start, count);
            var c = Skip(list, start + count);
            return AddElements(AddElements(a, Reverse(b)), c);
        }

        /// <summary>
        /// Returns a list containing count elements from the original list starting at start
        /// </summary>
        public static IReadOnlyList<T> Subarray<T>(IReadOnlyList<T> list, int start, int count)
        {
            return Filter(list, (x, i) => i >= start && i < start + count);
        }

        /// <summary>
        /// Sorts a list (use any sort algorithm you want).
        /// </summary>
        public static IReadOnlyList<T> Sort<T>(IReadOnlyList<T> list) where T : IComparable<T>
        {
            if (list.Count <= 1)
                return list;
            var mid = list.Count / 2;
            var prefix = Sort(Take(list, mid));
            var suffix = Sort(Skip(list, mid));
            return SortedMerge(prefix, suffix);
        }

        /// <summary>
        /// Sorts a list (use any sort algorithm you want).
        /// </summary>
        public static void SortInPlace<T>(IList<T> list) where T : IComparable<T>
        {
            for (var i = 0; i < list.Count; ++i)
            {
                for (var j = i + 1; j < list.Count; ++j)
                {
                    if (list[i].CompareTo(list[j]) < 0)
                    {
                        Helpers.SwapInPlace(list, i, j);
                    }
                }
            }
        }

        /// <summary>
        /// Creates a new list by applying a transform function to each item in the list.
        /// </summary>
        public static IReadOnlyList<T1> Transform<T0, T1>(IReadOnlyList<T0> list, Func<T0, T1> transformer)
        {
            var r = new List<T1>();
            foreach (var x in list)
                r.Add(transformer(x));
            return r;
        }

        /// <summary>
        /// Creates a new list containing all items for which the predicate returns true. 
        /// </summary>
        public static IReadOnlyList<T> Filter<T>(IReadOnlyList<T> list, Func<T, bool> predicate)
        {
            return Filter(list, (x, i) => predicate(x));
        }

        public static IReadOnlyList<T> Filter<T>(IReadOnlyList<T> list, Func<T, int, bool> predicate)
        {
            var r = new List<T>();
            for (var i=0; i < list.Count; ++i) 
                if (predicate(list[i], i))
                    r.Add(list[i]);
            return r;
        }
    }
}
