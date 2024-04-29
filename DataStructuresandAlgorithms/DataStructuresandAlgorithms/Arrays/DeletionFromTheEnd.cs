using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresandAlgorithms.Arrays
{
    internal class DeletionFromTheEnd
    {
       public int[] DeletionTheLastElement()
        {
            int[] original = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] newArray = new int[original.Length - 1];
            Array.Copy(original, newArray, original.Length - 1);

            return newArray;

        }
    }
}
