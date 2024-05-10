namespace InsertingAtTheEndOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            var result = InsertingAtTheEndOfArray(arr, 8);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

       public static int[] InsertingAtTheEndOfArray(int[] intArray, int newElement)
        {
            int length = intArray.Length;
            int[] newArray = new int[length + 1];

            for (int i = 0; i < intArray.Length; i++) 
            {
                newArray[i] = intArray[i];
            }
            newArray[length] = newElement;
            return newArray;

        }
    }
}
