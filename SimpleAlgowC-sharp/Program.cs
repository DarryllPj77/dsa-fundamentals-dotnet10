using System.Diagnostics;
using System.Numerics;

namespace SimpleAlgowC_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a Simple/Basic Algorithm");

            // 1. Bubble Sort

            /*int[] numbers = { 40, 10, 50, 20, 30 };

            //int temp = 0; // no need for this since we already declared in on the inner loop

            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Complete bubble sort
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int i = 0; i < numbers.Length - 1 - j; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                    }
                }
            }

            // Single Pass bubble sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    
                }
            }

            Console.WriteLine("Bubble Sort Output: ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            timer.Stop();
            Console.WriteLine("\nAlgorithm finished in: " + timer.ElapsedMilliseconds + " milliseconds");
            */

            // 2. Binary Search

            /*int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 };
            int numberToFind = 120;
            int foundIndex = -1;


            int left = 0;
            int right = numbers.Length - 1;
            int mid = 0;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if(numbers[mid] == numberToFind)
                {
                    foundIndex = mid;
                    break;
                }
                else if (numbers[mid] < numberToFind)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine($"The value is found at index: {foundIndex} with value of {numbers[foundIndex]}");*/


            // Bubble Sort for sorting and unsorted array
            //

            //            i=   0   1   2  3  4  5  6  7
            int[] numbers = { 30, 20, 7, 8, 4, 3, 2, 27 };
            int passCount = 1;

            for (int j = 0; j < numbers.Length - 1; j++)
            {
                Console.WriteLine($"\n=== STARTING PASS {passCount} ===");
                int iterationCount = 1; // Reset iteration count for each new pass

                for (int i = 0; i < numbers.Length - 1 - j; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        // SWAP
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        Console.Write($"  Iteration {iterationCount} (SWAPPED) : ");
                    }
                    else
                    {
                        Console.Write($"  Iteration {iterationCount} (No swap) : ");
                    }

                    // Print the array after this specific iteration
                    foreach (var num in numbers)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine(); // Just to move to the next line

                    iterationCount++;
                }

                // THE NOTIFICATION: The inner loop is done, so the pass is complete!
                Console.WriteLine($"-> PASS {passCount} COMPLETE! The highest number for this pass is now locked in position.");
                passCount++;
            }

            //Console.WriteLine("Sorted Array: ");
            //foreach (var num in numbers)
            //{
            //    Console.Write(num + " ");
            //}



        }
    }
}
