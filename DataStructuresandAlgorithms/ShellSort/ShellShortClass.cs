using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    // Unstable
    public class ShellShortClass
    {
        public static void ShellShort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }

                gap /= 3;
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
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
