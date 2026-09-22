using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayOneDimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examples use cases of One Dimensional Arrays");

            // A one-dimensional array stores values in a single sequence. You access each value using one index.

            // 1. Integer array (int[])
            int[] scores = { 85, 90, 95, 75 };

            Console.Write("Values for index 0: ");
            Console.WriteLine(scores[0]);

            /*
            Use cases:

            Student scores
            Ages
            Product quantities
            Employee IDs
            Counting values
             */

            // 2.Decimal - number arrays
            // Stores numbers with decimal parts.

            double[] temperatures = { 29.5, 31.2, 30.8 };
            decimal[] prices = { 99.50m, 150.00m, 75.25m };

            Console.Write("\nTemperature in index 2: ");
            Console.WriteLine(temperatures[2]);

            Console.Write("\nPrice in index 1: ");
            Console.WriteLine(prices[1]);


            /*
            Use cases:

            double[] for measurements and scientific calculations
            decimal[] for prices and financial values
             */

            // 3. String array (string[])
            // Store Text

            string[] studentNames =
            {
                "Darryll J. Pajaganas",
                "Celeine Andrei Pike",
                "Mochi Pike"
            };

            // Use foreach to display all the values in studentNames

            Console.WriteLine("\nStudent Names: ");
            foreach (var student in studentNames)
            {
                Console.WriteLine(student + " ");
            }

            /*
            Use cases:

            Names
            Cities
            Product names
            Search keywords
            Menu options
             */

            // 4. Character array (char[])
            // Stores individual characters.

            char[] vowels = { 'A', 'B', 'C', 'D' };

            Console.WriteLine("\nVowels:");
            foreach (var letter in vowels)
            {
                Console.Write(letter + " ");
            }

            /*
            Use cases:

            Examining characters in text
            Checking letters
            Simple text-processing algorithms
            Storing symbols
            */

            // 5. Boolean array (bool[])
            // Store true or false

            bool[] attendance =
            {
                true, // 0
                false, // 1
                true, // 2
                true, // 3
                false // 4
            };

            Console.WriteLine("\nExample of Boolean for Array");
            if (attendance[2] == false)
            {
                Console.WriteLine("The Student is Abasent!");
            }
            else
            {
                Console.WriteLine("The Student is Present!");
            }


            // 6. Object array
            //Stores reference to objects created from a class

            //Student[] students =
            //{
            //    new Student { Name = "Darryll", Age = "22"},
            //    new Student { Name = "Darryll", Age = "22"}
            //};

            /*
            Use cases:

            Students in a directory
            Employees in a company
            Products in a store
            Books in a library
             */

            //Common Real World Problems

            // Examples of Linear Search

            // 1. Searching for Values
            int[] numbers = { 10, 25, 30, 35, 40 };
            int target = 30;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] == target)
                {
                    Console.WriteLine($"Found at index {index}");
                    break;
                }
            }

            //Finding the largest value
            int[] scoresM = { 85, 79, 94, 98 };
            int highest = scoresM[0];

            foreach (var score in scoresM)
            {
                if(score > highest)
                {
                    highest = score;
                }
            }

            Console.WriteLine($"\nHighest Score: {highest}");
        }
    }
}
