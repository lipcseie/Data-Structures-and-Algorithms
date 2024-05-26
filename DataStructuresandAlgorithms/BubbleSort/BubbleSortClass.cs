using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public  class BubbleSortClass
    {
         // Stable Sorting Algorithm
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for(int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
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
