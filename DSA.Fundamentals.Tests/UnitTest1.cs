using DSA.Fundamentals.Examples.Algorithms;
using DSA.Fundamentals.Examples.Arrays;
using DSA.Fundamentals.Examples.LinkedList;
using DSA.Fundamentals.Examples.Lists;
using DSA.Fundamentals.Examples.Queue;
using DSA.Fundamentals.Examples.Stack;

namespace DSA.Fundamentals.Tests;

public class UnitTest1
{
    [Fact]
    public void ListExample_ReturnsExpectedValues()
    {
        Assert.Equal([1, 2, 3], ListExamples.CreateNumberList());
    }

    [Fact]
    public void ArrayExample_ReverseCopy_ReturnsReversedValues()
    {
        Assert.Equal([3, 2, 1], ArrayExamples.ReverseCopy([1, 2, 3]));
    }

    [Fact]
    public void LinkedListExample_ReturnsExpectedWords()
    {
        Assert.Equal(["alpha", "beta", "gamma"], LinkedListExamples.CreateWords());
    }

    [Fact]
    public void StackExample_PopTop_ReturnsTopValue()
    {
        var stack = new System.Collections.Generic.Stack<int>([1, 2, 3]);

        Assert.Equal(3, StackExamples.PopTop(stack));
    }

    [Fact]
    public void QueueExample_PeekFront_ReturnsFrontValue()
    {
        var queue = new System.Collections.Generic.Queue<int>([1, 2, 3]);

        Assert.Equal(1, QueueExamples.PeekFront(queue));
    }

    [Fact]
    public void SortingExample_BubbleSortAscending_ReturnsSortedValues()
    {
        Assert.Equal([1, 2, 3, 4, 5], SortingExamples.BubbleSortAscending([5, 4, 3, 2, 1]));
    }

    [Fact]
    public void SearchingExample_LinearSearch_ReturnsExpectedIndex()
    {
        Assert.Equal(2, SearchingExamples.LinearSearch([10, 20, 30], 30));
        Assert.Equal(-1, SearchingExamples.LinearSearch([10, 20, 30], 99));
    }
}
