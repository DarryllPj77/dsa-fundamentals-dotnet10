namespace DSA.Fundamentals.Examples.Algorithms;

public static class SearchingExamples
{
    public static int LinearSearch(int[] values, int target)
    {
        for (var i = 0; i < values.Length; i++)
        {
            if (values[i] == target)
            {
                return i;
            }
        }

        return -1;
    }
}
