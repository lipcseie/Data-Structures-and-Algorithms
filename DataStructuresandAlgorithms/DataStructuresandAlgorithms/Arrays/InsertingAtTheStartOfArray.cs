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

            // intArray.Length - 2 to avoid an IndexOutOfRangeException
            for (int i = intArray.Length - 2; i >= 0; i--)
            {
                // this is moving over all the values
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 20;
            return intArray;
        }

    }
}
