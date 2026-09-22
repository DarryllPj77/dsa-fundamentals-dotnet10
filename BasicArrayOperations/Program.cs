using System.Data;

namespace BasicArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Array Operations");

            // Find the Sum and average

            int[] numbers = { 22, 10, 33, 9, 55 };

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("Find the sum and average");
            Console.WriteLine($"Total average: {sum}");

            // Find the highest and lowest value

            // local variable
            int minNum = numbers[0]; // use default the value of the index instead of only 0
            int maxNum = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }

                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }

            Console.WriteLine($"\nHigest Values: {maxNum}");
            Console.WriteLine($"\nLowest Values: {minNum}");


            // Count the matching values 

            int[] dubArray = { 11, 22, 11, 22, 9, 4, 5, 6, 7, 11, 9, 77, 9 };

            int targetValue1 = 11;
            int targetValue2 = 9;
            int matchCount1 = 0;
            int matchCount2 = 0;

            for (int i = 0; i < dubArray.Length; i++)
            {
                if (dubArray[i] == targetValue1)
                {
                    matchCount1++;
                }

                if (dubArray[i] == targetValue2)
                {
                    matchCount2++;
                }
            }

            Console.WriteLine($"\nNumber of match value: {matchCount1} for 11");
            Console.WriteLine($"\nNumber of match value: {matchCount1} for 9");

            // Copy an Array 

            int[] original = { 10, 30, 20, 40, 60 };

            int[] copyArray = new int[original.Length];

            for (int i = 0; i < copyArray.Length; i++)
            {
                copyArray[i] = original[i];
            }

            Console.WriteLine("Copied Array: ");
            foreach (var copied in copyArray)
            {
                Console.WriteLine(copied);
            }

            // Reversed Copy Array
            Console.WriteLine("\nReversed Copy Array");
            for (int i = 0; i < copyArray.Length; i++)
            {
                copyArray[i] = original[copyArray.Length - i - 1];
            }

            foreach (var copied in copyArray)
            {
                Console.WriteLine(copied);
            }

            // Check whether a value exists (Linear Search)

            int[] arrayList = { 1, 5, 4, 3, 6, 11, 10, 20, 40, 77, 66 };

            int targetValue = 40;

            bool isFound = false;

            int valueIndex = arrayList[0];

            Console.WriteLine("\nValue Checker");
            for (int i = 0; i < arrayList.Length; i++)
            {
                if (arrayList[i] == targetValue)
                {
                    isFound = true; // if found the target value
                    valueIndex = i;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"The Target found, value is on index : {valueIndex}");
            }
            else
            {
                Console.WriteLine("Target not found");
            }
        }
    }
}
    