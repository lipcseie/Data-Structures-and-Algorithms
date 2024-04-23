using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Arrays
{
    public class InsertingAtTheEndOfArray
    {
        // Inserting at the end of array O(1)
        public int[] CreateArray()
        {
            int[] intArray = new int[6];

            // Make a variable to keep the length. Length ased off capo=icity and doea track the actual index
            int length = 0;

            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            intArray[length] = 8;
            length++;

            return intArray;
        }

        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
