namespace InsertElementAtPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] result = InsertElementAtPosition(originalArray, 99, 5);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] InsertElementAtPosition(int[] array, int newElement, int position)
        {
            int length = array.Length;
            int[] newArray = new int[length + 1];

            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = position;i < length; i++)
            {
                newArray[i + 1] = array[i];
            }
            newArray[position] = newElement;
            return newArray;
        }
    }
}
