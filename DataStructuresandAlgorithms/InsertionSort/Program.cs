using System.Diagnostics;
using System.Globalization;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Data-Structures-and-Algorithms\DataStructuresandAlgorithms\DataStructuresandAlgorithms\Data\8Kints.txt";
            int[] numbers = InsertionSortClass.ReadIntsFromFile(filePath);

            if (numbers.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Array before sorting:");
                Console.WriteLine("------------------------\n");
                Console.ResetColor();
                Console.WriteLine(string.Join(",", numbers));

                Stopwatch stopwatch = Stopwatch.StartNew();

                InsertionSortClass.InsertionSort(numbers);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nArray after sorting:");
                Console.WriteLine("------------------------\n");
                Console.ResetColor();

                Console.WriteLine(string.Join(",", numbers));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Time taken to sort the array: {stopwatch.ElapsedMilliseconds} ms");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("No data to sort.");
            }
        }
    }
}
