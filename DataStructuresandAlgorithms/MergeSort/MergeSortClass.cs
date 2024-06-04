using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSortClass
    {
        public static void MergeSort(int[] array)
        {
            int[] auxiliary = new int[array.Length];

            Sort(0, array.Length - 1);

            // low, high, and mid are indices used to divide the array into smaller subarray
            void Sort(int low, int high)
            {
                if (high <= low) // if high is less than or equal to low, it means the portion of the array is already sorted
                    return;

                // Otherwise, it calculates the middle index mid,
                int mid = (low + high) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, auxiliary, low, high - low + 1);

                for (int k = low; k <= high; k++)
                {
                    if (i > mid) array[k] = auxiliary[j++];
                    else if (j > high) array[k] = auxiliary[i++];
                    else if (auxiliary[j] < auxiliary[i])
                        array[k] = auxiliary[j++];
                    else
                        array[k] = auxiliary[i++];
                }
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
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return new int[0];
            }
        }
    }
}
