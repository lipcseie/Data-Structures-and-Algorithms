using System.Diagnostics;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ASUS\Data-Structures-and-Algorithms\DataStructuresandAlgorithms\DataStructuresandAlgorithms\Data\1Kints.txt"; // Update this path as needed
            int[] numbers = BubbleSortClass.ReadIntsFromFile(filePath);

            if (numbers.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Array before sorting:");
                Console.WriteLine("------------------------\n");
                Console.ResetColor();
                Console.WriteLine(string.Join(", ", numbers));

                Stopwatch stopwatch = Stopwatch.StartNew();

                BubbleSortClass.BubbleSort(numbers);

                BubbleSortClass.BubbleSort(numbers);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nArray after sorting:");
                Console.WriteLine("------------------------\n");
                Console.ResetColor();

                Console.WriteLine(string.Join(", ", numbers));

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
