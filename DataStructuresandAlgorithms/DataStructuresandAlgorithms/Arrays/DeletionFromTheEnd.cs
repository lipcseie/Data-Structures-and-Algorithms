using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Arrays
{
    public class DeletionFromTheEnd
    {
       public int[] DeleteTheLastElement()
        {
            int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // creates a new array that is one element shorter than the original
            int[] newArray = new int[original.Length - 1];

            // copies elements from the original array to the new array.
            // The third parameter specifies how many elements to copy.
            Array.Copy(original, newArray, original.Length - 1);

            return newArray;
        }
    }
}
