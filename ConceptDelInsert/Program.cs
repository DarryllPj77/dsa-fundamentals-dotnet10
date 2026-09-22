namespace ConceptDelInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simple console program that demonstrates manual deletion and insertion
            // in a fixed-size array by creating a new array and copying elements.
            // This is educational code; in real applications use List<T> for
            // dynamic insertion/removal.
            Console.WriteLine("Concept of Deletion and Insertion in Array");


            // ----------------------
            // Concept of Deletion
            // ----------------------
            // Original array with indexes shown for clarity:
            //                 0   1   2   3   4
            int[] original = { 10, 20, 30, 40, 50 };
            // The index of the element we want to remove (third element, value 30)
            int indexToDelete = 2;

            // Create a new array with one fewer slot to hold the result
            int[] newArray = new int[original.Length - 1]; // newArray length = 4

            int newIndex = 0; // position to write into newArray

            // Copy all elements except the one at indexToDelete
            for (int i = 0; i < original.Length; i++)
            {
                // Skip the element at the deletion index
                if (i != indexToDelete)
                {
                    newArray[newIndex] = original[i];
                    newIndex++;
                }
            }

            // Print resulting array after deletion
            Console.WriteLine("\nDeletion");
            foreach (var newA in newArray)
            {
                Console.WriteLine(newA);
            }

            Console.WriteLine("Original Array");
            foreach (var newA in original)
            {
                Console.WriteLine(newA);
            }

            // ----------------------
            // Concept of Insertion
            // ----------------------
            // Original array before insertion:
            //                  0   1   2   3   4
            int[] original2 = { 10, 20, 30, 40, 50 };

            // We will insert a value at this index (inserting before index 3)
            int indexToInsert = 3;

            // Value to insert into the array
            int valueToInsert = 70;

            // New array is one element larger to accommodate the inserted value
            int[] newArray2 = new int[original2.Length + 1];

            // Iterate over the new array indexes and decide whether to copy from
            // the original array or place the new value.
            for (int i = 0; i < newArray2.Length; i++)
            {
                if (i < indexToInsert)
                {
                    // Before the insertion index: copy directly from original
                    newArray2[i] = original2[i];
                }
                else if (i == indexToInsert)
                {
                    // At the insertion index: place the new value
                    newArray2[i] = valueToInsert;
                }
                else
                {
                    // After insertion index: shift elements from original by -1
                    newArray2[i] = original2[i - 1];
                }
            }

            Console.WriteLine("\nInsertion");
            foreach (var newA in newArray2)
            {
                Console.WriteLine(newA);
            }

            Console.WriteLine("Original Array");
            foreach (var newA in original2)
            {
                Console.WriteLine(newA);
            }


            // Challenge focusing on insertion, deletion, and shifting. 

            // Problem 1 : Delete the first Element

            int[] prob1 = { 10, 20, 30, 40, 50 };

            int targetIndex = 0;

            int[] newArrayProb1 = new int[prob1.Length - 1];

            int newIndexProb1 = 0;

            for (int i = 0; i < prob1.Length; i++)
            {
                if(i != targetIndex)
                {
                    newArrayProb1[newIndexProb1] = prob1[i];
                    newIndexProb1++;
                }
            }

            Console.WriteLine("\nChallenge 1: ");
            foreach (var arr in newArrayProb1)
            {
                Console.Write(arr + " ");
            }

            // Problem 2 : Insert At the Beginning 
            Console.WriteLine("\nChallenge 2:");
            int[] prob2 = { 10, 30, 40, 50, 60 };

            int targetIndexProb2 = 0;

            int[] newArrayProb2 = new int[prob2.Length + 1];

            int valueToInsertProb2 = 70;

            int count1 = 1;

            for (int i = 0; i < newArrayProb2.Length; i++)
            {
                if (i < targetIndexProb2)
                {
                    newArrayProb2[i] = prob2[i];
                }
                else if(i == targetIndexProb2)
                {
                    newArrayProb2[i] = valueToInsertProb2;
                }
                else
                {
                    newArrayProb2[i] = prob2[i - 1];
                }

                Console.Write($"Iteration, i = {count1++}: ");
                foreach (var arr in newArrayProb2)
                {
                    Console.Write(arr + " ");
                }

                Console.WriteLine();
            }

            //Console.WriteLine("\nChallenge 2: ");
            //foreach (var arr in newArrayProb2)
            //{
            //    Console.Write(arr + " ");
            //}

            // Challenge 3 : Shift Left
            Console.WriteLine("\nChallenge 3:");

            //              0   1   2   3   4
            int[] prob3 = { 10, 30, 40, 50, 60 };
            int count2 = 0;
            int temp = prob3[0];

            for (int i = 0; i < prob3.Length - 1; i++)
            {
                prob3[i] = prob3[i + 1];

                Console.Write($"Iteration, i = {count2++}: ");
                foreach (var arr in prob3)
                {
                    Console.Write(arr + " ");
                }
                Console.WriteLine();
            }

            prob3[prob3.Length - 1] = temp; 

            Console.WriteLine("\nChallenge 3");
            foreach (var item in prob3)
            {
                Console.WriteLine(item);
            }



        }
    }
}
