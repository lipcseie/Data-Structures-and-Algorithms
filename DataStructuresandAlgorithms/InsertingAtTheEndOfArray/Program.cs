using System.Diagnostics;

namespace InsertingAtTheEndOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Data-Structures-and-Algorithms\DataStructuresandAlgorithms\DataStructuresandAlgorithms\Data\8Kints.txt";
            int[] numbers = ReadIntsFromFile(filePath);

            if (numbers.Length > 0)
            {
                int newElement = 9;
  

                Console.WriteLine($"Inserting an element to the end of the arra...");

                Stopwatch stopwatch = Stopwatch.StartNew();

                int[] result = InsertingAtTheEndOfArray(numbers, newElement);

                stopwatch.Stop();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Time taken to insert the element: {stopwatch.ElapsedMilliseconds} ms");
                Console.ResetColor();

                Console.WriteLine("Array after insertion:");
                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("No data available for insertion.");
            }
        }

       public static int[] InsertingAtTheEndOfArray(int[] intArray, int newElement)
        {
            if (intArray == null || intArray.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            int length = intArray.Length;
            int[] newArray = new int[length + 1];

            for (int i = 0; i < intArray.Length; i++) 
            {
                newArray[i] = intArray[i];
            }
            // sets the last element of newArray to newElement
            newArray[length] = newElement;
            return newArray;
        }

        public static int[] ReadIntsFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int[] numbers = Array.ConvertAll(lines, int.Parse);
                return numbers;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return new int[0];
            }
        }
    }
}
