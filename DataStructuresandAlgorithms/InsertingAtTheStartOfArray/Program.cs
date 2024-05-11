namespace InsertingAtTheStartOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3 };
            int[] result = InsertingAtTheStartOfArray(originalArray, 9);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] InsertingAtTheStartOfArray(int[] array, int newElement)
        {
            int length = array.Length;
            int[] newArray = new int[length + 1];

            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            for (int i = array.Length - 1; i  >= 0; i--)
            {
                newArray[i + 1] = array[i];
            }

            newArray[0] = newElement;
            return newArray;
        }
    }
}
