using DSA.Fundamentals.Examples.Algorithms;

var data = new[] { 5, 2, 4, 1, 3 };
var sorted = SortingExamples.BubbleSortAscending(data);

Console.WriteLine($"Sorted sample: {string.Join(", ", sorted)}");
