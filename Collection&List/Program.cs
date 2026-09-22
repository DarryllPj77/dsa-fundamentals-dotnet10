namespace Collection_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulation of Collection and List");

            var rowsAndCells = new int[3][]
            {
                new[]{1,2,3},
                new[]{4,5,6},
                new[]{7,8,9},
            };

            for (int i = 0; i < rowsAndCells.Length; i++)
            {
                Console.WriteLine($"Row: {i+1}");
                foreach (var num in rowsAndCells[i])
                {
                    Console.WriteLine($"value: {num}");
                }
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            var numbersVar = new[]{ 1, 2, 3, 4, 5 };

            int[] testNum = new int[5] { 1, 2, 3, 4, 5 };

            
        }
    }
}
