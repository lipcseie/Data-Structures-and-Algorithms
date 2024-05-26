using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    // Unstable Sorting Algorithm
    public class SelectionSortClass
    {
        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                // This variable keeps track of the index of the largest element found
                // in the current unsorted portion of the array.
                int largestAt = 0; 

                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] == array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array, largestAt, partIndex);
            }
        }
        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
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
