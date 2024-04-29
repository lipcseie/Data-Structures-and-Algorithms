using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Arrays
{
    public class InsertingAnywhere
    {
        public int[] CreateArray()
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            for( int i = 4; i >= 2; i--)
            {
                // shift each element one position to the right
                intArray[i + 1] = intArray[i];
            }

            intArray[2] = 8;

            return intArray;
        }
    }
}
