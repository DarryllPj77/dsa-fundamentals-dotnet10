using System;
using System.Collections.Generic;
namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulation of using List for Array");

            // Simulation of using List for array collection
            // - A List<T> is a collection whose size can grow or shrink.

            /*List<int> numbers = new List<int>()
            {
                10,30,40,50,60,70
            };

            Console.WriteLine(numbers.Count);

            //for (int i = numbers.Count - 1; i >= 0; i--)
            //{
            //    if (numbers[i] == 40)
            //    {
            //        Console.WriteLine($"{numbers[i]} is equal to 40");
            //    }
            //    else if (numbers[i] < 40)
            //    {
            //        Console.WriteLine($"{numbers[i]} is less than 40");
            //    }
            //    else if(numbers[i] > 40)
            //    {
            //        Console.WriteLine($"{numbers[i]} is greater than 40, removed!");
            //        numbers.RemoveAt(i);
            //    }
            //}


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 40)
                {
                    Console.WriteLine($"{numbers[i]} is equal to 40");
                }
                else if (numbers[i] < 40)
                {
                    Console.WriteLine($"{numbers[i]} is less than 40");
                }
                else if (numbers[i] > 40)
                {
                    Console.WriteLine($"{numbers[i]} is greater than 40, removed!");
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }

            Console.WriteLine("Updated Array: ");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }*/

            //The core difference is how they identify what to delete: Remove() deletes an item by its value, 
            //whereas RemoveAt() deletes an item by its index position.


            //List<int> numbers = new List<int>(10);

            //numbers.Add(1); 
            //numbers.Add(1); 
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //numbers.Add(1);
            //Console.WriteLine(numbers.Count);
            //numbers.Add(1);

            ////foreach (var item in numbers)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //Console.WriteLine(numbers.Count);

            // Common List<T> example

            // 1. Creating a list
            //List<int> numbers = new List<int>
            //{
            //    10,20,30
            //};

            // 2. Adding List
            List<string> names = new List<string>();

            names.Add("Darryll");
            names.Add("Anna");
            names.Add("John");
            Console.WriteLine("\nAdding Elements");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            // 3. Reading Elements
            Console.WriteLine("\nReading Elements");
            Console.WriteLine(names[0]);
            Console.WriteLine();

            // 4.
            Console.WriteLine("Displaying List");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentId}: {student.Name}");
            }

            // 5. Sorting a list

            List<int> listNum = new List<int>()
            {
                3,1,5,2,9,0,22,99
            };

            Console.WriteLine("\nSorting List");
            Console.WriteLine("Not Sorted");
            foreach (var item in listNum)
            {
                Console.WriteLine(item);
            }

            listNum.Sort();
            Console.WriteLine("Sorted");
            foreach (var item in listNum)
            {
                Console.WriteLine(item);
            }

        }

        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
        }

        static List<Student> students = new List<Student>
        {
            new Student
            {
                StudentId = 1,
                Name = "Darryll"
            },

            new Student
            {
                StudentId = 2,
                Name = "Celeine"
            }
        };

        
    }
}
