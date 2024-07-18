using System.Diagnostics;

namespace InsertElementAtPosition
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Data-Structures-and-Algorithms\DataStructuresandAlgorithms\DataStructuresandAlgorithms\Data\8Kints.txt";
            int[] numbers = ReadIntsFromFile(filePath);

            if (numbers.Length > 0)
            {
                int newElement = 99;
                int position = 105;

                Console.WriteLine($"Inserting {newElement} at position {position}...");

                Stopwatch stopwatch = Stopwatch.StartNew();

                int[] result = InsertElementAtPosition(numbers, newElement, position);

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
        public static int[] InsertElementAtPosition(int[] array, int newElement, int position)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            if (position < 0 || position >= array.Length)
            {
                throw new ArgumentException("Position must be a positive integer");
            }

            int length = array.Length;
            int[] newArray = new int[length + 1];

            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = position;i < length; i++)
            {
                newArray[i + 1] = array[i];
            }
            newArray[position] = newElement;
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
