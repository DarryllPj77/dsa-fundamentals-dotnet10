using System.ComponentModel.DataAnnotations;

namespace ArraysFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            <Data Type> : It defines the element type of the array.
            [ ] : Represents that the variable is an array type.
            <Name_Array> : It is the Name of array. 
             */


            // type [ ] < Name_Array > = new < datatype > [size];


            // < data_type > [] < arr_name > = { array_elements};
            // Use cases : The value of the array is directly initialized without taking its size
            int[] numbersExm1 = { 10, 20, 30, 40, 50 };

            int[] numbersExm2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("numbersExample 1: ");

            Console.Write("Example 1: ");
            Console.WriteLine(numbersExm1[2]);

            


            // <data_type>[] <arr_name> = new <data_type>[size]{ array_elements};
            // Use cases : Defining array with size and assigning the values at the same time

            int[] numbersExm3 = new int[5] { 1, 2, 3, 4, 5}; // the size is define so the array should contain 5 values

            // <data_type>[] <arr_name> = new <data_type>[size];
            // Use cases : Defining array with size, but not assigns values 

            int[] numberExp4 = new int[5];


            foreach (var num in numbersExm1)
            {
                Console.WriteLine(num);
            }

            foreach (var num in numbersExm3)
            {
                Console.WriteLine(num);
            }

            // Example of two Dimensional array
            int[,] arrayDi = new int[2,3]
            {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            //Console.WriteLine("\n\nTwo Dimensional Array");
            //for (int row = 0; row < arrayDi.GetLength(0); row++)
            //{
            //    for (int column = 0; column < arrayDi.GetLength(1); column++)
            //    {
            //        Console.Write(arrayDi[row, column] + " ");
            //    }

            //    Console.WriteLine();
            //}

            Console.WriteLine("\n\nTwo Dimensional Array with iteration");
            for (int row = 0; row < arrayDi.GetLength(0); row++)
            {
                Console.WriteLine($"Outer loop started: row = {row}");

                for (int column = 0; column < arrayDi.GetLength(1); column++)
                {
                    Console.WriteLine(
                        $"  Iteration: row = {row}, column = {column}, " +
                        $"value = {arrayDi[row, column]}"
                    );
                }

                Console.WriteLine($"Row {row} completed.");
                Console.WriteLine();
            }


            Console.WriteLine("Checker");
            Console.WriteLine(arrayDi.GetLength(0));

            Console.WriteLine();


            //Console.WriteLine("\n\nTwo Dimensional Array");
            //foreach (var item in arrayDi)
            //{
            //    Console.WriteLine(item + " ");
            //}



            // Example of three Dimensional Array
            /*
            int[2, 2, 3]

            This defines the size of each dimension:

            Dimension	Size	Meaning
            First	    2	    Layers
            Second	    2	    Rows in each layer
            Third	    3	    Columns in each row
             */


            int[,,] arr = new int[2, 2, 3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };

            for (int layer = 0; layer < arr.GetLength(0); layer++)
            {
                Console.WriteLine($"Layer {layer}:");

                for (int row = 0; row < arr.GetLength(1); row++)
                {
                    for (int column = 0; column < arr.GetLength(2); column++)
                    {
                        Console.Write(arr[layer, row, column] + " ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            // Jagged Arrays
        }
    }
}
