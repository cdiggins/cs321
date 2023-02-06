namespace Assignment2;

public static class ListOperationsReference
{
    /// <summary>
    /// Returns true if the list is in ascending order, false otherwise. 
    /// </summary>
    public static bool IsSorted<T>(IReadOnlyList<T> list) where T : IComparable<T>
    {
        return list
            .Select((x, i) => i == 0 || x.CompareTo(list[i - 1]) >= 0)
            .All(x => x);
    }

    /// <summary>
    /// Returns true if the section of list is in ascending order, false otherwise. 
    /// </summary>
    public static bool IsSorted<T>(IReadOnlyList<T> list, int from, int count) where T : IComparable<T>
    {
        return list
            .Select((x, i) => i <= from || i >= from + count || x.CompareTo(list[i - 1]) >= 0)
            .All(x => x);
    }

    /// <summary>
    /// Returns the number of times the character occurs in the list 
    /// </summary>
    public static int Count<T>(IReadOnlyList<T> list, T element)
    {
        return list.Count(x => x.Equals(element));
    }

    /// <summary>
    /// Returns true if the two collections are the same
    /// </summary>
    public static bool ListEquals<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
    {
        return list1.SequenceEqual(list2);
    }

    /// <summary>
    /// Returns true if the second collection is the same as the first in reverse order. 
    /// </summary>
    public static bool IsReversed<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
    {
        return list1.SequenceEqual(list2.Reverse());
    }

    /// <summary>
    /// Returns true if the second collection is the same as the first sequence starting from index in reverse order. 
    /// </summary>
    public static bool IsReversed<T>(IReadOnlyList<T> list1, int index, IReadOnlyList<T> list2)
    {
        return list1.Skip(index).Take(list2.Count).SequenceEqual(list2.Reverse());
    }

    /// <summary>
    /// Returns true if the collection starts with the specified elements 
    /// </summary>
    public static bool StartsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> prefix)
    {
        return list.Count >= prefix.Count && list.Take(prefix.Count).SequenceEqual(prefix);
    }

    /// <summary>
    /// Returns true if the collection ends with the specfied elements 
    /// </summary>
    public static bool EndsWith<T>(IReadOnlyList<T> list, IReadOnlyList<T> suffix)
    {
        return list.Count >= suffix.Count && list.Skip(list.Count - suffix.Count).SequenceEqual(suffix);
    }

    /// <summary>
    /// Returns the index of the first occurrence of the specified value, or -1 if it is not found. 
    /// </summary>
    public static int IndexOf<T>(IReadOnlyList<T> list, T value)
    {
        return list.ToList().IndexOf(value);
    }

    /// <summary>
    /// Returns the last index of the first occurence of the specified sublist, or -1 if it is not found. 
    /// </summary>
    public static int LastIndexOf<T>(IReadOnlyList<T> list, T value)
    {
        return list.ToList().LastIndexOf(value);
    }

    /// <summary>
    /// Creates a new list by skipping the first n items of a list 
    /// </summary>
    public static IReadOnlyList<T> Skip<T>(IReadOnlyList<T> list, int n)
    {
        return list.Skip(n).ToList();
    }

    /// <summary>
    /// Creates a new list by taking the first n items of the list 
    /// </summary>
    public static IReadOnlyList<T> Take<T>(IReadOnlyList<T> list, int n)
    {
        return list.Take(n).ToList();
    }

    /// <summary>
    /// Creates a new list from the last n items in a list
    /// </summary>
    public static IReadOnlyList<T> TakeLast<T>(IReadOnlyList<T> list, int n)
    {
        return list.Skip(list.Count - n).ToList();
    }

    /// <summary>
    /// Creates a new list without the last n items
    /// </summary>
    public static IReadOnlyList<T> Drop<T>(IReadOnlyList<T> list, int n)
    {
        return list.Take(list.Count - n).ToList();
    }

    /// <summary>
    /// Returns true if the value is contained in the list 
    /// </summary>
    public static bool Contains<T>(IReadOnlyList<T> list, T value)
    {
        return list.Contains(value);
    }

    /// <summary>
    /// Returns the index of the minimum item in a list 
    /// </summary>
    public static int IndexOfMin<T>(IReadOnlyList<T> list) where T : IComparable<T>
    {
        return list.Count == 0 ? -1 : list.ToList().IndexOf(list.Min());
    }

    /// <summary>
    /// Returns the index of the maximum item in a list 
    /// </summary>
    public static int IndexOfMax<T>(IReadOnlyList<T> list) where T : IComparable<T>
    {
        return list.Count == 0 ? -1 : list.ToList().IndexOf(list.Max());
    }

    /// <summary>
    /// Returns elements which have a count of exactly one
    /// </summary>
    public static IReadOnlyList<T> UniqueElements<T>(IReadOnlyList<T> list)
    {
        return list.Where(x => list.Count(y => y.Equals(x)) == 1).ToList();
    }

    /// <summary>
    /// Creates a copy of a list that contains a new element inserted at the specified position. 
    /// </summary>
    public static IReadOnlyList<T> InsertElement<T>(IReadOnlyList<T> list, T element, int index)
    {
        return list.Take(index).Append(element).Concat(list.Skip(index)).ToList();
    }

    /// <summary>
    /// Creates a copy of a  list that contains the range inserted at the specified position. 
    /// </summary>
    public static IReadOnlyList<T> InsertElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> range, int index)
    {
        return list.Take(index).Concat(range).Concat(list.Skip(index)).ToList();
    }

    /// <summary>
    /// Creates a copy of a list that does not have the element at the specified position. 
    /// </summary>
    public static IReadOnlyList<T> RemoveAt<T>(IReadOnlyList<T> list, int index)
    {
        return list.Take(index).Concat(list.Skip(index + 1)).ToList();
    }

    /// <summary>
    /// Returns all elements except those are equal to the element 
    /// </summary>
    public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, T element)
    {
        return list.Where(x => !x.Equals(element)).ToList();
    }

    /// <summary>
    /// Returns all elements except those are in the second collection
    /// </summary>
    public static IReadOnlyList<T> RemoveElements<T>(IReadOnlyList<T> list, IReadOnlyList<T> elements)
    {
        return list.Where(x => !elements.Contains(x)).ToList();
    }

    /// <summary>
    /// Creates a copy of a list that removes a range from the specified location 
    /// </summary>
    public static IReadOnlyList<T> RemoveRange<T>(IReadOnlyList<T> list, int index, int count)
    {
        return list.Take(index).Concat(list.Skip(index + count)).ToList();
    }

    /// <summary>
    /// Adds a single item to the end of a list 
    /// </summary>
    public static IReadOnlyList<T> AddElement<T>(IReadOnlyList<T> list, T element)
    {
        return list.Append(element).ToList();
    }

    /// <summary>
    /// Concatenates two lists. 
    /// </summary>
    public static IReadOnlyList<T> AddElements<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2)
    {
        return list1.Concat(list2).ToList();
    }

    /// <summary>
    /// Merges two lists that are sorted maintaining sorted order. 
    /// </summary>
    public static IReadOnlyList<T> SortedMerge<T>(IReadOnlyList<T> list1, IReadOnlyList<T> list2) where T: IComparable<T>
    {
        return list1.Concat(list2).OrderBy(x => x).ToList();
    }

    /// <summary>
    /// Create a list copy by reversing elements in a list. 
    /// </summary>
    public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list)
    {
        return list.Reverse().ToList();
    }

    /// <summary>
    /// Creates a list by reversing elements within a range of elements 
    /// </summary>
    public static IReadOnlyList<T> Reverse<T>(IReadOnlyList<T> list, int start, int count)
    {
        return list.Take(start)
            .Concat(list.Skip(start).Take(count).Reverse())
            .Concat(list.Skip(start + count))
            .ToList();
    }

    /// <summary>
    /// Returns a list containing count elements from the original list starting at start
    /// </summary>
    public static IReadOnlyList<T> Subarray<T>(IReadOnlyList<T> list, int start, int count)
    {
        return list.Skip(start).Take(count).ToList();
    }

    /// <summary>
    /// Sorts a list (use any sort algorithm you want).
    /// </summary>
    public static IReadOnlyList<T> Sort<T>(IReadOnlyList<T> list) where T : IComparable<T>
    {
        return list.OrderBy(x => x).ToList();
    }

    /// <summary>
    /// Sorts a list (use any sort algorithm you want).
    /// </summary>
    public static void SortInPlace<T>(IList<T> list) where T : IComparable<T>
    {
        var tmp = list.OrderBy(x => x).ToList();
        for (var i=0; i < list.Count; ++i)
            list[i] = tmp[i];
    }
        
    /// <summary>
    /// Creates a new list by applying a transform function to each item in the list.
    /// </summary>
    public static IReadOnlyList<T1> Transform<T0, T1>(IReadOnlyList<T0> list, Func<T0, T1> transformer)
    {
        return list.Select(transformer).ToList();
    }

    /// <summary>
    /// Creates a new list containing all items for which the predicate returns true. 
    /// </summary>
    public static IReadOnlyList<T> Filter<T>(IReadOnlyList<T> list, Func<T, bool> predicate)
    {
        return list.Where(predicate).ToList();
    }
}