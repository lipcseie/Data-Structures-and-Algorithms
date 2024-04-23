using DataStructuresandAlgorithms.ADT;
using System.Runtime.InteropServices;

namespace DataStructuresandAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inserting at the end of array O(1)
            int[] intArray = new int[6];

            // Make a variable to keep the length. Length ased off capo=icity and doea track the actual index
            int length = 0;

            for (int i = 0; i < 3; i++)
            {
                intArray[length] = i +1 ;
                length++;
            }

            intArray[length] = 8;
            length++;

            // Print the array to the console
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
