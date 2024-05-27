using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    // Stable Sorting Algorithm
    internal class InsertionSortClass
    {
        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int currentlyUnsorted = array[partIndex];
                int i = 0;

                for ( i = partIndex; i > 0 && array[i - 1] > currentlyUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = currentlyUnsorted;
            }
        }

        public static int[] ReadIntsFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int[] numbers = Array.ConvertAll(lines, int.Parse);
                return numbers;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return new int[0];
            }
        }
    }
}
