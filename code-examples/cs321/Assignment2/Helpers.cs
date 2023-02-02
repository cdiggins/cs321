namespace Assignment2;

/// <summary>
/// Some of these helper functions are going to be especially useful later
/// when you have to write your own sorting algorithms.
/// </summary>
public static class Helpers
{
    /// <summary>
    /// Returns true if the first element is less than or equal to the second, in other wise they are in ascending order
    /// </summary>
    public static bool IsLessThanOrEqualTo<T>(T first, T second) where T : IComparable<T>
        => first.CompareTo(second) <= 0;

    /// <summary>
    /// Returns the two items in ascending order
    /// </summary>
    public static (T, T) Sort<T>(T first, T second) where T : IComparable<T>
        => IsLessThanOrEqualTo(first, second) ? (first, second) : (second, first);

    /// <summary>
    /// Swaps the items in the list.  
    /// </summary>
    public static void SwapInPlace<T>(IList<T> list, int index1, int index2)
        => (list[index1], list[index2]) = (list[index2], list[index1]);

    /// <summary>
    /// Returns the nth element counting from the end 
    /// </summary>
    public static T NthElementFromEnd<T>(IReadOnlyList<T> list, int n)
        => list[list.Count - 1 - n];
    
    /// <summary>
    /// Returns true if the first element is the same as the last element,
    /// and the nth item is the same as the nth last element. 
    /// </summary>
    public static bool IsPalindrome<T>(IReadOnlyList<T> list)
    {
        for (var i=0; i < list.Count/2; ++i)
            if (!list[i].Equals(NthElementFromEnd(list, i)))
                return false;
        return true;
    }
}