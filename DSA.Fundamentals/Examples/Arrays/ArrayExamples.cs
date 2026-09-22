namespace DSA.Fundamentals.Examples.Arrays;

public static class ArrayExamples
{
    public static int[] ReverseCopy(int[] source)
    {
        var copy = (int[])source.Clone();
        Array.Reverse(copy);
        return copy;
    }
}
