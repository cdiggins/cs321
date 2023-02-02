namespace Assignment2;

/// <summary>
/// These helper functions are going to be useful later when you have to write your own sorting algorithms.
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

}