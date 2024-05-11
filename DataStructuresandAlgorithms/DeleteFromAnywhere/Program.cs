namespace DeleteFromAnywhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6, 7 };
            int[] result = DeleteFromAnywhere(originalArray, 3);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] DeleteFromAnywhere(int[] array, int position)
        {
            int length = array.Length;
            int[] newArray = new int[length - 1];

            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array most not be null or empty");
            }
            if (position < 0 || position >= array.Length)
            {
                throw new ArgumentException("Position must be a positive integer");
            }

            for (int i = 0; i < position; i++)
            {
                newArray[i] = array[i]; 
            }

            for(int i = position + 1; i < length; i++)
            {
                newArray[i - 1] = array[i];
            }
            return newArray;
        }
    }
}
