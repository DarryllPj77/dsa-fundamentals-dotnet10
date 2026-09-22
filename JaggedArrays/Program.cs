namespace JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explain what is Jagged Array");

            // Declaration
            int[][] jaggedArray = new int[3][];


            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 7, 8, 9 };


            // Iterating the Elements 
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Row " + i + ": " );
                foreach (var num in jaggedArray[i])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
