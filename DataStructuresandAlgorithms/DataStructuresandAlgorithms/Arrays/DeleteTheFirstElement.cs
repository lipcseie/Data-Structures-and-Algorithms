using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Arrays
{
    public class DeleteTheFirstElement
    {
        public int[] DeleteTheFirstElementFromTheArray()
        {
            int[] intArray = new int[9];

            // Fill the array with some values for demonstration
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i + 1;
            }

            int length = intArray.Length;

            for (int i = 1; i < length; i++)
            {
                intArray[i - 1] = intArray[i];
            }
            length--;

            // Create a new array without the last element
            int[] newArray = new int[length];
            Array.Copy(intArray, newArray, length);

            return newArray;
        }
    }
}
