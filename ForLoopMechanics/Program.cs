namespace ForLoopMechanics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manipulation of For Loop");

            // Problem 1: The Countdown (Backwards)

            //  for ( 1. Where to start ; 2. When to stop ; 3. Which direction to step )
            //  int[] numbers = { 10, 20, 30, 40, 50 };
            //                //4
            //  for (int i = numbers.Length - 1; i >= 0; i--)
            //  {
            //      Console.WriteLine(numbers[i]);
            //  }

            // Problem 2: The Middle Man (Skip the edges)

            //  int[] numbers = { 10, 20, 30, 40, 50 };

            //  for (int i = 1; i < numbers.Length - 1; i++)
            //  {
            //      Console.WriteLine(numbers[i]);
            //  }

            // Problem 3: The Frog Jump (Custom Step)

            int[] numbers = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < numbers.Length; i += 2)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
