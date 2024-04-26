using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Arrays
{
    public class InsertingAtTheStartOfArray
    {

        // Inserting at the start of an array
        public int[] CreateArray()
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6}; 

            for(int i = 3; i >= 0; i--)
            {
                // this is moving over all the values
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 20;
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
