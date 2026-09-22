namespace DSA.Fundamentals.Examples.Algorithms;

public static class SortingExamples
{
    public static int[] BubbleSortAscending(int[] values)
    {
        var result = (int[])values.Clone();
        for (var i = 0; i < result.Length - 1; i++)
        {
            for (var j = 0; j < result.Length - i - 1; j++)
            {
                if (result[j] > result[j + 1])
                {
                    (result[j], result[j + 1]) = (result[j + 1], result[j]);
                }
            }
        }

        return result;
    }
}
