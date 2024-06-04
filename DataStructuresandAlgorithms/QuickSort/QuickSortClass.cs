using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    // Unstable
    public class QuickSortClass
    {
        public static void QuickSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            int Partition (int low, int high)
            {
                int i = low;
                int j = high + 1;

                int pivot = array[low];
                while (true)
                {
                    while (array[++i] < pivot)
                        if (i == high)
                           break;

                    while (pivot < array[--j])
                        if ( j == low) 
                            break;

                    if (i >= j)
                        break;

                    Swap(array, i, j);
                }
                Swap(array, low, j);
                return j;
            }
        }

        public static void Swap(int[] array, int i, int j)
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
