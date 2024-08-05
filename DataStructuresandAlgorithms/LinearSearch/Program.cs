using System.Diagnostics;

namespace LinearSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Data-Structures-and-Algorithms\DataStructuresandAlgorithms\DataStructuresandAlgorithms\Data\8Kints.txt";
            int[] numbers = ReadIntsFromFile(filePath);

            if (numbers.Length > 0)
            {
                int target = 875219;
                Console.WriteLine($"Searching for {target} in the array...");

                Stopwatch stopwatch = Stopwatch.StartNew();

                int resultIndex = LinearSearch(numbers, target);

                stopwatch.Stop();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Time taken to search: {stopwatch.ElapsedMilliseconds} ms");
                Console.ResetColor();

                if (resultIndex != -1)
                {
                    Console.WriteLine($"Target {target} found at index: {resultIndex}");
                }
                else
                {
                    Console.WriteLine($"Target {target} not found in the array.");
                }
            }
            else
            {
                Console.WriteLine("No data to search.");
            }
        }

        public static int LinearSearch(int[] array, int target)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            if (target < 0 )
            {
                throw new ArgumentException("Target must be a positive integer");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
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
