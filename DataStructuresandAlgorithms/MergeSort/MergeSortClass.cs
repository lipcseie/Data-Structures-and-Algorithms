using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSortClass
    {
        // Stable Sorting Algorithms
        // example gif: https://commons.wikimedia.org/wiki/File:Merge-sort-example-300px.gif#/media/File:Merge-sort-example-300px.gif
        public static void MergeSort(int[] array)
        {
            int[] auxiliary = new int[array.Length];

            Sort(0, array.Length - 1);

            // recursively dividing the array into smaller parts and sorting them, and it’s initially called on the entire array with Sort(0, array.Length - 1);
            void Sort(int low, int high) // low, high, and mid are indices used to divide the array into smaller subarray
            {
                if (high <= low) // if high is less than or equal to low, it means the portion of the array is already sorted
                    return;

                // Otherwise, it calculates the middle index mid,
                int mid = (low + high) / 2;

                // these lines call the Sort method on two parts of the array: the first part is the part between the low and mid indices, and the second part is the part between the mid+1 and high indices.
                Sort(low, mid);  
                Sort(mid + 1, high); 
                Merge(low, mid, high); // After the two parts have been sorted, this line calls the Merge method, which merges the two sorted parts.
            }

            void Merge(int low, int mid, int high)
            {
                int i = low; // Initialize 'i' to the start of the first subarray
                int j = mid + 1; // Initialize 'j' to the start of the second subarray

                // Copy the elements from the original array to the auxiliary array
                Array.Copy(array, low, auxiliary, low, high - low + 1);

                // Iterate over the subarrays
                for (int k = low; k <= high; k++)
                {
                    if (i > mid) // If we've exhausted all elements in the first subarray
                        array[k] = auxiliary[j++]; // Copy the remaining elements from the second subarray
                    else if (j > high) // If we've exhausted all elements in the second subarray
                        array[k] = auxiliary[i++]; // Copy the remaining elements from the first subarray
                    else if (auxiliary[j] < auxiliary[i]) // If the current element in the second subarray is smaller than the current element in the first subarray
                        array[k] = auxiliary[j++]; // Copy the smaller element to the original array
                    else // If the current element in the first subarray is smaller or equal
                        array[k] = auxiliary[i++]; // Copy the smaller or equal element to the original array
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
