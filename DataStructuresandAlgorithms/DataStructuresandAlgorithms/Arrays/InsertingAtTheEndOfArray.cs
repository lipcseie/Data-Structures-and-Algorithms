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
        public int[] CreateArrayWithInsertAtEnd()
        {
            int[] intArray = new int[6];

            // Make a variable to keep the length. Length ased off capicity and does track the actual index
            int length = 0;

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                // it inserts the value i + 1 into the array at the position length.
                intArray[length] = i + 1;
                length++;
            }

            // assign the last element to 8
            intArray[length] = 8;

            return intArray;
        }

    }
}
