using System.Diagnostics;

namespace ChallengeDelInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Challenge for Deletion and Insertion Concept");


            //Problem 1: Append(Add to the very end)
            //You want to add a new number to the very end of an array.You'll need to create a new array that is 1 size larger.
            //Goal: Turn { 5, 10, 15 } -> into { 5, 10, 15, 20 }.

            /*
            int[] original = { 5, 10, 15 };
            int valueToAdd = 20;

            int[] newArray = new int[original.Length + 1]; // used this since we are inserting a new value

            for (int i = 0; i < original.Length; i++)
            {
                newArray[i] = original[i];
            }

            // newArray length = 4 size
            newArray[newArray.Length - 1] = valueToAdd; // putting the valueToAdd to index 3

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            */

            // 1. Create a larger array
            // 2. Loop and copy the original numbers
            // 3. Put the new value in the very last slot


            //Problem 2: Delete the Last Element
            //The opposite of Problem 1.Remove the last number by creating a smaller array.
            //Goal: Turn { 10, 20, 30, 40, 50 } -> into { 10, 20, 30, 40 }.
            //Hint: Your loop condition should be based on the length of the new, smaller array.

            //                 0   1   2   3   4

            /*int[] original = { 10, 20, 30, 40, 50 };

            int[] newArray = new int[original.Length - 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = original[i];
            }

            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            */

            // 1. Create a smaller array
            // 2. Loop and copy the numbers over

            //Problem 3: Swap Two Elements(In - Place)
            //Before we learn sorting, you need to know how to swap two items inside the exact same array.
            //Goal: Swap the number at index 1 with the number at index 3.The array should become { 10, 40, 30, 20, 50 }.
            //Hint: You don't need a for loop for this! You just need a temp variable to hold one of the numbers while you overwrite it.

            /*int[] numbers = { 10, 20, 30, 40, 50 };
            int indexA = 1; // The '20'
            int indexB = 3; // The '40'

            int temp = numbers[indexA];

            numbers[indexA] = numbers[indexB];
            numbers[indexB] = temp;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            */
            // Write the logic to swap them here using a temp variable!

            //Problem 4: Shift Right(In-Place Rotation)
            //This is the evil twin of the "Shift Left" challenge you already solved.
            //You want to shift everything to the right, and the last number wraps around to the front.
            //Goal: Turn { 10, 20, 30, 40, 50 } into { 50, 10, 20, 30, 40 }.
            //Hint: If you start at index 0 and copy forward(numbers[1] = numbers[0]), you'll overwrite the 20, and then copy 10 again, making {10, 10, 10...}.
            //To shift right without destroying your data, your for loop must run backwards! (e.g., for (int i = numbers.Length - 1; i > 0; i--)).
            //Don't forget to save the last element in a temp variable first!

            //                0   1   2   3   4
            /*int[] numbers = { 10, 20, 30, 40, 50 };


            int lastIndex = 4;
            int temp = numbers[lastIndex];

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
            }

            numbers[0] = temp;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            */



            // 1. Save the very last number in a temp variable
            // 2. Write a backwards for-loop to shift numbers to the right
            // 3. Put the temp variable into index 0

            // Problem 5: Delete by Value (Instead of Index)

            /*int[] original = { 10, 20, 30, 40, 50 };
             int valueToDelete = 30;

             int[] newArray = new int[original.Length - 1];

             int newIndex = 0;

             for (int i = 0; i < original.Length; i++)
             {
                 if (original[i] != valueToDelete)
                 {
                     newArray[newIndex] = original[i];
                     newIndex++;
                 }
             }
             Console.WriteLine("Problem 5: ");
             foreach (var arr in newArray)
             {
                 Console.Write(arr + " ");
             }
            */

            // Problem 6: Search and Replace

            /*int[] numbers = { 10, 20, 30, 40, 30, 40, 30, 80, 30 };

            int targetValue = 30;
            int replacementValue = 99;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == targetValue)
                {
                    numbers[i] = replacementValue;
                }
            }

            Console.WriteLine("Problem 6: ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            */

            // Problem 7: The Reverse Copy

            //                 0   1   2   3   4
            /*int[] original = { 10, 20, 30, 40, 50 };

            int[] newArray = new int[original.Length];

            int newIndex = 0;

            for (int i = original.Length - 1; i >= 0; i--)
            {
                newArray[newIndex] = original[i];
                newIndex++;
            }


            Console.WriteLine("Problem 7: ");
            foreach (var arr in newArray)
            {
                Console.Write(arr + " ");
            }*/

            // Problem 8: The Detective (Linear Search)

            //                0   1   2   3   4   5
            /*int[] numbers = { 10, 20, 30, 40, 50, 60 };

            int numberToFind = 30;

            int foundIndex = -1; // default for null-like place holder

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToFind)
                {
                    foundIndex = i;
                }
            }

            Console.WriteLine("The number is at index: " + foundIndex);
            */

            /*int[] numbers = { 25, 26, 38, -29, 27, 30 };

            int maxNum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
            }

            Console.WriteLine("Max number: " + maxNum);
            */


            // Problem 9: Single Pass of Bubble Sort

            int[] numbers = { 40, 10, 50, 20, 30 };

            //int temp = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Complete bubble sort
            for (int j = 0; j < numbers.Length; j++)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
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
            /*for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    
                }
            }*/

            Console.WriteLine("Bubble Sort Output: ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            timer.Stop();
            Console.WriteLine("\nAlgorithm finished in: " + timer.ElapsedMilliseconds + " milliseconds");
        }
    }
}
