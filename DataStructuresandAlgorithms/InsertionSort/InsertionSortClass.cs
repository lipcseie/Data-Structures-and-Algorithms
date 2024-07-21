using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    // Stable Sorting Algorithm
    // example gif: https://upload.wikimedia.org/wikipedia/commons/0/0f/Insertion-sort-example-300px.gif
    public class InsertionSortClass
    {
        public static void InsertionSort(int[] array)
        {
            // partIndex represents the wall between the sorted and unsorted parts of the array
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int currentlyUnsorted = array[partIndex];
                int i = 0;

                // This loop moves from the current partIndex backward through the sorted portion of the array
                // i starts at partIndex and decreases until it finds the correct position for currentlyUnsorted
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
