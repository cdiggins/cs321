
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
    public static class ListOperations
    {
        /// <summary>
        /// Returns true if the list is in ascending order, false otherwise. 
        /// </summary>
        public static bool IsSorted<T>(IReadOnlyList<T> xs) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the section of list is in ascending order, false otherwise. 
        /// </summary>
        public static bool IsSorted<T>(IReadOnlyList<T> list, int from, int count) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the number of times the character occurs in the list 
        /// </summary>
        public static int Count<T>(IReadOnlyList<T> list, T element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the two collections are the same
        /// </summary>
        public static bool ListEquals<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the second collection is the same as the second in reverse order. 
        /// </summary>
        public static bool IsReversed<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the second collection is the same as the first sequence starting from index in reverse order. 
        /// </summary>
        public static bool IsReversed<T>(IReadOnlyList<T> list1, int index, IReadOnlyList<T> list2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the collection starts with the specified elements 
        /// </summary>
        public static bool StartsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> prefix)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the collection ends with the specfied elements 
        /// </summary>
        public static bool EndsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> suffix)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the index of the first occurence of the specified value, or -1 if it is not found. 
        /// </summary>
        public static int IndexOf<T>(IReadOnlyList<T> list, T value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the last index of the first occurence of the specified sublist, or -1 if it is not found. 
        /// </summary>
        public static int LastIndexOf<T>(IReadOnlyList<T> list, T value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new list by skipping the first n items of a list 
        /// </summary>
        public static IReadOnlyList<T> Skip<T>(IReadOnlyList<T> list, int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new list by taking the first n items of the list 
        /// </summary>
        public static IReadOnlyList<T> Take<T>(IReadOnlyList<T> list, int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new list from the last n items in a list
        /// </summary>
        public static IReadOnlyList<T> TakeLast<T>(IReadOnlyList<T> list, int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new list without the last n items
        /// </summary>
        public static IReadOnlyList<T> Drop<T>(IReadOnlyList<T> list, int n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns true if the value is contained in the list 
        /// </summary>
        public static bool Contains<T>(IReadOnlyList<T> list, T value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the index of the minimum item in a list 
        /// </summary>
        public static int IndexOfMin<T>(IReadOnlyList<T> list) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the index of the maximum item in a list 
        /// </summary>
        public static int IndexOfMax<T>(IReadOnlyList<T> list) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns elements which have a count of exactly one
        /// </summary>
        public static IReadOnlyList<T> UniqueElements<T>(IReadOnlyList<T> list)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a copy of a list that contains a new element inserted at the specified position. 
        /// </summary>
        public static IReadOnlyList<T> InsertElement<T>(IReadOnlyList<T> list, T element, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a copy of a  list that contains the range inserted at the specified position. 
        /// </summary>
        public static IReadOnlyList<T> InsertElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> range, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a copy of a list that does not have the element at the specified position. 
        /// </summary>
        public static IReadOnlyList<T> RemoveAt<T>(IReadOnlyList<T> list, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all elements except those are equal to the element 
        /// </summary>
        public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, T element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all elements except those are in the second collection
        /// </summary>
        public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> elements)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a copy of a list that removes a range from the specified location 
        /// </summary>
        public static IReadOnlyList<T> RemoveRange<T>(IReadOnlyList<T> list, int index, int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a single item to the end of a list 
        /// </summary>
        public static IReadOnlyList<T> AddElement<T>(IReadOnlyList<T> list, T element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Concatenates two lists. 
        /// </summary>
        public static IReadOnlyList<T> AddElements<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Merges two lists that are sorted maintaining sorted order. 
        /// </summary>
        public static IReadOnlyList<T> SortedMerge<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a list copy by reversing elements in a list. 
        /// </summary>
        public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a list by reversing elements within a range of elements 
        /// </summary>
        public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list, int start, int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a list containing count elements from the original list starting at start
        /// </summary>
        public static IReadOnlyList<T> Subarray<T>(IReadOnlyList<T> list, int start, int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sorts a list (use any sort algorithm you want).
        /// </summary>
        public static IReadOnlyList<T> Sort<T>(IReadOnlyList<T> list) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sorts a list (use any sort algorithm you want).
        /// </summary>
        public static void SortInPlace<T>(IList<T> list) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new list by applying a transform function to each item in the list.
        /// </summary>
        public static IReadOnlyList<T1> Transform<T0, T1>(IReadOnlyList<T0> list, Func<T0, T1> transformer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new list containing all items for which the predicate returns true. 
        /// </summary>
        public static IReadOnlyList<T> Filter<T>(IReadOnlyList<T> list, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }

}
