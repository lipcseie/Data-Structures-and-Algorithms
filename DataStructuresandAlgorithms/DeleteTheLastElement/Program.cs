namespace DeleteTheLastElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3, 4, 5, 6 };
            int[] result = DeleteTheLastElement(originalArray);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] DeleteTheLastElement(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty");
            }

            int length = array.Length;
            int[] newArray = new int[length - 1];
            Array.Copy(array, newArray, length - 1);
            return newArray;
        }
    }
}
