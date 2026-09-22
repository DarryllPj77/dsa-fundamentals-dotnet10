namespace SolvingOneDimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Traversal");

            // How to visit every element using foreach, for, while

            int[] numbers = { 10, 20, 30, 40, 50 };

            // Foreach

            Console.WriteLine("Using Foreach for Array Traversal");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            // For
            Console.WriteLine("\nUsing For for Array Traversal");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // While
            Console.WriteLine("\nUsing While for Array Traversal");
            int num = 0;
            while (num < numbers.Length)
            {
                Console.Write(numbers[num] + " ");
                num++;
            }

            
        }
    }
} 
